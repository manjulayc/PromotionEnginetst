using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class ADiscountPack:IDiscountPack
    {
        public int ProductsCount { get; set; }
        public int GetPrice() 
        {
            int totalprice;
            totalprice  = 130 * (ProductsCount / 3) + 50 * (ProductsCount % 3);
            return totalprice;
         }
    }
}
