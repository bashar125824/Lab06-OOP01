using System;
using Xunit;
using OOP1;

namespace OOP1Test
{
    public class Program
    {
        [Fact]
        public void Horse_Test1()
        {
            OOP1.Program.Horse h = new OOP1.Program.Horse();

            Assert.Equal("Horses Sound", h.Sound());

        }

        [Fact]
        public void Horse_Test2()
        {
            OOP1.Program.Horse h = new OOP1.Program.Horse();

            Assert.Equal("Horses eat grass", h.Eat());

        }

        [Fact]
        public void Elephant_Test1()
        {
            OOP1.Program.Elephant e = new OOP1.Program.Elephant();

            Assert.Equal("Elephants Sound", e.Sound());

        }

        [Fact]
        public void Elephant_Test2()
        {
            OOP1.Program.Elephant e = new OOP1.Program.Elephant();

            Assert.Equal("Elephants Eat grass", e.Eat());

        }

        [Fact]
        public void Cat_Test1()
        {
            OOP1.Program.Cat c = new OOP1.Program.Cat();

            Assert.Equal("Cats Sound", c.Sound());

        }

        [Fact]
        public void Cat_Test2()
        {
            OOP1.Program.Cat c = new OOP1.Program.Cat();

            Assert.Equal("Cats Eat mice", c.Eat());

        }

        [Fact]
        public void Owl_Test1()
        {
            OOP1.Program.Owls o = new OOP1.Program.Owls();

            Assert.Equal("Owls Sound", o.Sound());

        }


        [Fact]
        public void Owl_Test2()
        {
            OOP1.Program.Owls o = new OOP1.Program.Owls();

            Assert.Equal("Owls Eat small Insects", o.Eat());

        }



        [Fact]
        public void Penguen_Test1()
        {
            OOP1.Program.Penguens p = new OOP1.Program.Penguens();

            Assert.Equal("Penguens Sound", p.Sound());

        }


        [Fact]
        public void Penguen_Test2()
        {
            OOP1.Program.Penguens p = new OOP1.Program.Penguens();

            Assert.Equal("Penguens Eat small fishes", p.Eat());

        }

       





    }
}
