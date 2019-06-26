using System;
using System.Collections.Generic;

namespace ShoppingService
{
    public class Order
    {
        public Accounting.Address shippingAddress { get; set; }
        public PaymentService.IPayment paymentMetthod { get; set; }
        private OrderStatus state;
        public List<PcBuilder.IProduct> products { get; }

        public void PlaceOrder()
        {

        }

        public Order(OrderStatus state)
        {
            this.state = state;
            products = new List<PcBuilder.IProduct>();
        }

        public void AddProduct(PcBuilder.IProduct product)
        {
            state.AddProduct(product);
        }

        public void RemoveProduct(PcBuilder.IProduct product)
        {
            state.RemoveProduct(product);
        }

        public void NextStatus(OrderStatus state)
        {
            this.state = state;
        }
    }
}