using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle1.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void test_aplusbmorec_returntrue()
        {
            int a = 5;
            int b = 5;
            int c = 1;
            bool s = true;

            Triangle second = new Triangle();
            bool actual = second.test(a, b, c);

            Assert.AreEqual(s, actual);
        }
    }
}