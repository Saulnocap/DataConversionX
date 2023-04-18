using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace AutProof
{
    class Program
    {
        static void Mani(string[] args)
        {
            //Initializer
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Url = "C:\\Users\\user\\Documents\\SublimeText\\PagePF\\IndexES.html";
            webdriver.Manage().Window.Maximize();
            
        }
    }

}
