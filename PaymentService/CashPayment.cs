﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService
{
    public class CashPayment : IPayment
    {
        public int calculatePrice(int price)
        {
            return price;
        }
    }
}
