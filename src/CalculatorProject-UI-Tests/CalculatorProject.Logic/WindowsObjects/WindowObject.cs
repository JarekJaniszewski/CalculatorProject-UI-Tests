using OpenQA.Selenium.Appium.Windows;

namespace CalculatorProject.Logic.WindowsObjects
{
    public class WindowObject
    {
        protected WindowsDriver<WindowsElement> session;

        public WindowObject(WindowsDriver<WindowsElement> driver)
        {
            session = driver;
        }

        protected internal WindowsElement Button(string name, SearchType searchType = SearchType.ByAutomationId)
        {
            WindowsElement element = null;
            switch (searchType)
            {
                case SearchType.ByAutomationId:
                    {
                        element = session.FindElementByAccessibilityId(name);
                    }
                    break;

                case SearchType.ByName:
                    {
                        element = session.FindElementByName(name);
                    }
                    break;

                case SearchType.ByXPath:
                    {
                        element = session.FindElementByXPath(name);
                    }
                    break;
            }
            return element;
        }

        protected internal WindowsElement TextBox(string name, SearchType searchType = SearchType.ByAutomationId)
        {
            WindowsElement element = null;
            switch (searchType)
            {
                case SearchType.ByAutomationId:
                    {
                        element = session.FindElementByAccessibilityId(name);
                    }
                    break;

                case SearchType.ByName:
                    {
                        element = session.FindElementByName(name);
                    }
                    break;

                case SearchType.ByXPath:
                    {
                        element = session.FindElementByXPath(name);
                    }
                    break;
            }
            return element;
        }
    }
}