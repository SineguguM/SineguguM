using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class FormalPants : Pants
    {
        public override double SizeValue(int ProductSize)
        {
            double cost = 0;
            switch (ProductSize)
            {
                case 1:
                    cost = +PricePerProduct(40);
                    break;

                case 2:
                    cost = +PricePerProduct(50);
                    break;

                case 3:
                    cost = +PricePerProduct(60);
                    break;
            }
            return cost;
        }
    }
}
