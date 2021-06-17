using Ecommerce.Domain.Models.ProdutctEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infra.Data.Mappings.Products
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.ToTable("Produto");

            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Name)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Value)
                .HasColumnName("Valor")
                .HasColumnType("DECIMAL(18,2)")
                .IsRequired();

            builder.Property(p => p.State)
                .HasColumnName("Estado");
        }
    }
}
