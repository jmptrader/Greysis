using System;
using NHibernate;

namespace Greysis.Core.Repositories.NHibernate
{
    public abstract class NhHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        protected abstract ISessionFactory InitializeFactory();

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
    }
}