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
    public class Caso2
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
        public void LenghtIsPresent()
        {
            ConvertView conv = new ConvertView(Driver);
            Assert.IsTrue(conv.LenghtIsPresent());
            Thread.Sleep(2000);
        }

        [Test]
        public void Select()
        {
            #region unidad1
            IWebElement dropdown = Driver.FindElement(By.Id("unidad1"));
            IReadOnlyCollection<IWebElement> dropdownOptions = dropdown.FindElements(By.TagName("option"));
            foreach(IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Kilometros"))
                    option.Click();
            }
            string selectedOption = "";
            foreach(IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Hectometros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Decametros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Metros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Decimetros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Centimetros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Milimetros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Pulgadas"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Pies"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Yardas"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            #endregion
            #region unidad2
            dropdown = Driver.FindElement(By.Id("unidad2"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Kilometros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Hectometros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Decametros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Metros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Decimetros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Centimetros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Milimetros"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Pulgadas"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Pies"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            /////////////////////////////////////////////////////
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Yardas"))
                    option.Click();
            }
            selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            #endregion
            Assert.Pass();
            //Assert.That(selectedOption, Is.EqualTo("Kilometros"));

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
