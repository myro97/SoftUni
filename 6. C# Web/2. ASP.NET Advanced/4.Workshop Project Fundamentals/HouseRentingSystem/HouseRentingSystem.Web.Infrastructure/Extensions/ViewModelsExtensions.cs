﻿using HouseRentingSystem.Web.ViewModels.Category.Interfaces;

namespace HouseRentingSystem.Web.Infrastructure.Extensions;

public static class ViewModelsExtensions
{
    public static string GetUrlInformation(this ICategoryDetailsModel model)
        => model.Name.Replace(" ", "-");
    
}
