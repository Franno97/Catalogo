using FluentValidation;
using MediatR;
using Mre.Visas.Catalogo.Application.Wrappers;
using Mre.Visas.Catalogo.Application.Catalogo.Requests;
using Mre.Visas.Catalogo.Application.Shared.Handlers;
using Mre.Visas.Catalogo.Application.Shared.Interfaces;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Mre.Visas.Catalogo.Application.Catalogo.Queries
{
  public class ConsultarCatalogoPorCatalogoCabeceraCodigoQuery : ConsultarPorCatalogoCabeceraRequest, IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoPorCatalogoCabeceraCodigoQuery(ConsultarPorCatalogoCabeceraRequest request)
    {
      CodigoCatalogo = request.CodigoCatalogo;
    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoPorCatalogoCabeceraCodigoHandler : BaseHandler, IRequestHandler<ConsultarCatalogoPorCatalogoCabeceraCodigoQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoPorCatalogoCabeceraCodigoHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoPorCatalogoCabeceraCodigoQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoRepository.GetByCatalogoCabeceraCodigoAsync(query.CodigoCatalogo);

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }

      }

      #endregion Methods
    }

    #endregion Handlers
  }

  public class ConsultarCatalogoPorCodigoQuery : ConsultarCatalogoPorCodigoRequest, IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoPorCodigoQuery(ConsultarCatalogoPorCodigoRequest request)
    {
      CodigoCatalogo = request.CodigoCatalogo;
      Codigo = request.Codigo;
    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoPorCodigoHandler : BaseHandler, IRequestHandler<ConsultarCatalogoPorCodigoQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoPorCodigoHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoPorCodigoQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoRepository.GetByCodigoAsync(query.CodigoCatalogo, query.Codigo);

          if (datos == null)
            throw new System.Exception("Error, No existen datos para los parámetros proporcionados.");

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }

      }

      #endregion Methods
    }

    #endregion Handlers
  }


  public class ConsultarCatalogoPorCodigoMdgQuery : ConsultarCatalogoPorCodigoRequest, IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoPorCodigoMdgQuery(ConsultarCatalogoPorCodigoRequest request)
    {
      CodigoCatalogo = request.CodigoCatalogo;
      Codigo = request.Codigo;
    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoPorCodigoMdgHandler : BaseHandler, IRequestHandler<ConsultarCatalogoPorCodigoMdgQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoPorCodigoMdgHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoPorCodigoMdgQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoRepository.GetByCodigoMdgAsync(query.CodigoCatalogo, query.Codigo);

          if (datos == null)
            throw new System.Exception("Error, No existen datos para los parámetros proporcionados.");

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }


      }

      #endregion Methods
    }

    #endregion Handlers
  }


  public class ConsultarCatalogoPorCodigoEsigexQuery : ConsultarCatalogoPorCodigoRequest, IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoPorCodigoEsigexQuery(ConsultarCatalogoPorCodigoRequest request)
    {
      CodigoCatalogo = request.CodigoCatalogo;
      Codigo = request.Codigo;
    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoPorCodigoEsigexHandler : BaseHandler, IRequestHandler<ConsultarCatalogoPorCodigoEsigexQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoPorCodigoEsigexHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoPorCodigoEsigexQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoRepository.GetByCodigoEsigexAsync(query.CodigoCatalogo, query.Codigo);
          if (datos == null)
            throw new System.Exception("Error, No existen datos para los parámetros proporcionados.");

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }


      }

      #endregion Methods
    }

    #endregion Handlers
  }

  public class ConsultarCatalogoPorCodigoOtroQuery : ConsultarCatalogoPorCodigoRequest, IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoPorCodigoOtroQuery(ConsultarCatalogoPorCodigoRequest request)
    {
      CodigoCatalogo = request.CodigoCatalogo;
      Codigo = request.Codigo;
    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoPorCodigoOtroHandler : BaseHandler, IRequestHandler<ConsultarCatalogoPorCodigoOtroQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoPorCodigoOtroHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoPorCodigoOtroQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoRepository.GetByCodigoOtroAsync(query.CodigoCatalogo, query.Codigo);
          if (datos == null)
            throw new System.Exception("Error, No existen datos para los parámetros proporcionados.");

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }


      }

      #endregion Methods
    }

    #endregion Handlers
  }

  public class ConsultarCatalogoCabeceraQuery : IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoCabeceraQuery()
    {
      
    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoCabeceraHandler : BaseHandler, IRequestHandler<ConsultarCatalogoCabeceraQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoCabeceraHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoCabeceraQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoCabeceraRepository.GetAllAsync();
          if (datos == null)
            throw new System.Exception("Error, No existen datos para los parámetros proporcionados.");

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }
      }

      #endregion Methods
    }

    #endregion Handlers
  }

  public class ConsultarCatalogoDetalleQuery : IRequest<ApiResponseWrapper>
  {
    #region Constructors

    public ConsultarCatalogoDetalleQuery()
    {

    }

    #endregion Constructors

    #region Handlers

    public class ConsultarCatalogoDetalleHandler : BaseHandler, IRequestHandler<ConsultarCatalogoDetalleQuery, ApiResponseWrapper>
    {
      #region Constructors

      public ConsultarCatalogoDetalleHandler(IUnitOfWork unitOfWork)
          : base(unitOfWork)
      {
      }

      #endregion Constructors

      #region Methods

      public async Task<ApiResponseWrapper> Handle(ConsultarCatalogoDetalleQuery query, CancellationToken cancellationToken)
      {
        try
        {
          var datos = await UnitOfWork.CatalogoRepository.GetAllAsync();
          if (datos == null)
            throw new System.Exception("Error, No existen datos para los parámetros proporcionados.");

          var response = new ApiResponseWrapper(HttpStatusCode.OK, datos);

          return response;
        }
        catch (System.Exception ex)
        {
          return new ApiResponseWrapper(HttpStatusCode.BadRequest, ex.Message == null ? ex.InnerException : ex.Message);

        }
      }

      #endregion Methods
    }

    #endregion Handlers
  }

  public class ConsultarCatalogoPorCatalogoCabeceraCodigoQueryValidator : AbstractValidator<ConsultarCatalogoPorCatalogoCabeceraCodigoQuery>
  {
    public ConsultarCatalogoPorCatalogoCabeceraCodigoQueryValidator()
    {
      //RuleFor(e => e.ProjectId).Must(e => e.Length.Equals(38)).When(e => !string.IsNullOrEmpty(e.ProjectId)).WithMessage("{PropertyName} must be exactly 38 characters.");
    }
  }

  public class ConsultarCatalogoPorCodigoQueryValidator : AbstractValidator<ConsultarCatalogoPorCodigoQuery>
  {
    public ConsultarCatalogoPorCodigoQueryValidator()
    {
      //RuleFor(e => e.ProjectId).Must(e => e.Length.Equals(38)).When(e => !string.IsNullOrEmpty(e.ProjectId)).WithMessage("{PropertyName} must be exactly 38 characters.");
    }
  }

  public class ConsultarCatalogoPorCodigoMdgQueryValidator : AbstractValidator<ConsultarCatalogoPorCodigoMdgQuery>
  {
    public ConsultarCatalogoPorCodigoMdgQueryValidator()
    {
      //RuleFor(e => e.ProjectId).Must(e => e.Length.Equals(38)).When(e => !string.IsNullOrEmpty(e.ProjectId)).WithMessage("{PropertyName} must be exactly 38 characters.");
    }
  }

  public class ConsultarCatalogoPorCodigoEsigexQueryValidator : AbstractValidator<ConsultarCatalogoPorCodigoEsigexQuery>
  {
    public ConsultarCatalogoPorCodigoEsigexQueryValidator()
    {
      //RuleFor(e => e.ProjectId).Must(e => e.Length.Equals(38)).When(e => !string.IsNullOrEmpty(e.ProjectId)).WithMessage("{PropertyName} must be exactly 38 characters.");
    }
  }

  public class ConsultarCatalogoPorCodigoOtroQueryValidator : AbstractValidator<ConsultarCatalogoPorCodigoOtroQuery>
  {
    public ConsultarCatalogoPorCodigoOtroQueryValidator()
    {
      //RuleFor(e => e.ProjectId).Must(e => e.Length.Equals(38)).When(e => !string.IsNullOrEmpty(e.ProjectId)).WithMessage("{PropertyName} must be exactly 38 characters.");
    }
  }


}