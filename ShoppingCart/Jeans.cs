using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Jeans : Pants
    {
        public override double SizeValue(int ProductSize)
        {
            return base.SizeValue(ProductSize);
        }
    }
}
