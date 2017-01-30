using Greysis.Core.Domains;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Greysis.Domain.Entities
{
    [Table("Category")]
    public class Category:Entity<int>
    {
        public string CategoryName { get; set; }
        public List<Blog> Posts { get; set; }
    }
}
