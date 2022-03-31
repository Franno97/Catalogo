using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mre.Visas.Catalogo.Application.Catalogo.Requests
{
  public class ConsultarPorCatalogoCabeceraRequest
  {
    /// <summary>
    /// Código del tipo de catálogo a consultar
    /// </summary>
    public string CodigoCatalogo { get; set; }
  }

  public class ConsultarCatalogoPorCodigoRequest
  {
    /// <summary>
    /// Código del tipo de catálogo a consultar
    /// </summary>
    public string CodigoCatalogo{ get; set; }

    /// <summary>
    /// Código a consultar
    /// </summary>
    public string Codigo { get; set; }
  }
}
