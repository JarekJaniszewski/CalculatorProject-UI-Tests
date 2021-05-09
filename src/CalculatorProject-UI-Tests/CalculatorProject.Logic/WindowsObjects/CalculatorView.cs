using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace CalculatorProject.Logic.WindowsObjects
{
    public class CalculatorView : WindowObject, ICalculatorView
    {
        internal CalculatorView(WindowsDriver<WindowsElement> session)
            : base(session)
        {
        }

        private static INumbersView _numbersView;

        public INumbersView Numbers
        {
            get
            {
                if (_numbersView == null)
                {
                    _numbersView = new NumbersView(session);
                }
                return _numbersView;
            }
        }

        private static IStandardOperatorsView _standardOperatorsView;

        public IStandardOperatorsView StandardOperatorsView
        {
            get
            {
                if (_standardOperatorsView == null)
                {
                    _standardOperatorsView = new StandardOperatorsView(session);
                }
                return _standardOperatorsView;
            }
        }

        public ICalculatorView ClearEntry()
        {
            Button("//Button[@AutomationId='clearEntryButton']", SearchType.ByXPath).Click();
            return this;
        }

        public ICalculatorView SetStandardMode()
        {
            WindowsElement header = null;

            // Identify calculator mode by locating the header
            try
            {
                header = session.FindElementByAccessibilityId("Header");
            }
            catch
            {
                header = session.FindElementByAccessibilityId("ContentPresenter");
            }

            // Ensure that calculator is in standard mode
            if (!header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase))
            {
                Button("TogglePaneButton").Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));

                var splitViewPane = session.FindElementByClassName("SplitViewPane");
                splitViewPane.FindElementByName("Standard Calculator").Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

            return this;
        }

        public string ReadResult()
        {
            return TextBox("CalculatorResults", SearchType.ByAutomationId).Text.Replace("Display is ", "");
        }

        public void Close()
        {
            Button("Close Calculator", SearchType.ByName).Click();
        }
    }
}