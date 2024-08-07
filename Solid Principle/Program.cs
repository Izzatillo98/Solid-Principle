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
                TotalPrice = 50,
                TotalWeight = 5
            };

            IShipping shippingService = new GroundService();
            int cost = shippingService.GetCost(order);

            Console.WriteLine($"The shipping cost is: {cost}");
        }
    }
}
