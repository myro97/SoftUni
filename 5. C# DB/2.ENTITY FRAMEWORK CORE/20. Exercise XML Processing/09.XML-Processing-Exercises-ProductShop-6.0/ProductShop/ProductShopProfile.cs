﻿using AutoMapper;
using ProductShop.DTOs.Import;
using ProductShop.Models;

namespace ProductShop;

public class ProductShopProfile : Profile
{
    public ProductShopProfile()
    {
        // User
        CreateMap<ImportUserDto, User>();

        // Product
        CreateMap<ImportProductDto, Product>();

        // Categories
        CreateMap<ImportCategoryDto, Category>();
    }
}