using Greysis.Core.Repositories.NHibernate;
using Greysis.Domain.Entities;

namespace Greysis.Infrastructure.Repositories.NHibernate
{
    public class CategoryRepository : NhRepositoryBase<Category>, ICategoryRepository
    {
        private readonly NhHelper _helper;

        public CategoryRepository(NhHelper helper) : base(helper)
        {
            _helper = helper;
        }
    }
}
