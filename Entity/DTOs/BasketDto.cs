using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class BasketDto 
    {
        public BasketDto(Guid userid)
        {
            UserId = userid;
            BasketId = Guid.NewGuid();
            OrderItems = new List<BasketItemDto>();
        }
        public Guid BasketId { get; set; }
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public double TotalPrice { get; set; }
        public double TotalCampaignPrice { get; set; }
        public List<BasketItemDto> OrderItems { get; set; }
    }

}
