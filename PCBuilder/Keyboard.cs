using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcBuilder;

namespace PcBuilder
{
    public class Keyboard : IOption
    {
        public int price { get; set; }
        public string name { get; set; }
        public int likeNumber { get; set; }
        public Keyboard(int price, string name)
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
