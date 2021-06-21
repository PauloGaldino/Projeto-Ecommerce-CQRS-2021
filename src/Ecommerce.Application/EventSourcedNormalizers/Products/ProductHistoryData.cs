using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.EventSourcedNormalizers.Products
{
    public class ProductHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool State { get; set; }
        public string When { get; set; }
        public string Who { get; set; }
    }
}
