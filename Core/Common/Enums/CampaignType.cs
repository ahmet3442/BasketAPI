using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Enums
{
    public enum CampaignType
    {
        [Description("DiscountRate")]
        DiscountRate = 0,
        [Description("DiscountAmount")]
        DiscountAmount = 1
    }
}
