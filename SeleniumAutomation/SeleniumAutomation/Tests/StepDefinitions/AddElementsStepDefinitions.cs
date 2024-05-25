using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutomation.BL.Pages;
using SeleniumAutomation.Tests.StepDefinitions;
using System;
using TechTalk.SpecFlow;

namespace SeleniumAutomation
{
    [Binding]
    public class AddElementsStepDefinitions:BaseStep
    {

        public AddElementsStepDefinitions(IObjectContainer container, ScenarioContext scenarioContext) :
            base(container, scenarioContext)
        {

        }
        
        [When(@"I add (.*) elements")]
        public void WhenIAddElements(int number)
        {
            new HomePage(Driver).AddNumberOfElements(number);
        }

        [Then(@"(.*) elements should be created")]
        public void ThenElementsShouldBeCreated(int number)
        {
            Assert.AreEqual(number, new HomePage(Driver).GetElementCount());
        }
    }
}
