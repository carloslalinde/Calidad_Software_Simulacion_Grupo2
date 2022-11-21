using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParallelTestingGrupo2
{
    [TestFixture]
    [Parallelizable]
    public class Test : Base
    {
        [Test]
        public void PruebaLoginIncorrecto()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
            driver.FindElement(By.Name("USERNAME")).SendKeys("Test");
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(5000);

        }


        [TestFixture]
        [Parallelizable]
        public class Test2 : Base
        {
            [Test]
            public void PruebaCorrecto()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test3 : Base
        {
            [Test]
            public void PruebaOlvideContraseña()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("forgot")).Click();
                driver.FindElement(By.Name("USERNAME")).SendKeys("test123");
                driver.FindElement(By.Name("send")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }


        [TestFixture]
        [Parallelizable]
        public class Test4 : Base
        {
            [Test]
            public void PruebaNavegacion()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("inventario")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver inventario")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }


    }

}
