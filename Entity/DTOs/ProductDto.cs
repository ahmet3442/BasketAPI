﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class BasketItemDto : UpdateBasketDto
    {
        public double Amount { get; set; }
        public double CampaingAmount { get; set; }
    }
}
