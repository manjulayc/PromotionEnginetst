using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class DDiscountPack:IDiscountPack
    {
        public int Price { get; set; }
        public int ProductsCount { get; set; }
        public int GetPrice() => Price * ProductsCount;

    }
}
