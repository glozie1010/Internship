using Intern1.Utility;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Intern1.StepDefinitions
{
    [Binding]
    public class LogInSteps
    {
        [Given(@"I navigate to the url")]
        public void GivenINavigateToTheUrl()
        {
            Hooks.driver.Navigate().GoToUrl("https://www.giftrete.com");
        }
        
        [Given(@"I click on log in")]
        public void GivenIClickOnLogIn()
        {
            Hooks.driver.FindElement(By.LinkText("Login")).Click();
        }
        
        [Given(@"I input my username")]
        public void GivenIInputMyUsername()
        {
            Hooks.driver.FindElement(By.Id("email")).Click();
            Hooks.driver.FindElement(By.Id("email")).SendKeys("goziegbe@gmail.com");

        }

        [Given(@"I input my password")]
        public void GivenIInputMyPassword()
        {
            Hooks.driver.FindElement(By.Id("password"));
            Hooks.driver.FindElement(By.Id("password")).SendKeys("oziegbe");

        }

        [Given(@"I click on login")]
        public void GivenIClickOnLogin()
        {
            Hooks.driver.FindElement(By.XPath("//*[@id=\"login-form\"]/div[4]/button")).Click();
           

        }

        [Given(@"I input my invalid password")]
        public void GivenIInputMyInvalidPassword()
        {
            Hooks.driver.FindElement(By.Id("password"));
            Hooks.driver.FindElement(By.Id("password")).SendKeys("oziegbe1");
        }
        
        [When(@"I click on log in")]
        public void WhenIClickOnLogIn()
        {
            Hooks.driver.FindElement(By.XPath("//*[@id=\"login-form\"]/div[4]/button")).Click();
        }
        
        [Then(@"I should be taken to my profile page")]
        public void ThenIShouldBeTakenToMyProfilePage()
        {
            Hooks.driver.Close();
        }
        
        [Then(@"I should be given an error message")]
        public void ThenIShouldBeGivenAnErrorMessage()
        {
            
        }
    }
}
