using System;
using System.Collections.Generic;

namespace ShoppingService
{
    public class Order
    {
        public Accounting.Address shippingAddress { get; set; }
        public PaymentService.IPayment paymentMetthod { get; set; }


        public void PlaceOrder()
        {

        }
    }
}