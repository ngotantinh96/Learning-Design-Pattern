using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            #region Tax per item
            if (order.ShippingDetails.DestinationCountry.ToLowerInvariant() 
                == order.ShippingDetails.OriginCountry.ToLowerInvariant())
            {
                decimal totalTax = 0m;
                foreach (var item in order.LineItems)
                {
                    var itemPrice = item.Key.Price;
                    var itemValue = item.Value;

                    totalTax = item.Key.ItemType switch
                    {
                        ItemType.Food => totalTax += (itemPrice * 0.06m) * itemValue,
                        ItemType.Literature => totalTax += (itemPrice * 0.08m) * itemValue,
                        ItemType type when (type == ItemType.Service || type == ItemType.Hardware)
                            => totalTax += (itemPrice * 0.25m) * itemValue,
                        _ => 0m
                    };
                }

                return totalTax;
            }
            #endregion

            return 0;
        }
    }
}
