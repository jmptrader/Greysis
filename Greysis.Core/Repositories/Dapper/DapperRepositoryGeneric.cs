using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Core.Repositories.Dapper
{
    public abstract class DapperRepositoryBaseGeneric<TEntity, THelper> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where THelper : DapperHelper, new()
    {
        private readonly DapperHelper _dapperHelper;
        protected DapperRepositoryBaseGeneric()
        {
            _dapperHelper = new THelper();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public TEntity Add(TEntity entity)
        {
            _dapperHelper.Connection.Insert(entity);
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            _dapperHelper.Connection.Update(entity);
            return entity;
        }
        public void Delete(TEntity entity)
        {
            _dapperHelper.Connection.Delete(entity);
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            return _dapperHelper.Connection.GetList<TEntity>().ToList();
        }
    }
}
