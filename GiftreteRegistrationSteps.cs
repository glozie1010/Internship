using Intern1.Utility;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Intern1.StepDefinitions
{
    [Binding]
    public class GiftreteRegistrationSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.driver.Navigate().GoToUrl("https://www.giftrete.com");
        }
        
        [Given(@"I click on register")]
        public void GivenIClickOnRegister()
        {
            Hooks.driver.FindElement(By.LinkText("Register")).Click();
        }
        
        [Given(@"I input firstname")]
        public void GivenIInputFirstname()
        {
            Hooks.driver.FindElement(By.Id("first_name")).Click();
            Hooks.driver.FindElement(By.Id("first_name")).SendKeys("gloria");

        }

        [Given(@"I input lastname")]
        public void GivenIInputLastname()
        {
            Hooks.driver.FindElement(By.Id("last_name")).Click();
            Hooks.driver.FindElement(By.Id("last_name")).SendKeys("oziegbe");

        }

        [Given(@"I input email")]
        public void GivenIInputEmail()
        {
            Hooks.driver.FindElement(By.Id("email")).Click();
            Hooks.driver.FindElement(By.Id("email")).SendKeys("goziegbe@gmail.com");

        }

        [Given(@"I input  password")]
        public void GivenIInputPassword()
        {
            Hooks.driver.FindElement(By.CssSelector("#password")).Click();
            Hooks.driver.FindElement(By.CssSelector("#password")).SendKeys("gloria");

        }

        [Given(@"I input confirm password")]
        public void GivenIInputConfirmPassword()
        {
            Hooks.driver.FindElement(By.Id("confirm_password")).Click();
            Hooks.driver.FindElement(By.Id("confirm_password")).SendKeys("gloria");

        }

        [Given(@"I click on captcha")]
        public void GivenIClickOnCaptcha()
        {
            Hooks.driver.FindElement(By.XPath("//*[@id=\"recaptcha - anchor\"]/div[5]")).Click();
        }
        
        [Given(@"I input a wrong confirm password")]
        public void GivenIInputAWrongConfirmPassword()
        {
            Hooks.driver.FindElement(By.Id("confirm_password")).Click();
            Hooks.driver.FindElement(By.Id("confirm_password")).SendKeys("glogloria");

        }

        [When(@"I click sign up")]
        public void WhenIClickSignUp()
        {
            Hooks.driver.FindElement(By.XPath("//*[@id=\"signup - form\"]/div[7]/button")).Click();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
           
        }
        
        [Then(@"I should receive an error message")]
        public void ThenIShouldReceiveAnErrorMessage()
        {
           
        }
    }
}
