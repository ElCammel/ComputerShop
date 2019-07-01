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
        public IPayment paymentMethod { get; set; }
        public OrderStatus state { get; set; }
        public List<IProduct> products { get; }
        public int price { get; set; }

        public bool PlaceOrder()
        {
            return true;
        }

        public Order(OrderStatus state)
        {
            this.state = state;
            products = new List<IProduct>();
            price = 0;
        }

        public void AddProduct(IProduct product)
        {
            state.AddProduct(product);
            CalculatePrice();
        }

        public void RemoveProduct(IProduct product)
        {
            state.RemoveProduct(product);
            CalculatePrice();
        }

        public void NextStatus(OrderStatus state)
        {
            this.state = state;
        }

        public int CalculatePrice()
        {
            foreach (IProduct product in state.products)
            {
                this.price += product.GetPrice();
            }
           

            return price;
        }


        public int calculatePaymentPrice()
        {
            return paymentMethod.calculatePrice(this.price);
        }
        
    }
}