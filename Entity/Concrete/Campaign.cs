using Core.Common.Enums;
using Entity.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Campaign :IEntity
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public CampaignType CampaignType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public double Discount { get; set; }
    }
}
