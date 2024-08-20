using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{

    public class Order
    {
        public string CustomerName { get; }
        public string Address { get; }
        public List<string> Items { get; }
        public string PaymentMethod { get; }
        public string DeliveryMethod { get; }

        private Order(OrderBuilder builder)
        {
            Console.WriteLine("p ctor ici");
            CustomerName = builder.CustomerName;
            Address = builder.Address;
            Items = builder.Items;
            PaymentMethod = builder.PaymentMethod;
            DeliveryMethod = builder.DeliveryMethod;
        }

        public override string ToString()
        {
            return $"Order [Customer Name={CustomerName}, Address={Address}, Items=[{string.Join(", ", Items)}], Payment Method={PaymentMethod}, Delivery Method={DeliveryMethod}]";
        }

        // Inner Builder class
        public class OrderBuilder
        {
            public string CustomerName { get; }
            public string Address { get; private set; }
            public List<string> Items { get; private set; } = new List<string>();
            public string PaymentMethod { get; private set; }
            public string DeliveryMethod { get; private set; } = "Standard"; // Default value

            // Constructor for required field
            public OrderBuilder(string customerName)
            {
                Console.WriteLine("ob ctor ici");
                if (string.IsNullOrEmpty(customerName))
                {
                    throw new ArgumentException("Customer name cannot be null or empty");
                }
                CustomerName = customerName;
            }

            public OrderBuilder SetAddress(string address)
            {
                Address = address;
                return this;
            }

            public OrderBuilder AddItem(string item)
            {
                Items.Add(item);
                return this;
            }

            public OrderBuilder SetPaymentMethod(string paymentMethod)
            {
                PaymentMethod = paymentMethod;
                return this;
            }

            public OrderBuilder SetDeliveryMethod(string deliveryMethod)
            {
                DeliveryMethod = deliveryMethod;
                return this;
            }

            public Order Build()
            {
                // Check required field
                if (string.IsNullOrEmpty(PaymentMethod))
                {
                    throw new InvalidOperationException("Payment method is required");
                }

                return new Order(this);
            }
        }
    }
}
