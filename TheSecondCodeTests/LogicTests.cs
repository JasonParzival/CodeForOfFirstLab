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
        public void TrueResultTestCheck()
        {
            string smth = "3459";

            bool message = Logic.Check(smth);

            Assert.AreEqual(true, message);
        }

        [TestMethod()]
        public void FalseResultTestCheck()
        {
            string smth = "6743";

            bool message = Logic.Check(smth);

            Assert.AreEqual(false, message);
        }

        [TestMethod()]
        public void PositiveResultTestMessage()
        {
            string smth = "12345";

            string message = Logic.Message(smth);

            Assert.AreEqual("Последовательность: " + smth + " положительна!", message);
        }

        [TestMethod()]
        public void NegativeResultTestMessage()
        {
            string smth = "1423845";

            string message = Logic.Message(smth);

            Assert.AreEqual("Последовательность: " + smth + " отрицательна!", message);
        }

        [TestMethod()]
        public void UndigitResultTestIsDigitMessage()
        {
            string smth = "WTF";

            string message = Logic.IsDigitMessage(smth);

            Assert.AreEqual("Введённая строка не являются цифрой", message);
        }
    }
}