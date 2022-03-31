using Microsoft.AspNetCore.Mvc;
using Mre.Visas.Catalogo.Api.Controllers;
//using Mre.Visas.Catalogo.Application.Catalogo.Commands;
using Mre.Visas.Catalogo.Application.Catalogo.Queries;
using Mre.Visas.Catalogo.Application.Catalogo.Requests;
using System.Threading.Tasks;
using System;

namespace Mre.Visas.Catalogo.Api.Controllers
{
  public class CatalogoController : BaseController
  {
    // GET: api/Catalogo/ConsultarCatalogoPorCatalogoCabeceraCodigo
    [HttpGet("ConsultarCatalogoPorCatalogoCabeceraCodigo")]
    [ActionName(nameof(ConsultarCatalogoPorCatalogoCabeceraCatalogoAsync))]
    public async Task<IActionResult> ConsultarCatalogoPorCatalogoCabeceraCatalogoAsync(string codigoCatalogo)
    {
      ConsultarPorCatalogoCabeceraRequest request = new ConsultarPorCatalogoCabeceraRequest
      {
        CodigoCatalogo = codigoCatalogo
      };

      return Ok(await Mediator.Send(new ConsultarCatalogoPorCatalogoCabeceraCodigoQuery(request)).ConfigureAwait(false));
    }

    // GET: api/Catalogo/ConsultarCatalogoPorCodigo
    [HttpGet("ConsultarCatalogoPorCodigo")]
    [ActionName(nameof(ConsultarCatalogoPorCodigoAsync))]
    public async Task<IActionResult> ConsultarCatalogoPorCodigoAsync(string codigoCatalogo, string codigo)
    {
      ConsultarCatalogoPorCodigoRequest request = new ConsultarCatalogoPorCodigoRequest
      {
        CodigoCatalogo = codigoCatalogo,
        Codigo = codigo
      };

      return Ok(await Mediator.Send(new ConsultarCatalogoPorCodigoQuery(request)).ConfigureAwait(false));
    }


    // GET: api/Catalogo/ConsultarCatalogoPorCodigoMdg
    [HttpGet("ConsultarCatalogoPorCodigoMdg")]
    [ActionName(nameof(ConsultarCatalogoPorCodigoMdgAsync))]
    public async Task<IActionResult> ConsultarCatalogoPorCodigoMdgAsync(string codigoCatalogo, string CodigoMdg)
    {
      ConsultarCatalogoPorCodigoRequest request = new ConsultarCatalogoPorCodigoRequest
      {
        CodigoCatalogo = codigoCatalogo,
        Codigo = CodigoMdg
      };

      return Ok(await Mediator.Send(new ConsultarCatalogoPorCodigoMdgQuery(request)).ConfigureAwait(false));
    }

    // GET: api/Catalogo/ConsultarCatalogoPorCodigoEsigex
    [HttpGet("ConsultarCatalogoPorCodigoEsigex")]
    [ActionName(nameof(ConsultarCatalogoPorCodigoEsigexAsync))]
    public async Task<IActionResult> ConsultarCatalogoPorCodigoEsigexAsync(string codigoCatalogo, string CodigoEsigex)
    {
      ConsultarCatalogoPorCodigoRequest request = new ConsultarCatalogoPorCodigoRequest
      {
        CodigoCatalogo = codigoCatalogo,
        Codigo = CodigoEsigex
      };

      return Ok(await Mediator.Send(new ConsultarCatalogoPorCodigoEsigexQuery(request)).ConfigureAwait(false));
    }


    // GET: api/Catalogo/ConsultarCatalogoPorCodigoOtro
    [HttpGet("ConsultarCatalogoPorCodigoOtro")]
    [ActionName(nameof(ConsultarCatalogoPorCodigoOtroAsync))]
    public async Task<IActionResult> ConsultarCatalogoPorCodigoOtroAsync(string codigoCatalogo, string CodigoOtro)
    {
      ConsultarCatalogoPorCodigoRequest request = new ConsultarCatalogoPorCodigoRequest
      {
        CodigoCatalogo = codigoCatalogo,
        Codigo = CodigoOtro
      };

      return Ok(await Mediator.Send(new ConsultarCatalogoPorCodigoOtroQuery(request)).ConfigureAwait(false));
    }

    // GET: api/Catalogo/ConsultarCatalogoCabecera
    [HttpGet("ConsultarCatalogoCabecera")]
    [ActionName(nameof(ConsultarCatalogoCabeceraAsync))]
    public async Task<IActionResult> ConsultarCatalogoCabeceraAsync()
    {
      return Ok(await Mediator.Send(new ConsultarCatalogoCabeceraQuery()).ConfigureAwait(false));
    }

    // GET: api/Catalogo/ConsultarCatalogoDetalle
    [HttpGet("ConsultarCatalogoDetalle")]
    [ActionName(nameof(ConsultarCatalogoDetalleAsync))]
    public async Task<IActionResult> ConsultarCatalogoDetalleAsync()
    {
      return Ok(await Mediator.Send(new ConsultarCatalogoDetalleQuery()).ConfigureAwait(false));
    }
  }
}