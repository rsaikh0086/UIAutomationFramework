using BoDi;
using Gherkin.CucumberMessages.Types;
using OpenQA.Selenium;
using SeleniumAutomation.Tests.TestManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumAutomation.Tests.StepDefinitions
{
    public class BaseStep:Steps
    {
        IObjectContainer ObjectContainer;
        ScenarioContext ScenarioContext;
        protected IWebDriver Driver;
        public BaseStep(IObjectContainer container, ScenarioContext scenarioContext)
        {  
            ObjectContainer = container;
            ScenarioContext = scenarioContext;
            Driver = container.Resolve<IWebDriver>();
        }
    }
}
