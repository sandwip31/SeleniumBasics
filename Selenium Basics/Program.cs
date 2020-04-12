namespace Selenium_Basics
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            //initializing the web driver
            IWebDriver chromeDriver = new ChromeDriver();
            //browsing the website using URL
            chromeDriver.Navigate().GoToUrl("https://gmail.com");
            //searching for the textbox to enter username
            var userName = chromeDriver.FindElement(By.CssSelector("#identifierId"));
            //typing in the user name
            userName.SendKeys("<email address>");
            // clicking the next button to go to the password's page
            chromeDriver.FindElement(By.XPath("//div[@role='button']")).Click();
            //searching for the textbox to enter password
            var password = chromeDriver.FindElement(By.XPath("//input[@type='password']"), 100);
            //typing the password
            password.SendKeys("<password>");
            //selecting the checkbox in the email
            chromeDriver.FindElement(By.XPath("//div[@id='passwordNext']"), 2).Click();
            var checkBox = chromeDriver.FindElement(By.XPath("//div[@id=':31']"), 10);
            checkBox.Click();
            chromeDriver.Quit();
        }
    }
}
