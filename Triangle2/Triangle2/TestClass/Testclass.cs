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
        [Test]
        public void Test_c_minus5_returnfalse()
        {     
            Triangle second = new Triangle();
            bool actual = second.test(5, 3, -5);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void test_c_minus_b_minus_a_0_return_false()
        {
            Triangle second = new Triangle();
            bool actual = second.test(0, -3, -5);

            Assert.AreEqual(false, actual);
        }

        [Test]
            public void test_a_0_return_false()
            {
                Triangle second = new Triangle();
                bool actual = second.test(0, 3, 5);

                Assert.AreEqual(false, actual);
            }

        [Test]
            public void test_a_0_b_0_c_0_return_false()
            {
                Triangle second = new Triangle();
                bool actual = second.test(0, 0, 0);

                Assert.AreEqual(false, actual);
            }

        [Test]
            public void test_a_plus_b_more_c_return_true()
            {
                Triangle second = new Triangle();
                bool actual = second.test(5, 5, 1);

                Assert.AreEqual(true, actual);
            }

        [Test]
            public void test_c_more_then_a_plus_b_return_false()
            {
                Triangle second = new Triangle();
                bool actual = second.test(5, 5, 11);

                Assert.AreEqual(false, actual);
            }

        [Test]
            public void test_a_equally_b_equally_c_return_true()
            {
                Triangle second = new Triangle();
                bool actual = second.test(5, 5, 5);

                Assert.AreEqual(true, actual);
            }

        [Test]
            public void Test_b_minus6_return_false()
            {
                Triangle second = new Triangle();
                bool actual = second.test(5, -6, 5);

                Assert.AreEqual(false, actual);
            }

        [Test]
            public void test_c_minus_b_minus_a_minus_return_false()
            {
                Triangle second = new Triangle();
                bool actual = second.test(-5, -3, -5);

                Assert.AreEqual(false, actual);
            }

        [Test]
            public void Test_a_minus5_returnfalse()
            {
                Triangle second = new Triangle();
                bool actual = second.test(-5, 3, 5);

                Assert.AreEqual(false, actual);
            }
    }
}
