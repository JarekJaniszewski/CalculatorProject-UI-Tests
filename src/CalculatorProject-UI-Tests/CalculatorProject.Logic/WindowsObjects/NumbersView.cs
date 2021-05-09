using OpenQA.Selenium.Appium.Windows;

namespace CalculatorProject.Logic.WindowsObjects
{
    public class NumbersView : CalculatorView, INumbersView
    {
        internal NumbersView(WindowsDriver<WindowsElement> session) : base(session)
        {
        }

        public ICalculatorView Zero()
        {
            Button("Zero", SearchType.ByName).Click();
            return this;
        }

        public ICalculatorView One()
        {
            Button("One", SearchType.ByName).Click();
            return this;
        }

        public ICalculatorView Two()
        {
            Button("Two", SearchType.ByName).Click();
            return this;
        }

        public ICalculatorView Three()
        {
            Button("Three", SearchType.ByName).Click();
            return this;
        }

        public ICalculatorView Four()
        {
            Button("Four", SearchType.ByName).Click();
            return this;
        }

        public ICalculatorView Five()
        {
            Button("num5Button", SearchType.ByAutomationId).Click();
            return this;
        }

        public ICalculatorView Six()
        {
            Button("num6Button", SearchType.ByAutomationId).Click();
            return this;
        }

        public ICalculatorView Seven()
        {
            Button("num7Button", SearchType.ByAutomationId).Click();
            return this;
        }

        public ICalculatorView Eight()
        {
            Button("num8Button", SearchType.ByAutomationId).Click();
            return this;
        }

        public ICalculatorView Nine()
        {
            Button("num9Button", SearchType.ByAutomationId).Click();
            return this;
        }
    }
}