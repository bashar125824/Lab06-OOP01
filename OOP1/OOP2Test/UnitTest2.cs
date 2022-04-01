using System;
using Xunit;
using OOP1;

namespace OOP2Test
{
    public class UnitTest2
    {
        [Fact]
        public void Test_Irunable_Interface_On_Horse_Class()
        {
            OOP1.Program.Irunable horseRuns = new OOP1.Program.Horse();

            Assert.Equal("Horses high speed is 54.7 miles per hour", horseRuns.highSpeed());
        }

        [Fact]
        public void Test_Irunable_Interface_On_Cat_Class()
        {
            OOP1.Program.Irunable catRuns = new OOP1.Program.Cat();

            Assert.Equal("Cats high speed is 30 miles per hour", catRuns.highSpeed());
        }

        [Fact]
        public void Test_Idemostic_Interface()
        {
            OOP1.Program.Idomestic catsDemostic = new OOP1.Program.Cat();

            Assert.Equal("Cats are domestic animals", catsDemostic.animalisDomestic());
        }
    }
}
