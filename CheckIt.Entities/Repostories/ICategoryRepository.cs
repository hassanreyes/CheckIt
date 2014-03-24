using System;
using System.Collections.Generic;

namespace CheckIt.Entities
{
    public interface ICategoryRepository
    {
        Category GetById(Guid id);

        Category GetByName(string name);

        IEnumerable<Category> GetCategories(Area area = null);

        bool SaveCategory(Category cat);

        bool DeleteCategory(Category cat);
    }
}
