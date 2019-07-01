using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PaymentService;
using ShoppingService;
using PcBuilder;
using Accounting;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class PaymentServiceTest
    {
        [TestMethod]
        public void shouldCalculateCashPrice()
        {
            Order order = new Order(new InprogressStatus());
            order.AddProduct(new Ram(25, "corsair"));

            CheckoutProcess checkoutProcess = new CheckoutProcess(order, new Address("12 avenue de paris", "Chatillon", 92320), new CashPayment());
            int result = checkoutProcess.GetOrderPaimentMethodPrice();

            Assert.AreEqual(order.CalculatePrice(), 25);
        }

        [TestMethod]
        public void shouldCalculateCreditPrice()
        {
            Order order = new Order(new InprogressStatus());
            order.AddProduct(new Ram(15, "corsair"));

            CheckoutProcess checkoutProcess = new CheckoutProcess(order, new Address("12 avenue de paris", "Chatillon", 92320), new CreditPayment(3));
            int result = checkoutProcess.GetOrderPaimentMethodPrice();

            Assert.AreEqual(result, 5);
        }
    }
}
