using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>{
            new Category {CategoryId = 1, CategoryName="Fruit pies", Description="All fruit pies in here"},
            new Category {CategoryId = 2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
            new Category {CategoryId = 3, CategoryName="Seasnal pies", Description="Get in the mood for seasonal pies"},
        };
    }
}