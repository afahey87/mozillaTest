using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace mozillaTest
{
    [TestFixture]
    class mozillaTest
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mozilla.org");
        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
            driver.Quit();
        }
        
        [Test]
        public void checkPageIsUp ()
        {
            Assert.True(driver.Url.Contains("US"));
        }

        [Test]
        public void internetHealthReport()
        {
            driver.FindElement(By.Id("nethealth")).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.True(driver.Url.Contains("https://internethealthreport.org/"));
            driver.FindElement(By.XPath("/html/body/div[1]/main/div/div[2]/div[1]/a[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            Assert.True(driver.Url.Contains("https://internethealthreport.org/v01/"));
        }

    }
    


}
