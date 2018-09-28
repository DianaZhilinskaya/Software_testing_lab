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
        public void Test_a_minus5_returnfalse()
        {
        int a = -5;
        int b = 3;
        int c = 5;
        bool s = false;

        Triangle second = new Triangle();
        bool actual = second.test(a, b, c);

        Assert.AreEqual(s, actual);
        }
    }
}