using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class CheckoutProcess
    {
        public Order order { get; set; }

       public CheckoutProcess(Order order, Accounting.Address shippingAddress, PaymentService.IPayment paymentMetthod)
        {
            this.order = order;
            order.shippingAddress = shippingAddress;
            order.paymentMetthod = paymentMetthod;
            order.PlaceOrder();
        }

        public CheckoutProcess(Order order)
        {
            this.order = order;

        }

        public void SetShipmentAddress(Accounting.Address shippingAddress)
        {
            order.shippingAddress = shippingAddress;
        }

        public void SetPaymentMethod(PaymentService.IPayment paymentMethod)
        {
            order.paymentMetthod = paymentMethod;
        }

        public void PlaceOrder()
        {
            order.PlaceOrder();
        }

    }
}
