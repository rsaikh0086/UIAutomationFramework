using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.BL.Utils
{
    public  class Locator
    {
        public By LocatorValue;
        public string Elementname;
        public Locator(By locator, string elementName) 
        {
            LocatorValue = locator;
            Elementname = elementName;
        }
    }
}
