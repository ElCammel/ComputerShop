using System;
using System.Collections.Generic;
using Accounting;
using PaymentService;
using PcBuilder;

namespace ShoppingService
{
    public class Order
    {
        public Address shippingAddress { get; set; }
        public IPayment paymentMetthod { get; set; }
        private OrderStatus state;
        public List<IProduct> products { get; }

        public void PlaceOrder()
        {

        }

        public Order(OrderStatus state)
        {
            this.state = state;
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            state.AddProduct(product);
        }

        public void RemoveProduct(IProduct product)
        {
            state.RemoveProduct(product);
        }

        public void NextStatus(OrderStatus state)
        {
            this.state = state;
        }
    }
}