using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class UpdateBasketDto
    {
        public Guid BasketId { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public bool isAdd { get; set; }
    }
}
