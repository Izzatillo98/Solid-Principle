using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.Services
{
    internal class AirService : IShipping
    {
        public int GetCost(Order order)
        {
            return Math.Max(20, getTotalWeight() * 3);
        }

        private int getTotalWeight()
        {
            throw new NotImplementedException();
        }

        public int GetData(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
