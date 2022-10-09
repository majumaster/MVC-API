using AutoMapper;
using Example.Entities.Models;
using ExampleAPI.Models.InputModels.Products;
using ExampleAPI.Models.OutputModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAPI.App_Start
{
    public class AutoMapperBaseProfile : Profile
    {
        public AutoMapperBaseProfile()
        {
            CreateMap<ProductInputModel, Product>()
                .ForMember(x => x.Id, d => d.Ignore())
                .ForMember(x => x.Category, d => d.Ignore())
                .ForMember(x => x.Orders, d => d.Ignore());

            CreateMap<Product, ProductOutputModel>()
                .ForMember(x => x.CategoryName, d => d.MapFrom(s => s.Category.Name));
        }
    }
}