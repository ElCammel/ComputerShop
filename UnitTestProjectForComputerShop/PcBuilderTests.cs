using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProjectForComputerShop
{
    [TestClass]
    public class PcBuilderTests
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
        [TestMethod]
        public void Compare_false_price_for_an_option()
        {
            PcBuilder.CPU cpu = new PcBuilder.CPU(350, "Spiritus x64 6985 coeurs");
            PcBuilder.PcBuilder pcbuilder = new PcBuilder.PcBuilder(newpc);
            pcbuilder.addOption(cpu);
            pcbuilder.CalculatePrice();
            Assert.AreNotEqual(pcbuilder.CalculatePrice(), 300);
        }

        [TestMethod]
        public void Add_many_option_to_build_a_big_pc()
        {
            PcBuilder.Keyboard keyboard = new PcBuilder.Keyboard(80, "Keyboard VIVER 7");
            PcBuilder.CPU cpu = new PcBuilder.CPU(350, "Spiritus x64 6985 coeurs");
            PcBuilder.Ram ram = new PcBuilder.Ram(200, "RAM Corsair 32 Go");
            PcBuilder.VideoCard videocard = new PcBuilder.VideoCard(800, "RTX 2080 Ti OC");
            PcBuilder.ScreenSize screenSize = new PcBuilder.ScreenSize(300, "Monitor Prédator ASUS");
            PcBuilder.PcBuilder pcbuilder = new PcBuilder.PcBuilder(newpc);
            pcbuilder.addOption(keyboard).addOption(ram).addOption(cpu).addOption(videocard).addOption(screenSize);
            pcbuilder.CalculatePrice();
            Assert.AreEqual(pcbuilder.CalculatePrice(), 2030);
        }
    }
}
