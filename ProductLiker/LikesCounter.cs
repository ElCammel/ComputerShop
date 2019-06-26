using LikeCounter.Application;
using System;

namespace LikeCounter
{
    public class LikesCounter : ILikeCounter
    {

        public LikesCounter(ProductAnalysis product)
        {
            product.Add(this);
        }

        public void Update(int likesNumber)
        {
            Console.WriteLine(likesNumber);
        }
    }
}
