﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ZaliczenieCieciara.BaseClass;
using ZaliczenieCieciara.Utilities;

namespace ZaliczenieCieciara
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;


        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Parralerl test");
            Driver.Quit();
        }
    }
}