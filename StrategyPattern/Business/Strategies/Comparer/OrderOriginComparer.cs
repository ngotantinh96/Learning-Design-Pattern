using Strategy_Pattern_First_Look.Business.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Strategy_Pattern_First_Look.Business.Strategies.Comparer
{
    public class OrderOriginComparer : IComparer<Order>
    {
        public int Compare([AllowNull] Order x, [AllowNull] Order y)
        {
            var xDest = x.ShippingDetails.OriginCountry.ToLowerInvariant();
            var yDest = y.ShippingDetails.OriginCountry.ToLowerInvariant();
            if (xDest == yDest)
            {
                return 0;
            }
            else if (xDest[0] > yDest[0])
            {
                return 1;
            }

            return -1;
        }
    }
}
