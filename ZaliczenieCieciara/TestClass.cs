// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ZaliczenieCieciara.BaseClass;

namespace ZaliczenieCieciara
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        private void RegisterForm()
        {
            IWebElement registerButton = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            registerButton.Click();
            Thread.Sleep(500);
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            this.RegisterForm();
            IWebElement month = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(month);
            element.SelectByIndex(0);
            element.SelectByText("Feb");
            element.SelectByValue("3");
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
    }
}
