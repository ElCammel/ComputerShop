using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService
{
    public class CashPayment : IPayment
    {
        public double calculatePrice(double price)
        {
            return price;
        }
    }
}
