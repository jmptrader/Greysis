using FluentNHibernate.Mapping;
using Greysis.Domain.Entities;

namespace Greysis.Infrastructure.Repositories.NHibernate.Mapping
{
    public partial class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
              Table(@"Categories");

              LazyLoad();

              Id(x => x.ID)
                .Column("CategoryID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("int")
                .Not.Nullable()
                .Precision(10)                
                .GeneratedBy.Identity();

              Map(x => x.CategoryName)    
                .Column("CategoryName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(15);

              //HasMany(x => x.Products)
              //  .Access.Property()
              //  .AsSet()
              //  .Cascade.None()
              //  .LazyLoad()
              //  // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
              //  .Inverse()
              //  .Generic()
              //  .KeyColumns.Add("CategoryID", mapping => mapping.Name("CategoryID")
              //                                                       .SqlType("int")
              //                                                       .Nullable());
        }
    }
}
