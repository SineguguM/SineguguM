using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Shirt : Product
    {
        public override double SizeValue(int ShirtSize)
        {
            double cost = 0;

            switch (ShirtSize)
            {
                case 1:
                    cost = +PricePerProduct(10);
                    break;

                case 2:
                    cost = +PricePerProduct(20);
                    break;

                case 3:
                    cost = +PricePerProduct(30);
                    break;
            }
            return cost;
        }

    }
}
