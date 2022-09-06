using System;
using System.Linq;
using TestLib;
using Xunit;

namespace dllTest.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddition()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            int term1 = 5;
            int term2 = 7;
            int expectedSum = 12;
            // act
            var testAdd = myFactory.GetPlugin("Addition");
            int result = testAdd.Run(term1, term2);
            // assert
            Assert.Equal(expectedSum, result);
        }

        [Fact]
        public void TestDivision()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            int dividend = 12;
            int divider = 3;
            int expectedDiv = 4;
            // act
            var testDiv = myFactory.GetPlugin("Division");
            int result = testDiv.Run(dividend, divider);
            // assert
            Assert.Equal(expectedDiv, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            int dividend = 12;
            int divider = 0;
            //act
            var testDiv = myFactory.GetPlugin("Division");
            // assert
            Assert.Throws<DivideByZeroException>(() => testDiv.Run(dividend, divider));
        }

        [Fact]
        public void TestSudstraction()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            int minuend = 11;
            int subtrahend = 4;
            int expectedSubstr = 7;
            // act
            var testSubstr = myFactory.GetPlugin("Subtraction");
            int result = testSubstr.Run(minuend, subtrahend);
            // assert
            Assert.Equal(expectedSubstr, result);
        }

        [Fact]
        public void TestMult()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            int multiplied = 11;
            int multiplier = 3;
            int expectedMult = 33;
            // act
            var testSubstr = myFactory.GetPlugin("Multiplication");
            int result = testSubstr.Run(multiplied, multiplier);
            // assert
            Assert.Equal(expectedMult, result);
        }

        [Fact]
        public void IsMyFactoryUnique()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            Plugins myFactory1 = Plugins.GetInstance();
            // assert
            Assert.True(myFactory == myFactory1);
        }

        [Fact]
        public void AllPluginNames()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            // act
            var pluginNames = myFactory.GetPluginNames;
            string[] sorted = pluginNames.OrderBy(x => x).ToArray();
            // assert
            Assert.Equal(sorted, (new string[] { "Multiplication", "Subtraction", "Division", "Addition" }).OrderBy(x => x).ToArray());
        }

        [Fact]
        public void PluginCount()
        {
            // arrange
            Plugins myFactory = Plugins.GetInstance();
            int realCount = 4;
            // act
            var result = myFactory.PluginsCount;
            // assert
            Assert.Equal(result, realCount);
        }
    }
}
