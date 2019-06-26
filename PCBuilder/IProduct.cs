using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace PcBuilder
{
    public interface IProduct
    {
        int likeNumber { get; set; }
        int GetPrice();
    }
}
