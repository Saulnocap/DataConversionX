using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutProof.PageObject;
using System.Threading;

namespace AutProof.TestCase
{
    [TestFixture]
    public class Caso4
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
        public void EasyTasks()
        {
            IndexViews n = new IndexViews(Driver);
            Thread.Sleep(2000);
            Assert.IsTrue(n.EasyPresent());
        }

        [TearDown]
        public void AfterTest()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}
