﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFurnitureDeals2._0.BusinessLogic.Factory
{
    class FivePercentDiscount : DealService
    {
        public override float ComputeDeal(float price)
        {
            float newPrice = 0.95f * price;
            return newPrice;
        }
    }
}