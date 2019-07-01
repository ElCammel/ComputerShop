using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace PcBuilder
{
    public interface IPcBuilder
    {
        IPcBuilder addOption(IOption IOption);
        IProduct GetPc();
        int CalculatePrice();
    }
}
