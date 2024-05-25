using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumAutomation.Tests.TestManagers
{
    [Binding]
    public sealed class TestControlerHooks
    {
        IWebDriver Driver = null;
        ScenarioContext ScenarioContext;
        IObjectContainer Container = null;

        public TestControlerHooks(IObjectContainer objectContainer, ScenarioContext scenarioContext) 
        {
            Container = objectContainer;
           ScenarioContext= scenarioContext;
        }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            if (Driver is null)
            {
                Driver = new ChromeDriver();
            }
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
            Driver.Manage().Window.Maximize();
            Container.RegisterInstanceAs(Driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
            Driver=null;
        }
    }
}