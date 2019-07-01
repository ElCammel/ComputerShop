using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PcBuilder;
using ShoppingService;
using System;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class ShoppingServiceTest
    {
        [TestMethod]
        public void Should_add_item_into_an_in_progress_order()
        {

            OrderStatus orderStatus = new InprogressStatus();
            var product = new Ram(300, "16 Go");
            orderStatus.AddProduct(product);


            Assert.IsTrue(orderStatus.products.Contains(product));
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Should_throw_notSuportedException_when_adding_an_item_into_a_validated_order()
        {
            OrderStatus orderStatus = new InprogressStatus();
            var order = new Order(orderStatus);
            order.NextStatus(new ValidateStatus());
            var product = new Ram(300, "16 Go");
            orderStatus.AddProduct(product);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Should_throw_notSupportedException_when_adding_an_item_into_a_delivered_order()
        {
            
            OrderStatus orderStatus = new InprogressStatus();
            var order = new Order(orderStatus);
            order.NextStatus(new ValidateStatus());
            order.NextStatus(new DeliveredStatus());
            var product = new Ram(300, "16 Go");
            order.AddProduct(product);
        }

        [TestMethod]
        public void Should_remove_item_from_the_order_when_it_is_in_progress()
        {
            OrderStatus orderStatus = new InprogressStatus();
            var order = new Order(orderStatus);
            var product = new Ram(300, "16 Go");
            order.AddProduct(product);

            order.RemoveProduct(product);

            Assert.IsFalse(order.products.Contains(product));
        }
        
        [TestMethod]
        public void Should_remove_item_from_the_order_when_it_is_validated()
        {
            OrderStatus orderStatus = new InprogressStatus();
            var order = new Order(orderStatus);
            var product = new Ram(300, "16 Go");
            order.AddProduct(product);
            order.NextStatus(new ValidateStatus());

            order.RemoveProduct(product);

            Assert.IsFalse(order.products.Contains(product));
        }
        /*
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Should_throw_notSupportedException_when_remove_an_item_from_a_delivered_order()
        {
            OrderStatus orderStatus = new InprogressStatus(new List<Item>());
            var order = new Order(orderStatus);
            order.NextStatus(new ValidateStatus(order.Items));
            order.NextStatus(new DeliveredStatus(order.Items));
            var item = new Item();
            order.RemoveItem(item);
        }*/
    }
}
