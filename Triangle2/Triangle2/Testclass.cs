using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Triangle2
{
    [TestFixture]
    class Testclass
    {
        [TestCase]
        public void Test_c_minus5_returnfalse()
        {
            int a = 5;
            int b = 3;
            int c = -5;
            bool s = false;

            Triangle second = new Triangle();
            bool actual = second.test(a, b, c);

            Assert.AreEqual(s, actual);
        }

        [TestCase]
        public void test_c_minus_b_minus_a_0_return_false()
        {
            int a = 0;
            int b = -3;
            int c = -5;
            bool s = false;

            Triangle second = new Triangle();
            bool actual = second.test(a, b, c);

            Assert.AreEqual(s, actual);
        }

        [TestCase]
            public void test_a_0_return_false()
            {
                int a = 0;
                int b = 3;
                int c = 5;
                bool s = false;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
            public void test_a_0_b_0_c_0_return_false()
            {
                int a = 0;
                int b = 0;
                int c = 0;
                bool s = false;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
            public void test_a_plus_b_more_c_return_true()
            {
                int a = 5;
                int b = 5;
                int c = 1;
                bool s = true;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
            public void test_c_more_then_a_plus_b_return_false()
            {
                int a = 5;
                int b = 5;
                int c = 11;
                bool s = false;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
            public void test_a_equally_b_equally_c_return_true()
            {
                int a = 5;
                int b = 5;
                int c = 5;
                bool s = true;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
            public void Test_b_minus6_return_false()
            {
                int a = 5;
                int b = -6;
                int c = 5;
                bool s = false;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
            public void test_c_minus_b_minus_a_minus_return_false()
            {
                int a = -5;
                int b = -3;
                int c = -5;
                bool s = false;

                Triangle second = new Triangle();
                bool actual = second.test(a, b, c);

                Assert.AreEqual(s, actual);
            }

        [TestCase]
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
