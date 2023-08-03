using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public class USSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            var totalPrice = order.TotalPrice;

            return order.ShippingDetails.DestinationState.ToLowerInvariant() switch
            {
                "la" => totalPrice * 0.095m,
                "ny" => totalPrice * 0.04m,
                "nyc" => totalPrice * 0.045m,
                _ => 0m,
            };
        }
    }
}
