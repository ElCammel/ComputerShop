using PcBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuilder
{
    public class CPU : IOption
    {
        public int price { get; set; }
        public string name { get; set; }

        public CPU(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int GetPrice()
        {
            return this.price;
        }

    }
}
