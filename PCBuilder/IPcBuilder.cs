using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder;

namespace PcBuilder
{
    public interface IPcBuilder
    {
        IPcBuilder addScreenSize();
        IPcBuilder addProcessor();
        IPcBuilder addRam();
        IPcBuilder addHddSize();
        IPcBuilder addVideoCard();
        IPcBuilder addHeadphone();
        IPcBuilder addMouse();
        IPcBuilder addBag();
        IPcBuilder addKeyboard();
        IProduct GetPc();
        int GetPrice();
        int CalculatePrice();
    }
}
