using System;
using System.Collections.Generic;
using System.Text;


namespace LikeCounter
{
    public class ProductAnalysis
    {
        private int likesNumber = 0;
        public List<Application.ILikeCounter> counters = new List<Application.ILikeCounter>();

        public void LikeProduct()
        {
            likesNumber++;
            foreach(var counter in this.counters)
            {
                counter.Update(likesNumber);
            }
        }

        public void Add(Application.ILikeCounter counter)
        {
            counters.Add(counter);
        }

        public int GetLikesNumber()
        {
            return likesNumber;
        }
    }
}
