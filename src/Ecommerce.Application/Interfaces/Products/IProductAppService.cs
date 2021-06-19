using Ecommerce.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interfaces.Products
{
    public interface IProductAppService : IDisposable
    {
        void Register(ProductViewModel productViewModel);
        IEnumerable<ProductViewModel> GetAll();
        ProductViewModel GetById(Guid id);
        void Update(ProductViewModel productViewModel);
        void Remove(Guid id);
        IList<ProductHistoryData> GetAllHistory(Guid id);
    }
}
