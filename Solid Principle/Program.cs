using Solid_Principle.Services;
using System;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                TotalPrice = 500,
                TotalWeight = 50
            };

            IShipping shippingService = new SeaService();
            int cost = shippingService.GetCost(order);

            Console.WriteLine($"The shipping cost is: {cost}");
        }
    }
}
