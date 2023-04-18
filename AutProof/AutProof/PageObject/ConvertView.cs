using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using AutProof.Handler;


namespace AutProof.PageObject
{
    public class ConvertView
    {
        protected IWebDriver driver;
        //Localizadores
        protected By unit1 = By.Id("unidad1");
        protected By value = By.CssSelector("#valueto");
        protected By res = By.Id("resultado1");

        public ConvertView(IWebDriver driver)
        {
            if (!driver.Title.Equals("Conversor de Longitudes"))
            {
                throw new Exception("Esta no es la pagina de conversion de longitud");
            }
        }

        public bool LenghtIsPresent()
        {
            return WaitHandler.ElementIsPresent(driver, unit1);
        }

        public bool resIspresent()
        {
            return WaitHandler.ElementIsPresent(driver, res);
        }

        #region caso3

        public void valor(string a)
        {
            driver.FindElement(value).SendKeys(a);
        }

        #endregion

    }
}
