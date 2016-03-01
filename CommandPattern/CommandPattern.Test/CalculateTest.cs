using CommandPattern.Command;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandPattern.Test
{
    [TestClass]
    public sealed class CalculateTest
    {
        [TestMethod]
        public void Add()
        {
            AddCommand addCommand = new AddCommand(3, 5);
            double result = addCommand.Run();

            result.Should().Be(8);
        }

        [TestMethod]
        public void AddWithMinusValues()
        {
            AddCommand addCommand = new AddCommand(3, -5);
            double result = addCommand.Run();

            result.Should().Be(-2);
        }

        [TestMethod]
        public void Substract()
        {
            SubstractCommand substractCommand = new SubstractCommand(5, 2);

            double result = substractCommand.Run();

            result.Should().Be(3);
        }

        [TestMethod]
        public void SubstractWithZero()
        {
            SubstractCommand substractCommand = new SubstractCommand(0, 3);
            double result = substractCommand.Run();

            result.Should().Be(-3);
        }

        [TestMethod]
        public void SubstractWithMinusValues()
        {
            SubstractCommand substractCommand = new SubstractCommand(-1, -2);
            double result = substractCommand.Run();

            result.Should().Be(1);
        }

        [TestMethod]
        public void Multi()
        {
            MultiCommand multiCommand = new MultiCommand(3, 2);
            double result = multiCommand.Run();

            result.Should().Be(6);
        }

        [TestMethod]
        public void MultiWithZero()
        {
            MultiCommand multiCommand = new MultiCommand(0, 2);
            double result = multiCommand.Run();

            result.Should().Be(0);
        }

        [TestMethod]
        public void MultiWithMinusValue()
        {
            MultiCommand multiCommand = new MultiCommand(3, -1);
            double result = multiCommand.Run();

            result.Should().Be(-3);
        }

        [TestMethod]
        public void Divide()
        {
            DivideCommand divideCommand = new DivideCommand(4, 2);
            double result = divideCommand.Run();

            result.Should().Be(2);
        }

        [TestMethod]
        public void DivideWithZero()
        {
            DivideCommand divideCommand = new DivideCommand(0, 4);
            double result = divideCommand.Run();

            result.Should().BeLessOrEqualTo(0);

        }

        [TestMethod]
        public void DividedByWithZero()
        {
            DivideCommand divideCommand = new DivideCommand(4, 0);
            double result = divideCommand.Run();

            Assert.AreNotEqual(0, result);

        }

        [TestMethod]
        public void DivideWithMinus()
        {
            DivideCommand divideCommand = new DivideCommand(-4, 2);
            double result = divideCommand.Run();

            result.Should().Be(-2);

        }

        [TestMethod]
        public void DivideWithDecimalNumber()
        {
            DivideCommand divideCommand = new DivideCommand(4, 2.5);
            double result = divideCommand.Run();

            result.Should().Be(1.6);
        }
    }
}