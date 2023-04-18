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
    public class IndexViews
    {
        //Selenium driver
        protected IWebDriver driver;

        //Localizadores
        
        protected By nav = By.Name("nav");
        protected By home = By.Name("home");
        protected By text = By.Id("texto");
        protected By email = By.Id("email");
        public IndexViews(IWebDriver driver)
        {
            if (!driver.Title.Equals("Conversor de Unidades"))
            {
                throw new Exception("Esta no es la pagina principal");
            }
                
        }
        
       public bool NavIsPresent()
        {
            return WaitHandler.ElementIsPresent(driver, nav);
        }
        public bool EasyPresent()
        {
            return WaitHandler.ElementIsPresent(driver, nav);
        }
        public bool TextIspresent()
        {
            return WaitHandler.ElementIsPresent(driver, text);
        }
        public bool EmailIspresent()
        {
            return WaitHandler.ElementIsPresent(driver, email);
        }

        public void gotohome()
        {
            driver.FindElement(home).Click();

        }

    }
}
