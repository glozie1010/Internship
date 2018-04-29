using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Intern1.Utility
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {

            driver=new ChromeDriver();
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
