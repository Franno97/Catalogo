using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mre.Visas.Catalogo.Application.Repositories;
using Mre.Visas.Catalogo.Application.Shared.Interfaces;
using Mre.Visas.Catalogo.Application.Catalogo.Repositories;
using Mre.Visas.Catalogo.Infrastructure.Persistence.Contexts;
using Mre.Visas.Catalogo.Infrastructure.Shared.Interfaces;
using Mre.Visas.Catalogo.Infrastructure.Shared.Repositories;
using Mre.Visas.Catalogo.Infrastructure.Catalogo.Repositories;

namespace Mre.Visas.Catalogo.Infrastructure
{
  public static class ServiceRegistrations
  {
    public static void AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddDbContext<ApplicationDbContext>(
          options => options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"),
          options => options.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
      

      services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

      services.AddTransient<IUnitOfWork, UnitOfWork>();

      services.AddTransient<ICatalogoRepository, CatalogoRepository>();

      services.AddTransient<ICatalogoCabeceraRepository, CatalogoCabeceraRepository>();


    }
  }
}