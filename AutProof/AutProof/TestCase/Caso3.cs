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
    public class Caso3
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
        public void Sucesiones()
        {
            ConvertView conv = new ConvertView(Driver);
            IWebElement input = Driver.FindElement(By.Id("valor1"));

            #region Sucesiones kilometros
            IWebElement dropdown = Driver.FindElement(By.Id("unidad1"));
            IReadOnlyCollection<IWebElement> dropdownOptions = dropdown.FindElements(By.TagName("option"));
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Kilometros"))
                    option.Click();
            }
            string selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Hectometros
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1"); 
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Decametros
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Metros
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Decimetros
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Centimetros
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Milimetros
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Pulgadas
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Pies
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            #region Sucesiones Yardas
            dropdown = Driver.FindElement(By.Id("unidad1"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
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
            input.SendKeys("1");
            Thread.Sleep(2000);
            input.Clear();
            #endregion

            Assert.Pass();
            //Assert.That(selectedOption, Is.EqualTo("Kilometros"));

        }

        [Test]
        public void valornegativo()
        {
            IWebElement input = Driver.FindElement(By.Id("valor1"));
            IWebElement dropdown = Driver.FindElement(By.Id("unidad1"));
            IReadOnlyCollection<IWebElement> dropdownOptions = dropdown.FindElements(By.TagName("option"));
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Text.Equals("Kilometros"))
                    option.Click();
            }
            string selectedOption = "";
            foreach (IWebElement option in dropdownOptions)
            {
                if (option.Selected)
                    selectedOption = option.Text;
            }
            dropdown = Driver.FindElement(By.Id("unidad2"));
            dropdownOptions = dropdown.FindElements(By.TagName("option"));
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
            input.SendKeys("-1");
            Thread.Sleep(5000);
            input.Clear();
            Thread.Sleep(5000);
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
