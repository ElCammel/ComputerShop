using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class UnitTestPcBuilder
    {
        [TestMethod]
        public void ConstructionPcForPcBuilderWithCpuRamKeyboard()
        {
            PcBuilder.Keyboard keyboard = new PcBuilder.Keyboard();
            keyboard.name = "Keyboard VIVER 7";
            keyboard.price = 80;

            PcBuilder.CPU cpu = new PcBuilder.CPU();
            cpu.name = "Spiritus x64 6985 coeurs";
            cpu.price = 350;

            PcBuilder.Pc newpc = new PcBuilder.Pc(300);

            PcBuilder.Ram ram = new PcBuilder.Ram();
            ram.name = "RAM Corsair 32 Go";
            ram.price = 200;
            

            List<PcBuilder.IOption> list = new List<PcBuilder.IOption>();
            list.Add(keyboard);
            list.Add(cpu);
            list.Add(ram);

            // newpc(list);  putin je ne sais pas comment mettre ça ppofgioperjgfoerj

            PcBuilder.PcBuilder pcBuilder = new PcBuilder.PcBuilder();
            pcBuilder.addKeyboard().addRam().addProcessor();



            // je ne vois pas comment test là
        }
    }
}
