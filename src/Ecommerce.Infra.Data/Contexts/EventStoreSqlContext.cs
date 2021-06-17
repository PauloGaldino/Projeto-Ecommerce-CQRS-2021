using Ecommerce.Domain.Core.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace Ecommerce.Infra.Data.Contexts
{
    public class EventStoreSqlContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public EventStoreSqlContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public DbSet<StoredEvent> StoredEvent { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcommerceDbContext).Assembly);
            ForgotPropertiesMapper(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        //Método para preencher propriedades esqucidan no Mapping das Entidades
        private void ForgotPropertiesMapper(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(string));
                foreach (var property in properties)
                {
                    if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue)
                    {
                        // property.SetMaxLength(100);
                        property.SetColumnType("VARCHAR(100)");
                    }
                }
            }
        }
    }
}
