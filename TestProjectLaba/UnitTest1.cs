using NUnit.Framework;

namespace TestProjectLaba
{
    public class Tests
    {
        [Test]
        public void Test_Constructor()
        {
            Assert.Throws<ArgumentException>(() => new RationalNumber(5, 0));
            Assert.Throws<ArgumentException>(() => new RationalNumber(0, 0));
            Assert.Throws<ArgumentException>(() => new RationalNumber(-2, 0));
        }
        [Test]
        public void Test_ToString()
        {
            var num = new RationalNumber(2, 3);
            Assert.DoesNotThrow(() =>
            {
                string result = num.ToString();
                Assert.AreEqual("2/3", result);
            });
        }

        [Test]
        public void Test_AddOperator()
        {
            var number = new RationalNumber(2, 3);
            Assert.DoesNotThrow(() =>
            {
                number += 5;
                var expected = new RationalNumber(17, 3);
                Assert.AreEqual(number.ToString(), expected.ToString());
            });
        }

        [Test]
        public void Test_MinusOperator()
        {
            var number = new RationalNumber(10, 3);

            Assert.DoesNotThrow(() =>
            {
                number -= 2; 
                var expected = new RationalNumber(4, 3);
                Assert.AreEqual(number, expected);
            });
        }

        [Test]
        public void Test_MultOperator()
        {
            var number = new RationalNumber(2, 3);
            Assert.DoesNotThrow(() =>
            {
                number *= 2; 
                var expected = new RationalNumber(4, 3);
                Assert.AreEqual(number, expected);
            });
        }

        [Test]
        public void Test_DivOperator()
        {
            var number = new RationalNumber(9, 6);

            Assert.DoesNotThrow(() =>
            {
                var expected = new RationalNumber(1, 2);
                Assert.AreEqual(number, expected);
            });
        }

        [Test]
        public void Test_UnarMinusOperator()
        {
            var number = new RationalNumber(9, 6);
            Assert.DoesNotThrow(() =>
            {
                number = -number; 
                var expected = new RationalNumber(-9, 6);
                Assert.AreEqual(number, expected);
            });
        }

        [Test]
        public void Test_EqualOperator()
        {
            var number = new RationalNumber(9, 6);
            var expected = new RationalNumber(9, 6);
            Assert.DoesNotThrow(() =>
            {
                bool res = number == expected;
                Assert.AreEqual(res, true);
            });
        }

        [Test]
        public void Test_NotEqualOperator()
        {
            var number = new RationalNumber(9, 6);
            var expected = new RationalNumber(90, 6);
            Assert.DoesNotThrow(() =>
            {
                bool res = number != expected;
                Assert.AreEqual(res, true);
            });
        }

        [Test]
        public void Test_LessOperator()
        {
            var number = new RationalNumber(9, 6);
            var expected = new RationalNumber(10, 6);

            Assert.DoesNotThrow(() =>
            {
                bool res = number < expected;
                Assert.AreEqual(res, true);
            });
        }

        [Test]
        public void Test_LessAndEqualOperator()
        {
            var number = new RationalNumber(9, 6);
            var expected = new RationalNumber(9, 6);
            Assert.DoesNotThrow(() =>
            {
                bool res = number <= expected;
                Assert.AreEqual(res, true);
            });
        }

        [Test]
        public void Test_MoreOperator()
        {
            var number = new RationalNumber(90, 6);
            var expected = new RationalNumber(10, 6);
            Assert.DoesNotThrow(() =>
            {
                bool res = number > expected;
                Assert.AreEqual(res, true);
            });
        }

        [Test]
        public void Test_MoreAndEqualOperator()
        {
            var number = new RationalNumber(10, 6);
            var expected = new RationalNumber(10, 6);
            Assert.DoesNotThrow(() =>
            {
                bool res = number >= expected;
                Assert.AreEqual(res, true);
            });
        }

    }
}