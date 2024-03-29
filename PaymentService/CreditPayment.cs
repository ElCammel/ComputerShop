﻿using System;
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

        public int calculatePrice(int price)
        {
            return price / numberOfPayments;
        }
    }
}
