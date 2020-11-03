using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class BDiscountPack:IDiscountPack
    {
        public int ProductsCount { get; set; }
        public int GetPrice()
        { 
            return 45 * (ProductsCount / 2) + 30 * (ProductsCount % 2);
        }
    }
}
