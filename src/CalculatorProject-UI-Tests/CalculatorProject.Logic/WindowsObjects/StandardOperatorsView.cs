using OpenQA.Selenium.Appium.Windows;

namespace CalculatorProject.Logic.WindowsObjects
{
    public class StandardOperatorsView : CalculatorView, IStandardOperatorsView
    {
        internal StandardOperatorsView(WindowsDriver<WindowsElement> session) : base(session)
        {
        }

        public ICalculatorView DivideBy()
        {
            Button("//Button[@Name='Divide by']", SearchType.ByXPath).Click();
            return this;
        }

        public ICalculatorView MultiplyBy()
        {
            Button("//Button[@Name='Multiply by']", SearchType.ByXPath).Click();
            return this;
        }

        public ICalculatorView Minus()
        {
            Button("//Button[@Name='Minus']", SearchType.ByXPath).Click();
            return this;
        }

        public ICalculatorView Plus()
        {
            Button("//Button[@AutomationId='plusButton']", SearchType.ByXPath).Click();
            return this;
        }

        public ICalculatorView Equals()
        {
            Button("//Button[@AutomationId='equalButton']", SearchType.ByXPath).Click();
            return this;
        }
    }
}