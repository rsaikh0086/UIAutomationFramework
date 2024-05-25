using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAutomation.BL.Utils;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.BL.Extensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement GetElement(
            this IWebDriver driver, Locator locator, int timeOut=30)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
                return wait.Until(ExpectedConditions.ElementToBeClickable(locator.LocatorValue));


            }
            catch (Exception)
            {
                throw new Exception(
                    $"Element '{locator.Elementname}' not found after '{timeOut}' seconds");
            }
                   
        }

        public static IList<IWebElement> GetElements(
            this IWebDriver driver, Locator locator, int timeOut = 30)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
                return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator.LocatorValue));


            }
            catch (Exception)
            {
                throw new Exception(
                    $"Elements '{locator.Elementname}' not found after '{timeOut}' seconds");
            }

        }
    }
}
