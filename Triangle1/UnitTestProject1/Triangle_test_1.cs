using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Triangle_test_1
    {
        [TestMethod]
        public void Test_true_returndtrue()
        {
            int a = 4;
            int b = 3;
            int c = 5;
            bool s = true;

            Triangle1.Triangle first = new Triangle1.Triangle();
            bool actual = first.test(a, b, c);

            Assert.AreEqual(s, actual);
        }
    }
}
