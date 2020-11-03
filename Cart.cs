using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PromotionEngine
{
    public class Cart
    {
        List<IDiscountPack> packs = new List<IDiscountPack> { new ADiscountPack(), new BDiscountPack() , new CDiscountPack() , new DDiscountPack() };
        public int GetPrice()
        {
            if (packs[2] is CDiscountPack || packs[3] is IDiscountPack)
            {
                CDiscountPack cpack = packs[2] as CDiscountPack;
                DDiscountPack dpack = packs[3] as DDiscountPack;
                if ((cpack != null && dpack != null ) && ((cpack.ProductsCount > 0 && dpack.ProductsCount >0 )  && (cpack.ProductsCount% dpack.ProductsCount) == 0))
                {
                    cpack.Price = 15;
                    dpack.Price = 15;
                }
            }
            return packs.Sum(p => p.GetPrice());
        }
        public void AddProduct(Product p)
        {
            if (p.Id == "A")
            {
                ADiscountPack apack = packs[0] as ADiscountPack;
                if (apack != null)
                {
                    apack.ProductsCount++;
                }
            }

            else if (p.Id == "B")
            {
                BDiscountPack apack = packs[1] as BDiscountPack;
                if (apack != null)
                {
                    apack.ProductsCount++;
                }
            }
            else if (p.Id == "C")
            {
                CDiscountPack apack = packs[2] as CDiscountPack;
                if (apack != null)
                {
                    apack.ProductsCount++;
                }
            }
            else if (p.Id == "D")
            {
                DDiscountPack apack = packs[3] as DDiscountPack;
                if (apack != null)
                {
                    apack.ProductsCount++;
                }
            }

        }
    }

}
