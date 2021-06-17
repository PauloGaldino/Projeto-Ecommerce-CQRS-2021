using Ecommerce.Domain.Interfaces.Products;
using Ecommerce.Domain.Models.ProdutctEntity;
using Ecommerce.Infra.Data.Contexts;

namespace Ecommerce.Infra.Data.Repositories.Rpoducts
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceDbContext context) : base(context) { }
    }
}
