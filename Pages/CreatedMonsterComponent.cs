using NUnit.Framework;
using OpenQA.Selenium;
using QaAutomation_MonsterCreation.Locators;
using QaAutomation_MonsterCreation.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAutomation_MonsterCreation.Pages
{
    public class CreatedMonsterComponent : CommonActions
    {

        private readonly MonsterLocators _locators;
        public CreatedMonsterComponent(IWebDriver driver) : base(driver)
        {

            _locators = new MonsterLocators();

        }

        /// <summary>
        /// Validates if the page has a specific text
        /// </summary>
        /// <param name="text"></param>
        public void ValidateDynamicText(string text)
        {

            var Alert = _driver.FindElement(_locators.Dynamictext);

            Assert.That(Alert.Displayed);

            var elementText = Alert.Text;

            Assert.That(elementText, Is.EqualTo(text));
        }





    }
}
