
using PcBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLiker
{
    public class LikesCounter : ILikeCounter
    {
        public LikesCounter(ProductAnalysis product)
        {
            product.SetLikeCounter(this);
        }

        public void Update(IProduct product)
        {
            Console.WriteLine(product.likeNumber);
        }
    }
}
