using Greysis.Domain.Entities;
using System.Data.Entity;

namespace Greysis.Infrastructure.Repositories.EntityFramework.Context
{
    public class DemoContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

    }
}
