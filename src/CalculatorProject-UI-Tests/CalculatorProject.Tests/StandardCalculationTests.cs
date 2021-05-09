using NUnit.Framework;

namespace CalculatorProject.Tests
{
    public class StandardCalculationTests : BasicClass
    {
        [SetUp]
        public void SetUp()
        {
            calculator.ClearEntry();
        }

        [Test]
        public void One_Plus_Two_Test()
        {
            var result = calculator.Numbers.One()
                .StandardOperatorsView.Plus()
                .Numbers.Two()
                .StandardOperatorsView.Equals()
                .ReadResult();
            Assert.AreEqual(result, "3");
        }

        [Test]
        public void Eighty_Six_Minus_Twenty_Four_Test()
        {
            var result = calculator.Numbers.Eight()
                .Numbers.Six()
                .StandardOperatorsView.Minus()
                .Numbers.Two()
                .Numbers.Four()
                .StandardOperatorsView.Equals()
                .ReadResult();
            Assert.AreEqual(result, "62");
        }

        [Test]
        public void Fifty_MultiplyBy_Seven_Test()
        {
            var result = calculator.Numbers.Five()
                .Numbers.Zero()
                .StandardOperatorsView.MultiplyBy()
                .Numbers.Seven()
                .StandardOperatorsView.Equals()
                .ReadResult();
            Assert.AreEqual(result, "350");
        }

        [Test]
        public void Ninety_DividedBy_Six()
        {
            var result = calculator.Numbers.Nine()
                .Numbers.Zero()
                .StandardOperatorsView.DivideBy()
                .Numbers.Six()
                .StandardOperatorsView.Equals()
                .ReadResult();
            Assert.AreEqual(result, "15");
        }
    }
}
