﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Linq;
using Greysis.Core.Repositories;
using Greysis.Core.Repositories.NHibernate;

namespace Greysis.Core.Repositories.NHibernate
{
    public abstract class NhRepositoryBaseGeneric<TEntity, THelper> : IRepository<TEntity>
        where TEntity : class,IEntity, new()
        where THelper : NhHelper, new()
    {
        private readonly NhHelper _nHibernateHelper;

        protected NhRepositoryBaseGeneric()
        {
            _nHibernateHelper = new THelper();
        }

        protected virtual TEntity UpdateContext(TEntity entity, ISession session)
        {
            using (var trans = session.BeginTransaction())
            {
                session.Update(entity);
                trans.Commit();
                return entity;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return UpdateContext(entity, session);
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    session.Delete(entity);
                    trans.Commit();
                }
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return filter == null
                    ? session.Query<TEntity>().ToList()
                    : session.Query<TEntity>().Where(filter).ToList();
            }
        }
    }
}
