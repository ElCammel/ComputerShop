using System;

namespace PcBuilder
{
    public class Cuisto
    {
        public IPc GetSuperPc()
        {
            PcBuilder pcBuilder = new PcBuilder();
            return pcBuilder.addScreenSize().addProcessor().addRam().GetPc();


            /*IPcBuilder addScreenSize();
        IPcBuilder addProcessor();
        IPcBuilder addRam();
        IPcBuilder addHddSize();
        IPcBuilder addVideoCard();
        IPcBuilder addHeadphone();
        IPcBuilder addMouse();
        IPcBuilder addBag();
        IPcBuilder addKeyboard();
             */
        }
    }
}
