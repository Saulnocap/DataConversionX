﻿using AutProof.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AutProof.TestCase
{
    [TestFixture]
    public class Caso1
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Url = "C:\\Users\\user\\Documents\\SublimeText\\PagePF\\IndexES.html";
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void NavigationBar()
        {
            IndexViews navbar = new IndexViews(Driver);
            Assert.IsTrue(navbar.NavIsPresent());
            Thread.Sleep(3000);
        }

        [Test]
        public void NavigationBarFunctions()
        {
            IndexViews navbar = new IndexViews(Driver);
            IWebElement home = Driver.FindElement(By.Id("home"));
            IWebElement about = Driver.FindElement(By.Id("about"));
            IWebElement conversor = Driver.FindElement(By.Id("convert"));
            about.Click();
            home.Click();
            conversor.Click();

            Assert.Pass();
        }

        [TearDown]
        public void AfterTest()
        {
            if(Driver != null)
            {
                Driver.Quit();
            }
        }
        

    }
}
