using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BlazorCRUD1.Contracts;
using BlazorCRUD1.Concrete;
using Blazored.Modal;
using System.Globalization;

namespace BlazorCRUD1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<DataAccess.AppContext>(options =>
                          options.UseSqlServer(
                              Configuration.GetConnectionString("DefaultConnection")));
            //Article service  
            services.AddScoped<IArticleManager, ArticleManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IStockManager, StockManager>();
            services.AddScoped<ICustomerManager, CustomerManager>();
            services.AddScoped<ISaleTxnManager, SaleTxnManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IStoreManager, StoreManager>();
            //Register dapper in scope  
            services.AddScoped<IDapperManager, DapperManager>();
            services.AddBlazoredModal();

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            var supportedCultures = new List<CultureInfo> {  new CultureInfo("zh-hk"), new CultureInfo("en") };
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("zh-hk");
                options.SupportedUICultures = supportedCultures;
            });

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRequestLocalization();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
