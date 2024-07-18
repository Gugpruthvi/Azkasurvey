using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azkapru.Core;
using Azkapru.Page;

namespace Azkapru.Tests
{

    public class BaseTest
    {
        protected UiHelpers uiHelpers;
        protected LoginPage loginPage;

        [TestInitialize]
        public void StartTest()
        {
            DriverContext.Startdriver("Chrome");
            uiHelpers = new UiHelpers();
            loginPage = new LoginPage();

        }
        [TestCleanup]
        public void CleanupTest()
        {
            Thread.Sleep(1000);
            DriverContext.driver.Quit();
        }

    }
}
