using Mre.Visas.Catalogo.Application.Catalogo.Repositories;

using System.Threading.Tasks;

namespace Mre.Visas.Catalogo.Application.Shared.Interfaces
{
  public interface IUnitOfWork
  {
    ICatalogoRepository CatalogoRepository { get; }

    ICatalogoCabeceraRepository CatalogoCabeceraRepository { get; }


    Task<(bool, string)> SaveChangesAsync();
  }
}