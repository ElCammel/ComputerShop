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
        public IPcBuilder addScreenSize()
        {
            options.Add(new ScreenSize());
            return this;
        }
        public IPcBuilder addProcessor()
        {
            options.Add(new CPU());
            return this;
        }

        public IPcBuilder addRam()
        {
            options.Add(new Ram());
            return this;
        }
        public IPcBuilder addHddSize()
        {
            options.Add(new HddSize());
            return this;
        }
        public IPcBuilder addVideoCard()
        {
            options.Add(new VideoCard());
            return this;
        }
        public IPcBuilder addHeadphone()
        {
            options.Add(new Headphone());
            return this;
        }
        public IPcBuilder addMouse()
        {
            options.Add(new Mouse());
            return this;
        }
        public IPcBuilder addBag()
        {
            options.Add(new Bag());
            return this;
        }
        public IPcBuilder addKeyboard()
        {
            options.Add(new Keyboard());
            return this;
        }

        public IProduct GetPc()
        {
            return new Pc(options);
        }
        public int GetPrice()
        {
            return price ;
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