

//namespace UnitTest
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }


//        [Test]
//        public void AdditionTest()
//        {
//            RationalNumber number1 = new RationalNumber(1, 2);
//            RationalNumber result = number1 + 1;
//            Assert.AreEqual("3/2", result.ToString());
//        }

//        [Test]
//        public void SubtractionTest()
//        {
//            RationalNumber number1 = new RationalNumber(3, 4);
//            RationalNumber result = number1 - 1;
//            Assert.AreEqual("1/4", result.ToString());
//        }

//        [Test]
//        public void MultiplicationTest()
//        {
//            RationalNumber number1 = new RationalNumber(2, 3);
//            RationalNumber result = number1 * 2;
//            Assert.AreEqual("4/3", result.ToString());
//        }

//        [Test]
//        public void DivisionTest()
//        {
//            RationalNumber number1 = new RationalNumber(1, 2);
//            RationalNumber result = number1 / 2;
//            Assert.AreEqual("1/4", result.ToString());
//        }

//        [Test]
//        public void UnaryMinusTest()
//        {
//            RationalNumber number1 = new RationalNumber(2, 3);
//            RationalNumber result = -number1;
//            Assert.AreEqual("-2/3", result.ToString());
//        }

//        [Test]
//        public void EqualityTest()
//        {
//            RationalNumber number1 = new RationalNumber(1, 2);
//            RationalNumber number2 = new RationalNumber(1, 2);
//            Assert.IsTrue(number1 == number2);
//        }

//        [Test]
//        public void InequalityTest()
//        {
//            RationalNumber number1 = new RationalNumber(1, 2);
//            RationalNumber number2 = new RationalNumber(3, 4);
//            Assert.IsTrue(number1 != number2);
//        }

//        [Test]
//        public void LessThanTest()
//        {
//            RationalNumber number1 = new RationalNumber(1, 2);
//            RationalNumber number2 = new RationalNumber(3, 4);
//            Assert.IsTrue(number1 < number2);
//        }

//        [Test]
//        public void GreaterThanTest()
//        {
//            RationalNumber number1 = new RationalNumber(3, 4);
//            RationalNumber number2 = new RationalNumber(1, 2);
//            Assert.IsTrue(number1 > number2);
//        }
//    }
//}