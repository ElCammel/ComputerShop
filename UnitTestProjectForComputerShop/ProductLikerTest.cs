using System;
using System.Collections.Generic;
using System.Text;
using ProductLiker;
using PcBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProjectForComputerShop
{
    class ProductLikerTest
    {
        [TestMethod]
        public void Should_return_one_like_when_only_one_like_added()
        {
            ProductAnalysis liker = new ProductAnalysis();
            LikesCounter counter = new LikesCounter(liker);
            IProduct ram = new Ram(25, "Corsair");

            //liker.LikeProduct();

            int numberLikes = liker.GetLikesNumber();
            Assert.AreEqual(1, numberLikes);
        }

        [TestMethod]
        public void Should_return_two_likes_when_two_likes_added()
        {
            ProductAnalysis liker = new ProductAnalysis();
            LikesCounter counter = new LikesCounter(liker);
           // liker.LikeProduct();
            //liker.LikeProduct();
            int numberLikes = liker.GetLikesNumber();
            Assert.AreEqual(2, numberLikes);
        }

        [TestMethod]
        public void Should_return_likes_number_when_calling_product_liker()
        {
            ProductAnalysis liker = new ProductAnalysis();
            //liker.LikeProduct();
            LikesCounter counter = new LikesCounter(liker);
            int likeNumber = liker.GetLikesNumber();
            Assert.AreEqual(1, likeNumber);
        }
        
    }
}
