using System;
using System.Collections.Generic;
using System.Text;
using ProductLiker;
using PcBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class ProductLikerTest
    {
        [TestMethod]
        public void Should_return_one_like_when_only_one_like_added()
        {
            ProductAnalysis liker = new ProductAnalysis();
            LikesCounter counter = new LikesCounter(liker);
            IProduct ram = new Ram(25, "Corsair");

            liker.LikeProduct(ram);

            Assert.AreEqual(1, ram.likeNumber);
        }

        [TestMethod]
        public void Should_return_two_likes_when_two_likes_added()
        {
            ProductAnalysis liker = new ProductAnalysis();
            LikesCounter counter = new LikesCounter(liker);
            IProduct ram = new Ram(25, "Corsair");

            liker.LikeProduct(ram);
            liker.LikeProduct(ram);

            Assert.AreEqual(2, ram.likeNumber);
        }
        
        
    }
}
