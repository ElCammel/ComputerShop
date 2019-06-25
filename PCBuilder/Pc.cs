﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder
{
    public class Pc : IPc
    {
        private int price;
        private List<IOption> options;

        public Pc(int price)
        {
            this.price = price;
        }
        public int GetPrice()
        {
            return price;
        }
        public Pc(List<IOption> options)
        {
            this.options = options;
        }

        public List<IOption> GetOptions()
        {
            return options;
        }
    }
}