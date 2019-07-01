using PCBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder
{
    public class PcBuilder : IPcBuilder
    {
        private List<IOption> options = new List<IOption>();
        private int price { get; set; }
        private Pc pc;

        public PcBuilder(Pc pc)
        {
            this.pc = pc;
        }

        public IPcBuilder addOption(IOption option)
        {
            options.Add(option);
            return this;
        }

        public IProduct GetPc()
        {
            return pc;
        }

        public int CalculatePrice()
        {
            int result = this.price;

            foreach(IOption option in options)
            {
                result += option.price;
            }

            return result;
        }

    }
}