using Ecommerce.Domain.Core.Models;
using System;

namespace Ecommerce.Domain.Models.ProdutctEntity
{
    public class Product : Entity
    {
        public Product(Guid id, string name, decimal value, bool state)
        {
            Id = id;
            Name = name;
            Value = value;
            State = state;
        }

        //EF contrutor vazio
        protected Product() { }

        public string Name { get; private set; }

        public decimal Value { get; private set; }

        public bool State { get; private set; }


    }
}
