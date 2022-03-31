using Microsoft.EntityFrameworkCore;
using Mre.Visas.Catalogo.Application.Catalogo.Repositories;
using Mre.Visas.Catalogo.Infrastructure.Persistence.Contexts;
using Mre.Visas.Catalogo.Infrastructure.Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mre.Visas.Catalogo.Infrastructure.Catalogo.Repositories
{
  public class CatalogoRepository : Repository<Domain.Entities.Catalogo>, ICatalogoRepository
  {
    #region Constructors

    public CatalogoRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    #endregion Constructors

    #region Metodos Others 

    public async Task<List<Domain.Entities.Catalogo>> GetByCatalogoCabeceraCodigoAsync(string codigoCatalogo)
    {
      var query = from catCab in _context.CatalogoCabeceras
                  join catDet in _context.Catalogos on catCab.Id equals catDet.CatalogoCabeceraId
                  where catCab.Codigo == codigoCatalogo
                  select catDet;

      return await query.ToListAsync().ConfigureAwait(false);
      //return await _context.Catalogos.Where(x => x.CatalogoCabeceraId == id && !x.IsDeleted).ToListAsync();
    }

    public async Task<Domain.Entities.Catalogo> GetByCodigoAsync(string codigoCatalogo, string codigo)
    {
      var query = from catCab in _context.CatalogoCabeceras
                  join catDet in _context.Catalogos on catCab.Id equals catDet.CatalogoCabeceraId
                  where catCab.Codigo == codigoCatalogo && catDet.Codigo == codigo
                  select catDet;

      return await query.FirstOrDefaultAsync().ConfigureAwait(false);

      //return await _context.Catalogos.FirstOrDefaultAsync(x => x.CatalogoCabeceraId == catalogoCabeceraId && x.Codigo == codigo && !x.IsDeleted);
    }

    public async Task<Domain.Entities.Catalogo> GetByCodigoMdgAsync(string codigoCatalogo, string codigo)
    {
      var query = from catCab in _context.CatalogoCabeceras
                  join catDet in _context.Catalogos on catCab.Id equals catDet.CatalogoCabeceraId
                  where catCab.Codigo == codigoCatalogo && catDet.CodigoMdg == codigo
                  select catDet;

      return await query.FirstOrDefaultAsync().ConfigureAwait(false);
      //      return await _context.Catalogos.FirstOrDefaultAsync(x => x.CatalogoCabeceraId == catalogoCabeceraId && x.CodigoMdg == codigoMdg && !x.IsDeleted);
    }

    public async Task<Domain.Entities.Catalogo> GetByCodigoEsigexAsync(string codigoCatalogo, string codigo)
    {
      var query = from catCab in _context.CatalogoCabeceras
                  join catDet in _context.Catalogos on catCab.Id equals catDet.CatalogoCabeceraId
                  where catCab.Codigo == codigoCatalogo && catDet.CodigoEsigex == codigo
                  select catDet;

      return await query.FirstOrDefaultAsync().ConfigureAwait(false);
      //return await _context.Catalogos.FirstOrDefaultAsync(x => x.CatalogoCabeceraId == catalogoCabeceraId && x.CodigoEsigex == codigoEsigex && !x.IsDeleted);
    }

    public async Task<Domain.Entities.Catalogo> GetByCodigoOtroAsync(string codigoCatalogo, string codigo)
    {
      var query = from catCab in _context.CatalogoCabeceras
                  join catDet in _context.Catalogos on catCab.Id equals catDet.CatalogoCabeceraId
                  where catCab.Codigo == codigoCatalogo && catDet.CodigoOtro == codigo
                  select catDet;

      return await query.FirstOrDefaultAsync().ConfigureAwait(false);
      //return await _context.Catalogos.FirstOrDefaultAsync(x => x.CatalogoCabeceraId == catalogoCabeceraId && x.CodigoOtro == codigoOtro && !x.IsDeleted);
    }

    public async Task<Domain.Entities.Catalogo> GetByCompletoAsync()
    {
      var query = from catCab in _context.CatalogoCabeceras
                  join catDet in _context.Catalogos on catCab.Id equals catDet.CatalogoCabeceraId
                  select catDet;

      return await query.FirstOrDefaultAsync().ConfigureAwait(false);
    }
    #endregion
  }







  public class CatalogoCabeceraRepository : Repository<Domain.Entities.CatalogoCabecera>, ICatalogoCabeceraRepository
  {
    #region Constructors

    public CatalogoCabeceraRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    #endregion Constructors

    #region Metodos Others 

    #endregion
  }
}