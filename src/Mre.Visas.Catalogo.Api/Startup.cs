using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mre.Visas.Catalogo.Application;
using Mre.Visas.Catalogo.Infrastructure;
using Newtonsoft.Json;
using Mre.Visas.Catalogo.Api.Extensions;

namespace Mre.Visas.Catalogo.Api
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
      services.AddInfrastructureLayer(Configuration);
      services.AddApplicationLayer();

      services.AddControllers().AddNewtonsoftJson(options =>
      {
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
      });

      //ADD CROSS
      services.AddCors();
      services.AddSwaggerExtension("Mre.Visas.Catalogo.Api", "v1");
      //services.AddSwaggerGen(c =>
      //{
      //  c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mre.Visas.Catalogo.Api", Version = "v1" });
      //});
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        //app.UseSwagger();
        //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mre.Visas.Catalogo.Api v1"));
      }

      app.UseRouting();
      app.UseSwaggerExtension("Mre.Visas.Catalogo.Api");
      app.UseAuthorization();

      //ADD CROSS
      // global cors policy
      app.UseCors(x => x
          .AllowAnyMethod()
          .AllowAnyHeader()
          .SetIsOriginAllowed(origin => true) // allow any origin
          .AllowCredentials()); // allow credentials

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
