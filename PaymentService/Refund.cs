using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService
{
    public class Refund : ITransaction
    {
        public IPaymentType paymentType;

        public Refund(IPaymentType paymentType)
        {
            this.paymentType = paymentType;
        }

        public void perform()
        {
            paymentType.refund();
        }
    }
}
