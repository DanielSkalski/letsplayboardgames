using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsPlayBoardgames.Api.Mappings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LetsPlayBoardgames
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
            services.AddMvc(options => 
            {
                options.ReturnHttpNotAcceptable = true;
            });

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IUrlHelper, UrlHelper>(implementationFactor =>
            {
                var actionContext = implementationFactor.GetService<IActionContextAccessor>().ActionContext;
                return new UrlHelper(actionContext);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug(LogLevel.Information);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            AutoMapper.Mapper.Initialize(MappingsConfig.ConfigureMappings);

            app.UseMvc();
        }
    }
}
