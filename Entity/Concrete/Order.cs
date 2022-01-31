using Core.Common.Enums;
using Entity.Definitions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order :IEntity
    {
        public Order()
        {
            CreatedDate = DateTime.Now;
            Id = Guid.NewGuid();
            OrderStatus = OrderStatus.Pre;
        }
        [Key]
        public Guid Id { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalPrice { get; set; }
        public double TotalCampaignPrice { get; set; }
        public Guid CreateUser { get; set; }
    }
}
