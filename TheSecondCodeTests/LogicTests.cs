using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheSecondCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondCode.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void PositiveResultTest()
        {
            var smth = 12345;

            string message = Logic.Message(smth);

            Assert.AreEqual("Последовательность: " + smth + " положительна!", message);
        }

        [TestMethod()]
        public void NegativeResultTest()
        {
            var smth = 1423845;

            string message = Logic.Message(smth);

            Assert.AreEqual("Последовательность: " + smth + " отрицательна!", message);
        }
    }
}