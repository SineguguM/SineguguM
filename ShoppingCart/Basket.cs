using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Basket
    {
        public string BasketName { get; set; }

        public List<Tshirts> Tshirt { get; set; }
        public List<Golfer> Golfer { get; set; }
        public List<Jeans> Jean { get; set; }

        public List<FormalPants> FormalPant { get; set; }

        public double TotalCost(double total)
        {
            double totalCost = total;
            return totalCost;
        }
        public Basket()
        {
            Tshirt = new List<Tshirts>();
            Golfer = new List<Golfer>();
            Jean = new List<Jeans>();
            FormalPant = new List<FormalPants>();
        }

    }
}
