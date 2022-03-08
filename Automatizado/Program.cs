using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automatizado
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //Navegacion de la pagina

            driver.Navigate().GoToUrl("http://localhost/ProyectoSelenium/");

            //Seleccionar la marca del celular
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("MainContent_celulares")).SendKeys("Xiaomi");

            //Seleccionar la canticada de celulares
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("MainContent_cantidad")).SendKeys("3");

            //Seleccionar el metodo de pago
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("MainContent_efectivo")).Click();

            //Seleccionar Condicion del celular
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("MainContent_nuevo")).Click();

            //Seleccionar el boton de pago


            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.Id("MainContent_boton")).Click();
          

             
        }
    }
}
