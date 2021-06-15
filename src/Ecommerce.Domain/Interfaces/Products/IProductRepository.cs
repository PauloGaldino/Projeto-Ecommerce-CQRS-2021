using Ecommerce.Domain.Models.ProdutctEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces.Products
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
