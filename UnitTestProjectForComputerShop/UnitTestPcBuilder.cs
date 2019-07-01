using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class UnitTestPcBuilder
    {
        private PcBuilder.Pc newpc = new PcBuilder.Pc(300);

        [TestMethod]
        public void Add_option_to_pc()
        {
            PcBuilder.Keyboard keyboard = new PcBuilder.Keyboard(80, "Keyboard VIVER 7");

            PcBuilder.PcBuilder pcbuilder = new PcBuilder.PcBuilder(newpc);
            pcbuilder.addOption(keyboard);
            int price = pcbuilder.CalculatePrice();

            Assert.AreEqual(pcbuilder.CalculatePrice(),380);
        }

        [TestMethod]
        public void Add_2_option_to_pc()
        {
            PcBuilder.CPU cpu = new PcBuilder.CPU(350, "Spiritus x64 6985 coeurs");
            PcBuilder.Ram ram = new PcBuilder.Ram(200, "RAM Corsair 32 Go");
            PcBuilder.PcBuilder pcbuilder = new PcBuilder.PcBuilder(newpc);
            pcbuilder.addOption(ram).addOption(cpu);
            pcbuilder.CalculatePrice();
            Assert.AreEqual(pcbuilder.CalculatePrice(), 850);
        }
    }
}
