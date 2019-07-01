using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PaymentService;
using ShoppingService;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class PaymentServiceTest
    {
        [TestMethod]
        public void shouldCalculateLuxembourgCashPrice()
        {
            IPayment cashPayment = new CashPayment();
            Order order = new Order(cashPayment, 1, 2);
            double result = order.calculatePrice();

            Assert.AreEqual(result, 3.42);
        }

        [TestMethod]
        public void shouldCalculateLuxembourgCreditPrice()
        {
            IPayment creditPaiement = new CreditPayment(2);
            LuxembourgOrder order = new LuxembourgOrder(creditPaiement, 1, 2);
            double result = order.calculatePrice();

            Assert.AreEqual(result, 1.71);
        }
    }
}
