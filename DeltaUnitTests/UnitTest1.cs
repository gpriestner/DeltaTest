using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeltaTest;

namespace DeltaUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myAdder = new MyAdderUnit();

            var myCalculator = new Calculator(myAdder);

            var result = myCalculator.Add(2, 3);

            Assert.AreEqual(5, result);

        }
    }

    public class MyAdderUnit : IAddition
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}