using Autofac;
using Greysis.Core.Repositories.Dapper;
using Greysis.Infrastructure.Repositories.Dapper.Helper;
using Greysis.Infrastructure.Repositories.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Services.DependencyResolvers.Autofac
{
    public class EntityModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<DemoContext>().SingleInstance();
            builder.RegisterType<SqlDapperHelper>().As<DapperHelper>().SingleInstance();
        }
    }
}
