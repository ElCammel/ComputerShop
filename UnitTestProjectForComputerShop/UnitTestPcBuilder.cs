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
            PcBuilder.Keyboard keyboard = new PcBuilder.Keyboard(80, "Keyboard VIVER 7");

            PcBuilder.CPU cpu = new PcBuilder.CPU(350, "Spiritus x64 6985 coeurs");

            PcBuilder.Pc newpc = new PcBuilder.Pc(300);

            PcBuilder.Ram ram = new PcBuilder.Ram(200, "RAM Corsair 32 Go");

            List<PcBuilder.IOption> list = new List<PcBuilder.IOption>();
            list.Add(keyboard);
            list.Add(cpu);
            list.Add(ram);

            // newpc(list);  putin je ne sais pas comment mettre ça ppofgioperjgfoerj

            PcBuilder.PcBuilder pcBuilder = new PcBuilder.PcBuilder();
            pcBuilder.addKeyboard().addRam().addProcessor();
            pcBuilder.GetPc();
            pcBuilder.GetPrice();
            Assert.AreEqual(0, pcBuilder.GetPrice());
            // je ne vois pas comment test là
        }
    }
}
