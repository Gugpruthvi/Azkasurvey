using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azkapru.Core;
using OpenQA.Selenium.DevTools.V124.WebAuthn;

namespace Azkapru.Page
{
    public class LoginPage
    {
        IWebElement entername => DriverContext.driver.FindElement(By.XPath("//input[@type='text']"));
        IWebElement enterpassword => DriverContext.driver.FindElement(By.XPath(" //input[@type='password']"));
        IWebElement clickloginpage => DriverContext.driver.FindElement(By.XPath("//button[@type='submit']"));

        public void Entername(String name)
        {
            entername.SendKeys(name);
        }
        public void Enterpassword(String password)
        {
            enterpassword.SendKeys(password);
        }
        public void Clickloginpage()
        {
            clickloginpage.Click();
        }







    }
}
