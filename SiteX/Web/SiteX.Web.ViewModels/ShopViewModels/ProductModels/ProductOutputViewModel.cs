﻿namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    using System;

    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Mapping;

    public class ProductOutputViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Gender { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Location> Locations { get; set; }

        public ICollection<Size> Sizes { get; set; }

        public ICollection<Color> Colors { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, ProductOutputViewModel>()
                .ForMember(x => x.Categories, opt =>
                {
                    opt.MapFrom(x => x.ProductCategories.Select(x => x.Category).ToList());

                });

            configuration.CreateMap<Product, ProductOutputViewModel>()
            .ForMember(x => x.Locations, opt =>
            {
                opt.MapFrom(x => x.ProductLocations.Select(x => x.Location).ToList());

            });

            configuration.CreateMap<Product, ProductOutputViewModel>()
                 .ForMember(x => x.Sizes, opt =>
                 {
                     opt.MapFrom(x => x.ProductSizes.Select(x => x.Size).ToList());

                 });

            configuration.CreateMap<Product, ProductOutputViewModel>()
                 .ForMember(x => x.Colors, opt =>
                 {
                     opt.MapFrom(x => x.ProductColors.Select(x => x.Color).ToList());

                 });

            configuration.CreateMap<Product, ProductOutputViewModel>()
               .ForMember(x => x.ImageUrl, opt =>
               {
                   opt.MapFrom(x => x.ProductImages.OrderBy(x => x.Id).Select(x => x.Path).FirstOrDefault());

               });
        }
    }
}
