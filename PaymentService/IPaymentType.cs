﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService
{
    public interface IPaymentType
    {
        void sale();
        void refund();
    }
}
