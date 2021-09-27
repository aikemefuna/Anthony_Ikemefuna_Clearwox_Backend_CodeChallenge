using AutoMapper;
using ClearwoxCodeChallenge.Application.Features.Products.Commands.CreateProduct;
using ClearwoxCodeChallenge.Application.Features.Products.Queries.GetAllProducts;
using ClearwoxCodeChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearwoxCodeChallenge.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
