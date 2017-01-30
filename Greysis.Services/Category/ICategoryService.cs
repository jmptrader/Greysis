using Greysis.Domain.Entities;
using System.Collections.Generic;

namespace Greysis.Services
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Add(Category category);
    }
    
    
}
