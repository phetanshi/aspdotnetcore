using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Repository;
using EmployeeManagement.Service;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using EmployeeManagement.Security;

namespace EmployeeManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Config = configuration;
        }

        public IConfiguration Config { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDBContext>(options => options.UseSqlServer(Config.GetConnectionString("EmployeeDBConnection")));

            //Identity Services
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<AppDBContext>();

            services.AddControllersWithViews(config => {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Administration/AccessDenied");
            });

            services.AddAuthorization(options => {
                //options.AddPolicy("EditRolePolicy", policy => policy.RequireClaim("Edit Role").RequireRole("Admin"));
                //options.AddPolicy("EditRolePolicy", policy => policy.RequireAssertion(context => AuthorizeAccess(context, "Edit Role")));

                options.AddPolicy("AdminRolePolicy", policy => policy.RequireAssertion(context => AuthorizeAccess(context)));

                options.AddPolicy("EditRolePolicy", policy => policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement()));

                options.AddPolicy("DeleteRolePolicy", policy => policy.RequireAssertion(context => AuthorizeAccess(context, "Delete Role")));
            });

            //services.AddScoped<IEmployeeRepository, MockEmployeeRepository>();
            services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndClaimsHandler>();
            services.AddSingleton<IAuthorizationHandler, SuperAdminHandler>();
        }

        private bool AuthorizeAccess(AuthorizationHandlerContext context, string claimType)
        {
            return context.User.IsInRole("Admin") &&
                    context.User.HasClaim(claim => claim.Type == claimType && claim.Value == "true") ||
                    context.User.IsInRole("Super Admin");
        }

        private bool AuthorizeAccess(AuthorizationHandlerContext context)
        {
            return context.User.IsInRole("Admin")  || context.User.IsInRole("Super Admin");
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
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
