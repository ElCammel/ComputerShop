using System;
using System.Collections.Generic;
using System.Text;
using Accounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class AccountingTests
    {

        [TestMethod]
        public void creditCardDateShouldNotBeExpired()
        {
            CreditCard creditCard = new CreditCard("1298126745124567", "785", "10/2021");
            var result = creditCard.IsDateExpired();

            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void creditCardDateShouldHaveValidCCV()
        {
            CreditCard creditCard = new CreditCard("1298126745124567", "785", "10/2021");
            var result = creditCard.IsValidSecurityCode();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void creditCardDateShouldHaveValidNumber()
        {
            CreditCard creditCard = new CreditCard("1298126745124567", "785", "10/2021");
            var result = creditCard.IsValidCardNumber();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void creditCardDateShouldHaveValidInformations()
        {
            CreditCard creditCard = new CreditCard("1298126745124567", "785", "10/2021");
            var result = creditCard.IsValidCardInfos();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void creditCardDateShouldNotHaveValidCCV()
        {
            CreditCard creditCard = new CreditCard("1234567894561245", "78", "10/2021");
            var result = creditCard.IsValidSecurityCode();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void creditCardDateShouldBeExpired()
        {
            CreditCard creditCard = new CreditCard("1234567894561245", "785", "10/2017");
            var result = creditCard.IsDateExpired();

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void creditCardDateShouldNotHaveValidNumber()
        {
            CreditCard creditCard = new CreditCard("123", "785", "10/2021");
            var result = creditCard.IsValidCardNumber();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void creditCardDateShouldNotHaveValidInformations()
        {
            CreditCard creditCard = new CreditCard("123", "75", "10/2017");
            var result = creditCard.IsValidCardInfos();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void addressShouldBeComplete()
        {
            Address address = new Address("12 avenue de paris", "Chatillon", 92320);
            string stringAddress = address.street + " " + address.PostalCode.ToString() + " " + address.City;
            Assert.AreEqual("12 avenue de paris 92320 Chatillon", stringAddress);
        }

        [TestMethod]
        public void userShouldHaveValidCreditCard()
        {
            Address address = new Address("12 avenue de paris", "Chatillon", 92320);
            CreditCard creditCard = new CreditCard("1298126745124567", "785", "10/2021");
            User user = new User(address, address, "Paul", "Pedino", "06254874433");
            user.cards.Add(creditCard);

            var card = user.cards[0];
            Console.Write(card.cvvCode);
            Assert.IsTrue(card.IsValidCardInfos());
        }
    }
}
