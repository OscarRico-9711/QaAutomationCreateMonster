using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace QaAutomation_MonsterCreation.Drivers
{
    [Binding]
    internal class DriverConfig
    {
        public static IWebDriver driver;


        [BeforeScenario]
        public void InitializeDriver() { 
        
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [AfterScenario]
        public void CleanupDriver()
        {
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}
