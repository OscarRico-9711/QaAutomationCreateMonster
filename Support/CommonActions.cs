using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAutomation_MonsterCreation.Support
{
    public class CommonActions
    {

        protected readonly IWebDriver _driver;

        public CommonActions(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Open URL in browser
        /// </summary>
        /// <param name="url"></param>
        public void OpenBrowser(string url)
        {
            _driver.Navigate().GoToUrl(url);    
        }

        /// <summary>
        /// method Clicks element in the browser
        /// </summary>
        /// <param name="locator"></param>
        public void ClickElement(By locator) { 
        
            _driver.FindElement(locator).Click();           
        }


        /// <summary>
        /// this method sends the text that you have in the feature
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public void SendData(By locator, string text) {

            _driver.FindElement(locator).SendKeys(text);
        }



    }
}
