using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace ProductLiker
{
    public interface ILikeCounter
    {
        void Update(IProduct product);
    }
}
