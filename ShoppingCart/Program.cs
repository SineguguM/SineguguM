using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            double TotalPerItem = 0;

            List<Basket> baskets = new List<Basket>();

            Basket basket = new Basket()
            {
                BasketName = "Basket 1"
            };


            Tshirts tShirt = new Tshirts()
            {
                Name = "T-Shirt",
                Size = 1

            };

            TotalPerItem = TotalPerItem + tShirt.SizeValue(tShirt.Size);

            basket.Tshirt.Add(tShirt);


            Golfer golf = new Golfer()
            {
                Name = "Golfer",
                Size = 2
            };
            TotalPerItem = TotalPerItem + golf.SizeValue(golf.Size);

            basket.Golfer.Add(golf);


            FormalPants formal = new FormalPants()
            {
                Name = "FormalPant",
                Size = 3
            };

            TotalPerItem = TotalPerItem + formal.SizeValue(formal.Size);
            basket.FormalPant.Add(formal);

            Jeans jean = new Jeans()
            {
                Name = "Jean",
                Size = 3
            };

            TotalPerItem = TotalPerItem + jean.SizeValue(jean.Size);

            basket.Jean.Add(jean);

            baskets.Add(basket);

            Console.WriteLine($"Total Cost R{basket.TotalCost(TotalPerItem)}");
            Console.ReadLine();

        }
    }
}