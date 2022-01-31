using Business.CustomExtensions;
using Dal.Extensions;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
            services.AddCors();
            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddMemoryCache();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<BasketDbContext>(opt => opt.UseInMemoryDatabase("TestDB"));

            services.AddDataModule(Configuration);
            services.AddBusinessModule(Configuration);

            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", //Name the security scheme
                     new OpenApiSecurityScheme
                     {
                         Description = "JWT Authorization header using the Bearer scheme.",
                         Type = SecuritySchemeType.Http, //We set the scheme type to http since we're using bearer authentication
                         Scheme = "bearer" //The name of the HTTP Authorization scheme to be used in the Authorization header. In this case "bearer".
                     });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                                {
                                    new OpenApiSecurityScheme{
                                        Reference = new OpenApiReference{
                                            Id = "Bearer", //The name of the previously defined security scheme.
                                            Type = ReferenceType.SecurityScheme
                                        }
                                    },new List<string>()
                                }
                            });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BaskeTAPI", Version = "v1" });
            });

            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            var scopeeee = app.ApplicationServices.CreateScope();
            var context = scopeeee.ServiceProvider.GetRequiredService<BasketDbContext>();
            AddTestData(context);


            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private static void AddTestData(BasketDbContext context)
        {

            context.Categories.Add(new Category { Id = new Guid("5da9bc0d-b9db-48ca-ac89-e12df8cf61f1"), Name = "Catgory1" });
            context.Categories.Add(new Category { Id = new Guid("a9ec51c8-1f22-49f1-89af-6dd9a776f652"), Name = "Catgory2" });
            context.Categories.Add(new Category { Id = new Guid("0785fd62-b8e2-4f73-8b8b-90b47ccd7511"), Name = "Catgory3" });


            context.Products.Add(new Product
            {
                Id = new Guid("8cfcf5d4-bf8c-4d13-9c0e-518a8dc5f299"),
                Name = "Product1",
                CategoryId = new Guid("5da9bc0d-b9db-48ca-ac89-e12df8cf61f1"),
                CreateDate = DateTime.UtcNow,
                ImageUrl = "",
                Description = "Temizlik ürünü",
                Stock = 2
            });

            context.Products.Add(new Product
            {
                Id = new Guid("271a2fae-ff08-495a-a33d-b2bc6a28c66e"),
                Name = "Product2",
                CategoryId = new Guid("a9ec51c8-1f22-49f1-89af-6dd9a776f652"),
                CreateDate = DateTime.UtcNow,
                ImageUrl = "",
                Description = "Market ürünü",
                Stock = 5
            });

            context.Products.Add(new Product
            {
                Id = new Guid("adec82df-e885-4183-8f49-11237589c18b"),
                Name = "Product3",
                CategoryId = new Guid("0785fd62-b8e2-4f73-8b8b-90b47ccd7511"),
                CreateDate = DateTime.UtcNow,
                ImageUrl = "",
                Description = "Giyim ürünü",
                Stock = 1
            });

            context.ProductPrices.Add(new ProductPrice { Id = Guid.NewGuid(), ProductId = new Guid("8cfcf5d4-bf8c-4d13-9c0e-518a8dc5f299"), Price = 21.4, StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddMonths(1) });
            context.ProductPrices.Add(new ProductPrice { Id = Guid.NewGuid(), ProductId = new Guid("271a2fae-ff08-495a-a33d-b2bc6a28c66e"), Price = 45.8, StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddMonths(1) });
            context.ProductPrices.Add(new ProductPrice { Id = Guid.NewGuid(), ProductId = new Guid("adec82df-e885-4183-8f49-11237589c18b"), Price = 100, StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddMonths(1) });

            context.Campaigns.Add(new Campaign
            {
                Id = 1,
                ProductId = new Guid("8cfcf5d4-bf8c-4d13-9c0e-518a8dc5f299"),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddMonths(1),
                CampaignType = Core.Common.Enums.CampaignType.DiscountAmount,
                CreateDate = DateTime.UtcNow,
                Discount = 2
            });

            context.Campaigns.Add(new Campaign
            {
                Id = 2,
                ProductId = new Guid("271a2fae-ff08-495a-a33d-b2bc6a28c66e"),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddMonths(1),
                CampaignType = Core.Common.Enums.CampaignType.DiscountRate,
                CreateDate = DateTime.UtcNow,
                Discount = 10
            });

            context.SaveChanges();
        }
    }
}
