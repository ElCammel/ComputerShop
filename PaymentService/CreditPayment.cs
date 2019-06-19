using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService
{
    public class CreditPayment : IPayment
    {
        private int numberOfPayments { get; set; }

        public CreditPayment(int numberOfPayments)
        {
            this.numberOfPayments = numberOfPayments;
        }

        public double calculatePrice(double price)
        {
            return price / numberOfPayments;
        }
    }
}
