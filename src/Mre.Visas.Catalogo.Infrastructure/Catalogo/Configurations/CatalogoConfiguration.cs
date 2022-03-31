using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mre.Visas.Catalogo.Infrastructure.Catalogo.Configurations
{
  public class CatalogoConfiguration : IEntityTypeConfiguration<Domain.Entities.Catalogo>
  {

    public void Configure(EntityTypeBuilder<Domain.Entities.Catalogo> builder)
    {
      builder.ToTable("Catalogo");

      builder.HasKey(e => e.Id);
      builder.Property(e => e.CatalogoCabeceraId).IsRequired(true);
      builder.Property(e => e.Codigo).IsRequired(true).HasMaxLength(50);
      builder.Property(e => e.Descripcion).IsRequired(true).HasMaxLength(250);
      builder.Property(e => e.Descripcion2).IsRequired(true).HasMaxLength(250);
      builder.Property(e => e.CodigoEsigex).IsRequired(true).HasMaxLength(50);
      builder.Property(e => e.CodigoMdg).IsRequired(true).HasMaxLength(50);
      builder.Property(e => e.CodigoOtro).IsRequired(true).HasMaxLength(50);
      builder.Property(e => e.Created).IsRequired(true);
      builder.Property(e => e.CreatorId).IsRequired(true);
      builder.Property(e => e.LastModified).IsRequired(true);
      builder.Property(e => e.LastModifierId).IsRequired(true);
      builder.Property(e => e.IsDeleted).IsRequired(true);
    }
  }


  public class CatalogoCabeceraConfiguration : IEntityTypeConfiguration<Domain.Entities.CatalogoCabecera>
  {

    public void Configure(EntityTypeBuilder<Domain.Entities.CatalogoCabecera> builder)
    {
      builder.ToTable("CatalogoCabecera");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Codigo).IsRequired(true).HasMaxLength(50);
      builder.Property(e => e.Descripcion).IsRequired(true).HasMaxLength(250);
      builder.Property(e => e.Created).IsRequired(true);
      builder.Property(e => e.CreatorId).IsRequired(true);
      builder.Property(e => e.LastModified).IsRequired(true);
      builder.Property(e => e.LastModifierId).IsRequired(true);
      builder.Property(e => e.IsDeleted).IsRequired(true);
    }
  }

}


//add-migration AddCatalogos -s Mre.Visas.Catalogo.Infrastructure
//update-database -s Mre.Visas.Catalogo.Infrastructure

