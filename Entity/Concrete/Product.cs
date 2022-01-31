using Entity.Definitions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(500)]
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public int Stock { get; set; }
    }
}
