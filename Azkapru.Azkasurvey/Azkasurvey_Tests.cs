using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Azkapru.Core;
using Azkapru.Tests;
namespace Azkapru.Azkasurvey
{
    [TestClass]
    public class Azkasurvey_Tests : BaseTest
    {
        [TestMethod]
        public void VerifyThatUserCanFillTheDetailsInLoginPage()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Entername("pruthvi");
            loginPage.Enterpassword("rMmGPja");
            loginPage.Clickloginpage();
        }
    }
}