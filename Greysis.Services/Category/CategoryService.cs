using Autofac.Extras.DynamicProxy;
using Greysis.Domain.Entities;
using Greysis.Infrastructure.Repositories;
using System.Collections.Generic;

namespace Greysis.Services
{
    [Intercept(typeof(CategoryInterceptor))]
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryService)
        {
            _categoryRepository = categoryService;
        }
        public List<Category> GetAll()
        {
            return _categoryRepository.GetList();
        }
        public List<Category> GetAll(int a)
        {
            return _categoryRepository.GetList();
        }

        public Category Add(Category category)
        {

            return _categoryRepository.Add(category);
        }
    }
}
