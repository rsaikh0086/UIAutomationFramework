using OpenQA.Selenium;
using SeleniumAutomation.BL.Extensions;
using SeleniumAutomation.BL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.BL.Pages
{
    public class HomePage
    {
        IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        #region Locators
        Locator addElementButton =
            new Locator(By.XPath("//button[text()='Add Element']"),"'Add Element' button");
        Locator elementsAddedManually =
            new Locator(By.XPath("//button[@class='added-manually' and text()='Delete']"),
                "List of Elements Added");
        #endregion

        #region Elements
        public IWebElement AddElementButton => Driver.GetElement(addElementButton);
        public IList<IWebElement> LstManuallyAddedElements =>
                                    Driver.GetElements(elementsAddedManually);
        #endregion

        public void AddElement()
        {
            AddElementButton.Click();
        }
        public void AddNumberOfElements(int number)
        {
            for (int i = 0; i < number; i++)
            {
                AddElement();
            }
        }

        public double GetElementCount()
        {
            return LstManuallyAddedElements.Count;
        }
    }
}
