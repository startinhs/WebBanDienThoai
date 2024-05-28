using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.Web.MailService;

namespace WebsiteBanDienThoai23.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddOptions();
            var mailsettings = Configuration.GetSection("MailSettings");

            services.Configure<MailSettings>(mailsettings);

            services.AddTransient<SendMailService>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian timeout cho session
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
            services.AddDistributedMemoryCache();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/DangNhap"; // Đường dẫn đến trang đăng nhập
                });

            services.AddDbContext<QLBanDienThoaiContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapGet("/testmail", async context => {

                    // Lấy dịch vụ sendmailservice
                    var sendmailservice = context.RequestServices.GetService<SendMailService>();

                    string ten = "Trường";
                    int a = 123456;

                    MailContent content = new MailContent
                    {
                        To = "nguyenichtruong77@gmail.com",
                        Subject = "Kiểm tra thử",
                        Body = String.Format("<div style=\"font-family: Helvetica,Arial,sans-serif;min-width:1000px;overflow:auto;line-height:2\">\n  <div style=\"margin:50px auto;width:70%;padding:20px 0\">\n    <div style=\"border-bottom:1px solid #eee\">\n      <a href=\"\" style=\"font-size:1.4em;color: #00466a;text-decoration:none;font-weight:600\">MoblilePhone Store</a>\n    </div>\n    <p style=\"font-size:1.1em\">Xin chào {0}</p>\n    <p>Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn. Nhập mã đặt lại mật khẩu sau đây:</p>\n    <h2 style=\"background: #00466a;margin: 0 auto;width: max-content;padding: 0 10px;color: #fff;border-radius: 4px;\">{1}</h2>\n    <p style=\"font-size:0.9em;\">Regards,<br />Your Brand</p>\n    <hr style=\"border:none;border-top:1px solid #eee\" />\n    <div style=\"float:right;padding:8px 0;color:#aaa;font-size:0.8em;line-height:1;font-weight:300\">\n      <p>MoblilePhone Store</p>\n      <p>97 Võ Văn Tần, Quận 3</p>\n      <p>TP HCM</p>\n    </div>\n  </div>\n</div>", ten, a)
                    };

                    var kq = await sendmailservice.SendMail(content);
                    await context.Response.WriteAsync(kq.ToString());
                });

            });
        }
    }
}
