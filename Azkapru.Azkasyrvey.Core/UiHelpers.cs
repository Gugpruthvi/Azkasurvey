using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azkapru.Core
{
    public class UiHelpers
    {
        public void NavigateToUrl()
        {
            DriverContext.driver.Navigate().GoToUrl("https://www.azkasurvey.com/login");
            DriverContext.driver.Manage().Window.Maximize();
        }


    }
}
