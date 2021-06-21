using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ecommerce.Application.EventSourcedNormalizers.Products;
using Ecommerce.Application.Interfaces.Products;
using Ecommerce.Application.ViewModels.Products;
using Ecommerce.Domain.Commands.Products;
using Ecommerce.Domain.Core.Bus.Interfaces;
using Ecommerce.Domain.Interfaces.Products;
using Ecommerce.Infra.Data.Repositories.EventSourcing.Iterfaces;
using System;
using System.Collections.Generic;

namespace Ecommerce.Application.Services.Products
{
    public class ProductAppService : IProductAppService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IEventStoreRepository _eventStoryRepository;
        private readonly IMediatorHandler Bus;

        public ProductAppService(IMapper mappe,
                     IProductRepository productRepository,
                     IEventStoreRepository eventStoryRepository,
                     IMediatorHandler bus
            )
        {
            _mapper = mappe;
            _productRepository = productRepository;
            _eventStoryRepository = eventStoryRepository;
            Bus = bus;
        }


        public void Register(ProductViewModel productViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewProductCommand>(productViewModel);
            Bus.SendCommand(registerCommand);
        }

        public void Remove(Guid id)
        {
            var removeCommand = new RemoveProductCommand(id);
            Bus.SendCommand(removeCommand);
        }

        public void Update(ProductViewModel productViewModel)
        {
            var updateCommand = _mapper.Map<UpdateProductCommand>(productViewModel);
            Bus.SendCommand(updateCommand);
        }


        public IEnumerable<ProductViewModel> GetAll()
        {
            return _productRepository.GetAll().ProjectTo<ProductViewModel>(_mapper.ConfigurationProvider);
        }

        public IList<ProductHistoryData> GetAllHistory(Guid id)
        {
           
            return ProductHistory.ToJavascriptProductHistory(_eventStoryRepository.All(id));
        }                           

        public ProductViewModel GetById(Guid id)
        {
            return _mapper.Map<ProductViewModel>(_productRepository.GetById(id));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
