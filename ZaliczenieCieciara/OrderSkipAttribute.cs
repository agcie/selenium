// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using ZaliczenieCieciara.BaseClass;

namespace ZaliczenieCieciara
{
    [TestFixture]
    public class OrderSkipAttribute
    {
 
        [Test,Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Order skip attribute test");
            driver.Quit();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            Assert.Ignore("Problem with IE on my computer");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Order skip attribute test");
            driver.Quit();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            Assert.Ignore("Problem with Firefox on my computer");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Order skip attribute test");
            driver.Quit();
        }
    }
}
