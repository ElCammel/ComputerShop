using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PaymentService;
using ShoppingService;
using PcBuilder;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class PaymentServiceTest
    {
        [TestMethod]
        public void shouldCashPrice()
        {
            IPayment cashPayment = new CashPayment();
            Order order = new Order();
            order.AddProduct(new Ram(25, "corsair"));
            ValidateStatus validateStatus = new ValidateStatus(order.products);
            CheckoutProcess checkoutProcess = new CheckoutProcess(order);
            double result = order.price;

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
