using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFurnitureDeals2._0.BusinessLogic.Factory
{
    static class DealServiceFactory
    {
        public static DealService GetDeal(int dealID)
        {
            switch (dealID)
            {
                case 5:
                    return new FivePercentDiscount();
                case 10:
                    return new TenPercentDiscount();
                case 15:
                    return new FifteenPercentDiscount();
                default:
                    return null;
            }
        }
    }
}
