﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern1.PageObjects
{
    class Homepage
    {
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement LoginButton;
        public void ClickOnLoginbutton()
        {
            LoginButton.Click();
        }
    }
}
