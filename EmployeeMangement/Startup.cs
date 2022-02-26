#define InvalidModelStateResponseFactory
//#define ExceptionFilter


using EmployeeMangement.DataLayer;
using EmployeeMangement.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMangement.DataContext;
using EmployeeMangement.Infrastructure;

#if InvalidModelStateResponseFactory
using System.Net.Mime;
#endif

#if ExceptionFilter
using EmployeeMangement.Infrastructure.Filters;
#endif

namespace EmployeeMangement
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
            services.AddControllers();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<Mapping>();
            services.AddControllers().AddNewtonsoftJson(x =>
                x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            services.AddDbContextPool<EmployeeContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EmployeeDatabase")));


            #if InvalidModelStateResponseFactory
            // <snippet_DisableProblemDetailsInvalidModelStateResponseFactory>
            services.AddControllers()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        var result = new BadRequestObjectResult(context.ModelState);

                        // TODO: add `using System.Net.Mime;` to resolve MediaTypeNames
                        result.ContentTypes.Add(MediaTypeNames.Application.Json);
                        result.ContentTypes.Add(MediaTypeNames.Application.Xml);

                        return result;
                    };
                });
            // </snippet_DisableProblemDetailsInvalidModelStateResponseFactory>
            #endif

            #if ExceptionFilter
            // <snippet_AddExceptionFilter>
            services.AddControllers(options =>
                options.Filters.Add(new HttpResponseExceptionFilter()));
            // </snippet_AddExceptionFilter>
            #endif
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
                app.UseExceptionHandler("/error");
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
