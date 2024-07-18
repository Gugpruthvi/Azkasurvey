using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azkapru.Core
{
    public class DriverContext
    {
        public static WebDriver driver;
        public static WebDriver Startdriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
            }
            return driver;
        }
    }
}
