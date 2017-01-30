using Greysis.Core.Repositories.Dapper;
using Greysis.Core.Repositories.NHibernate;
using Greysis.Domain.Entities;

namespace Greysis.Infrastructure.Repositories.Dapper
{
    public class CategoryRepository : DapperRepositoryBase<Category>, ICategoryRepository
    {
        private readonly DapperHelper _helper;

        public CategoryRepository(DapperHelper helper) : base(helper)
        {
            _helper = helper;
        }
    }
}
