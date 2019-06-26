using System;
using System.Collections.Generic;

namespace ShoppingService
{
    public class Order
    {
        public Accounting.Address shippingAddress { get; set; }
        public PaymentService.IPayment paymentMetthod { get; set; }
        private OrderStatus state;
        public List<IProduct> Items { get; }

        public void PlaceOrder()
        {

        }

        public Order(OrderStatus state)
        {
            this.state = state;
            Items = new List<IProduct>();
        }

        public void AddItem(IProduct item)
        {
            state.AddItem(item);
        }

        public void RemoveItem(IProduct item)
        {
            state.RemoveItem(item);
        }

        public void NextStatus(OrderStatus state)
        {
            this.state = state;
        }
    }
}