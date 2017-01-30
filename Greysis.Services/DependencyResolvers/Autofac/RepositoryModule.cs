using Autofac;
using Greysis.Infrastructure.Repositories;
using Greysis.Infrastructure.Repositories.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Services.DependencyResolvers.Autofac
{
    public class RepositoryModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();
        }
    }
}
