using AutProof.PageObject;
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
    public class Caso10
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
        public void Git()
        {
            IWebElement git = Driver.FindElement(By.Id("togit"));
            git.Click();
            Thread.Sleep(10000);
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
