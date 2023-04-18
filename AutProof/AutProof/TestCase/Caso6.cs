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
using AutProof.Handler;

namespace AutProof.TestCase
{
    [TestFixture]
    public class Caso6
    {
        protected IWebDriver Driver;
        

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Url = "C:\\Users\\user\\Documents\\SublimeText\\PagePF\\LenghtES.html";
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void ResIsPresent()
        {
            ConvertView conv = new ConvertView(Driver);
            Assert.IsTrue(conv.resIspresent());
            Thread.Sleep(2000);
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
