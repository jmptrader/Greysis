using Greysis.Core.Repositories.EntityFramework;
using Greysis.Domain.Entities;
using Greysis.Infrastructure.Repositories.EntityFramework.Context;

namespace Greysis.Infrastructure.Repositories.EntityFramework
{
    public class CategoryRepository : EfRepositoryBase<Category, DemoContext>, ICategoryRepository
    {

    }
}
