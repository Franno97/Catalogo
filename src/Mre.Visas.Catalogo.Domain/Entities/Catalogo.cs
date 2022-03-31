using System;

namespace Mre.Visas.Catalogo.Domain.Entities
{
  public class Catalogo : AuditableEntity
  {
    public Guid CatalogoCabeceraId { get; set; }
    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public string Descripcion2 { get; set; }

    public string CodigoEsigex { get; set; }

    public string CodigoMdg { get; set; }

    public string CodigoOtro { get; set; }
  }

  public class CatalogoCabecera : AuditableEntity
  {
    public string Codigo { get; set; }

    public string Descripcion { get; set; }
  }
}