using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ZaliczenieCieciara.BaseClass
{

    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://facebook.com/";

            /*accepting cookies*/
            IWebElement buttonCookies =  driver.FindElement(By.XPath(".//*[@data-cookiebanner='accept_button']"));
            buttonCookies.Click();
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
