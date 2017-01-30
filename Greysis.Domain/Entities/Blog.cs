using Greysis.Core.Domains;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Greysis.Domain.Entities
{
    [Table("Blog")]
    public class Blog : Entity<int>
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string FullContent { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual Category Categories { get; set; }
    }
}
