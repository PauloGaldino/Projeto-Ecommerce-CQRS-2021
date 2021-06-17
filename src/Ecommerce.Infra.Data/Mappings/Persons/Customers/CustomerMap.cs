using Ecommerce.Domain.Models.Persons.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infra.Data.Mappings.Persons.Customers
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Cliente");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Name)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
