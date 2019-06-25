using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder
{
    public interface IPc
    {
        List<IOption> GetOptions();
        int GetPrice();
    }
}
