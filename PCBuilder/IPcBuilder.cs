using System;
using System.Collections.Generic;
using System.Text;

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
        IPc GetPc();
        int GetPrice();
        int CalculatePrice();
    }
}
