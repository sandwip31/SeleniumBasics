using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Basics
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                for (int i = 0; i < timeoutInSeconds * 1000; i++)
                {
                    try
                    {
                        bool isFieldDisplayed = driver.FindElement(by).Displayed;
                        if (isFieldDisplayed)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(1);
                        }
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(1);
                    }
                }
            }
            return driver.FindElement(by);
        }
    }
}
