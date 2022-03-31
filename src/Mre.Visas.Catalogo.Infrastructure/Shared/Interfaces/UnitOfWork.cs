using Mre.Visas.Catalogo.Application.Shared.Interfaces;
using Mre.Visas.Catalogo.Application.Catalogo.Repositories;
using Mre.Visas.Catalogo.Infrastructure.Persistence.Contexts;
using System;
using System.Threading.Tasks;

namespace Mre.Visas.Catalogo.Infrastructure.Shared.Interfaces
{
  public class UnitOfWork : IUnitOfWork
  {
    #region Constructors

    public UnitOfWork(
        ApplicationDbContext context,
        ICatalogoRepository catalogoRepository,
        ICatalogoCabeceraRepository catalogoCabeceraRepository)

    {
      _context = context;
      CatalogoRepository = catalogoRepository;
      CatalogoCabeceraRepository = catalogoCabeceraRepository;
    }

    #endregion Constructors

    #region Attributes

    protected readonly ApplicationDbContext _context;

    #endregion Attributes

    #region Properties

    public ICatalogoRepository CatalogoRepository { get; }

    public ICatalogoCabeceraRepository CatalogoCabeceraRepository { get; }

    #endregion Properties

    #region Methods

    public async Task<(bool, string)> SaveChangesAsync()
    {
      try
      {
        await _context.SaveChangesAsync().ConfigureAwait(false);

        return (true, null);
      }
      catch (Exception ex)
      {
        return (false, ex.InnerException is null ? ex.Message : ex.InnerException.Message);
      }
    }

    #endregion Methods
  }
}