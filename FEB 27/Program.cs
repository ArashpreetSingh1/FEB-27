using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEB_27
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process();
            public class OrderProcessor
        {
            private readonly ShippingCalculator shippingCalculator;
            public OrderProcessor()
            {
                _shippingCalculator = new ShippingCalculate();
            }
            public void Process(OrderProcessor order)
            {
                if (order.IsShipped)
                    throw new InvalidOperationException("This order is alrady processed.");
                order.Shipment = new shipment
                {
                    Cost = shippingCalculator.Calculateshipping(order)
                    ShippingDate = DateTime.Today.AddDays(1)

                }
        }
        }
    }

}
public class ShippingCalculate
{
    public float CalculateShipping(Order order)
    {
        publicfloat CalculateShipping()
    }
}
