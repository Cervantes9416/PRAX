using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PRAXYS.Business;
using PRAXYS.Business.Helpers;
using PRAXYS.Business.Interfaces;
using PRAXYS.Business.Profiles;
using PRAXYS.Data;
using PRAXYS.Data.DALC;
using PRAXYS.Data.Intefaces;
using System;
using System.Linq;
using System.Text;

namespace PRAXYS.Server
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EntityProfile));
            
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ServerDataConnection"),b => b.MigrationsAssembly("PRAXYS.Server")));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc().AddNewtonsoftJson(options =>
                 options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
               .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
                    services.AddResponseCompression(opts =>
                    {
                        opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                            new[] { "application/octet-stream" });
                    });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(configuration["jwt:key"])),
                        ClockSkew = TimeSpan.Zero
                    });

            services.AddScoped<ICoverageBLC, CoverageBLC>();
            services.AddScoped<ICoverageDALC, CoverageDALC>();
            
            services.AddScoped<ICoveragePlanBLC, CoveragePlanBLC>();
            services.AddScoped<ICoveragePlanDALC, CoveragePlanDALC>();

            services.AddScoped<IAgentBLC, AgentBLC>();
            services.AddScoped<ISubAgentBLC, SubAgentBLC>();
            services.AddScoped<IClientDocumentationBLC, ClientDocumentationBLC>();
            services.AddScoped<ICompanyBLC, CompanyBLC>();
            services.AddScoped<IInsuranceDocumentationBLC, InsuranceDocumentationBLC>();
            services.AddScoped<IClientBLC, ClientBLC>();
            services.AddScoped<IInsuranceBLC, InsuranceBLC>();
            services.AddScoped<IPaymentTypeBLC, PaymentTypeBLC>();
            services.AddScoped<IReportBLC, ReportBLC>();
            services.AddScoped<IBondBLC, BondBLC>();
            services.AddScoped<IEndorsementBLC, EndorsementBLC>();
            services.AddScoped<IBranchBLC, BranchBLC>();
            services.AddScoped<IFilesRepository, AzureHelper>();
            services.AddScoped<IPaymentTypeBLC, PaymentTypeBLC>();
            services.AddScoped<IBondPayment, BondPaymentBLC>();
            services.AddScoped<IEndorsementBLC, EndorsementBLC>();
            services.AddScoped<IComissionPaymentBLC, ComissionPaymentBLC>();
            services.AddScoped<IPaymentInformation, PaymentInformationBLC>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBlazorDebugging();
            }
            
            app.UseStaticFiles();
            app.UseClientSideBlazorFiles<Client.Startup>();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapFallbackToClientSideBlazor<Client.Startup>("index.html");
            });
        }
    }
}
