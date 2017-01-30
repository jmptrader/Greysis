using Autofac;
using FluentValidation;
using Greysis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Services.DependencyResolvers.Autofac
{
    public class ValidationModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryValidator>().As<IValidator<Category>>().SingleInstance();
        }
    }
}
