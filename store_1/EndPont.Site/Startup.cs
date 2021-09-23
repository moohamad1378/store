using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store_1.Persistence.Context;
using Store_1.Application.Interfaces.Context;
using Store_1.Application.Services.Users.Queries.GetUsers;
using Store_1.Application.Services.Users.Queries.getRoles;
using Store_1.Application.Services.Users.commands.RegisterUser;
using Store_1.Application.Services.Users.Commands.RemoveUser;
using Store_1.Application.Services.Users.Commands.UserStatuseChange;
using Store_1.Application.Services.Users.Commands.EditUser;
using Store_1.Application.Services.Users.Commands.UserLogin;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Store_1.Application.Interfaces.FacadPatterns;
using Store_1.Application.Services.Products.FacadPattern;
using Store_1.Application.Services.Common.Queries;
using Store_1.Application.Services.Common.Queries.GetCategory;
using Store_1.Application.Services.HomePages.AddNewSlider;
using Store_1.Application.Services.Common.Queries.GetSlider;
using Store_1.Application.Services.HomePages.AddHomePageImages;
using Store_1.Application.Services.Common.Queries.GetHomePageImages;
using Store_1.Application.Services.Carts;
using Store_1.Application.Services.Fainances.Commands.AddRequestPay;
using Store_1.Common.Roles;
using Store_1.Application.Services.Fainances.Queries.GetRequestPayService;
using Store_1.Application.Services.Orders.Commands;
using Store_1.Application.Services.Orders.Queries.GetUserOrders;
using Store_1.Application.Services.Orders.Queries.GetOrdersForAdmin;
using Store_1.Application.Services.Fainances.Queries.GetRequestPayForAdmin;
using Store_1.Application.Services.HomePages.GetSlilerImages;
using Store_1.Application.Services.HomePages.RemoveSliderImage;

namespace EndPont.Site
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
            services.AddAuthorization(option =>
            {
                option.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
                option.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
                option.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
            });
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
            });

            services.AddScoped<IGetUserService, GetUserService>();
            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IUserStatuseChangeService, UserStatuseChangeService>();
            services.AddScoped<IEditUserService, EditUserService>();
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IAddNewSliderService, AddNewSliderService>();
            services.AddScoped<IGetSliderService, GetSliderService>();
            services.AddScoped<IAddHomePageImagesService,AddHomePageImagesService>();
            services.AddScoped<IGetHomePageImagesService, GetHomePageImagesService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IAddRequestPayService, AddRequestPayService>();
            services.AddScoped<IGetRequestPayService, GetRequestPayService>();
            services.AddScoped<IAddNewOrderService, AddNewOrderService>();
            services.AddScoped<IGetUserOrdersService, GetUserOrdersService>();
            services.AddScoped<IGetOrdersForAdminService, GetOrdersForAdminService>();
            services.AddScoped<IGetRequestPayForAdminService, GetRequestPayForAdminService>();
            services.AddScoped<IGetSliderImagesService, GetSliderImagesService>();
            services.AddScoped<IRemoveSliderImageService, RemoveSliderImageService>();




            



            //FacadeInject
            services.AddScoped<IProductFacad, ProductFacad>();


            services.AddScoped<IGetMenuItemService, GetMenuItemService>();
            services.AddScoped<IGetCategoryService, GetCategoryService>();

            services.AddScoped<IDataBaseContext, DataBaseContext>();
            string conectionString = @"Data Source=DESKTOP-GVI1SCO;initial catalog=avalinsiteDB;integrated security=true";
            
            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(conectionString));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
           
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                     name: "areas",
                     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}" );
            });
        }
    }
}
