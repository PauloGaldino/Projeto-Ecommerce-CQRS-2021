using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.AutoMappers
{
    public class AutoMappserConfig
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(cfg =>
           {
               cfg.AddProfile(new DomainToViewModelMappingProfile());
               cfg.AddProfile(new ViewModelToDomainMappingProfile());

           });
        }
    }
}
 