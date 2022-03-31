using Mre.Visas.Catalogo.Application.Shared.Interfaces;

namespace Mre.Visas.Catalogo.Application.Shared.Handlers
{
    public abstract class BaseHandler
    {
        protected BaseHandler()
        {
        }

        protected BaseHandler(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        protected IUnitOfWork UnitOfWork;
    }
}