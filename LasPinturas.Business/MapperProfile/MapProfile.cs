using AutoMapper;
using LasPinturas.Dtos.Requests;
using LasPinturas.Dtos.Responses;
using LasPinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasPinturas.Business.MapperProfile
{
   public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductListResponse>();
            CreateMap<AddProductRequest, Product>();
            CreateMap<UpdateProductRequest, Product>();
        }
    }
}
