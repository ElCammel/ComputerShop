﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService
{
    public interface IPayment
    {
        double calculatePrice(double price);
    }
}
