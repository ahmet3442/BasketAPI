using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Enums
{
    public enum OrderStatus
    {
        [Description("Pre")]
        Pre = 1,
        [Description("Success")]
        Success = 2,
        [Description("Fail")]
        Fail = 3,
        [Description("PaymentWaiting")]
        PaymentWaiting = 4,
    }
}
