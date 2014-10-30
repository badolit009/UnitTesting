using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestCalculatorApp;

namespace UnitTest.test
{
    [TestFixture]
    class UnitTestCalculator
    {
        private Calculator aCalculator;

        [SetUp]
        public void Start()
        {
            aCalculator = new Calculator();
        }
        [Test]
        public void AddTest_If_Check_Add_Two_Positive_Data()
        {
            int expectedValue=10;
            Assert.AreEqual(expectedValue,aCalculator.Add(5,5));
        }
        [Test]
        public void SubTest_If_Check_Subtruct_Two_Positive_Data()
        {
            Assert.AreEqual(7,aCalculator.Subtract(9,2));
        }
        [Test]
        public void MultipyTest_If_Check_Two_Positive_Data()
        {
            Assert.AreEqual(12,aCalculator.multiply(3,4));
        }
        [Test]
        public void Devidetest_If_Check_Two_Positive_Data()
        {
            Assert.AreEqual(5,aCalculator.Devide(10,2));
        }

        [TearDown]
        public void End()
        {
            
        }
    }
}
