using CalculatorProject.Logic.WindowsObjects;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace CalculatorProject.Logic
{
    public static class Windows
    {
        public static ICalculatorView Launch()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            OpenQA.Selenium.Appium.AppiumOptions options = new OpenQA.Selenium.Appium.AppiumOptions();
            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("platformName", "Windows");
            var session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return new CalculatorView(session);
        }
    }
}