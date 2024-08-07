using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.Services
{
    internal class SeaService : IShipping
    {
        public int GetCost(Order order)
        {
            if (order.TotalPrice > 1000)
            {
                return 0;
            }
            return (int)Math.Max(10, order.TotalWeight * 0.5);
        }

        public int GetData(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
