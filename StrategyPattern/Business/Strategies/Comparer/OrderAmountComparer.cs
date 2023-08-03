using Strategy_Pattern_First_Look.Business.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Strategy_Pattern_First_Look.Business.Strategies.Comparer
{
    public class OrderAmountComparer : IComparer<Order>
    {
        public int Compare([AllowNull] Order x, [AllowNull] Order y)
        {
            var xTotal = x.TotalPrice;
            var yTotal = y.TotalPrice;

            if (xTotal == yTotal)
            {
                return 0;
            }
            else if (xTotal > yTotal)
            {
                return 1;
            }

            return -1;
        }
    }
}
