using AutoMapper;
using GreenWerx.NetCore.Models.Store;
using GreenWerx.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenWerx.WebApplication.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            // Source => Target
            CreateMap<Product, ProductViewModel>();
             

        }
    }
}
