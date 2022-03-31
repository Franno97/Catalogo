using Mre.Visas.Catalogo.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Mre.Visas.Catalogo.Application.Catalogo.Repositories
{
  public interface ICatalogoRepository : IRepository<Domain.Entities.Catalogo>
  {
    Task<List<Domain.Entities.Catalogo>> GetByCatalogoCabeceraCodigoAsync(string codigoCatalogo);

    Task<Domain.Entities.Catalogo> GetByCodigoAsync(string codigoCatalogo, string codigo);

    Task<Domain.Entities.Catalogo> GetByCodigoMdgAsync(string codigoCatalogo, string codigoMdg);

    Task<Domain.Entities.Catalogo> GetByCodigoEsigexAsync(string codigoCatalogo, string codigoEsigex);

    Task<Domain.Entities.Catalogo> GetByCodigoOtroAsync(string codigoCatalogo, string codigoOtro);

    Task<Domain.Entities.Catalogo> GetByCompletoAsync();
  }


  public interface ICatalogoCabeceraRepository : IRepository<Domain.Entities.CatalogoCabecera>
  {

  }
}
