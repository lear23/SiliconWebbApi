﻿





using Infrastructure.Entities;
using SiliconWebbApi.Model;

namespace SiliconWebbApi.Factories;

public class CategoryFactory
{

    public static CategoryModel Create(CategoryEntity entity)
    {
        try
        {
            return new CategoryModel
            {
                Id = entity.Id,
                CategoryName = entity.CategoryName
            };
        }catch { }
        return null!;
    }

    public static IEnumerable<CategoryModel> Create(List<CategoryEntity> entities)
    {
        List<CategoryModel> categories = [];

        try
        {
            foreach (var entity in entities)
            {
                categories.Add(Create(entity));
            }
        }
        catch { }
        return categories;
    }

}
