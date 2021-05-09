using CalculatorProject.Logic;
using CalculatorProject.Logic.WindowsObjects;
using NUnit.Framework;

namespace CalculatorProject.Tests
{
    public class BasicClass
    {
        protected ICalculatorView calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = Windows.Launch();
            calculator.SetStandardMode();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            calculator.Close();
        }
    }
}
