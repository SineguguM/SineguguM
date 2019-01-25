using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public virtual double PricePerProduct(double PricePerSize)
        {
            return PricePerSize;
        }
        public abstract double SizeValue(int ProductSize);

    }
}
