
using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace PcBuilder
{
    public interface IOption :IProduct
    {
        int price { get; set; }

    }
}