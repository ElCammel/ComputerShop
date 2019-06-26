using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ProductLiker
{
    public class ProductAnalysis
    {
        private int likesNumber = 0;
        private ILikeCounter counter;

        public void LikeProduct(IProduct product)
        {
            product.likeNumber ++;
            counter.Update(product);
        }

        public void SetLikeCounter(ILikeCounter counter)
        {
            this.counter = counter;
        }

        public int GetLikesNumber()
        {
            return likesNumber;
        }
    }
}
