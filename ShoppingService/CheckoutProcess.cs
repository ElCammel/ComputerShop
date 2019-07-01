using System;
using System.Collections.Generic;
using System.Text;
using PaymentService;
using Accounting;

namespace ShoppingService
{
    public class CheckoutProcess
    {
        public Order order { get; set; }

       public CheckoutProcess(Order order, Address shippingAddress, IPayment paymentMethod)
        {
            this.order = order;
            order.shippingAddress = shippingAddress;
            order.paymentMethod = paymentMethod;

            order.PlaceOrder();
        }

        public CheckoutProcess(Order order)
        {
            this.order = order;

        }

        public void SetShipmentAddress(Address shippingAddress)
        {
            order.shippingAddress = shippingAddress;
        }

        public void SetPaymentMethod(IPayment paymentMethod)
        {
            order.paymentMethod = paymentMethod;
        }

        public void PlaceOrder()
        {
            order.PlaceOrder();
        }

        public int GetOrderPaimentMethodPrice()
        {
            return order.calculatePaymentPrice();
        }

    }
}
