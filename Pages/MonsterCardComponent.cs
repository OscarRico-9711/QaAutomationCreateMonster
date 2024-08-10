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
    public class MonsterCardComponent : CommonActions
    {

        private readonly MonsterLocators _locators;
        public MonsterCardComponent(IWebDriver driver) : base(driver)
        {

            _locators = new MonsterLocators();

        }

        /// <summary>
        /// validate if the card element is present and has the same name to the test
        /// </summary>
        /// <param name="name"></param>
        public void ValidateCreatedMonster(string name)
        {

            var CardElemet = _driver.FindElement(_locators.MonsterCard);
            Assert.That(CardElemet.Displayed);


            var cardName = _driver.FindElement(_locators.CardName).Text;
            Assert.That(cardName, Is.EqualTo(name));

        }

        /// <summary>
        /// clicks the favorite icon
        /// </summary>
        public void ClickIconFavorite()
        {

            ClickElement(_locators.IconFavorite);

        }

        /// <summary>
        /// validates the iconfavorite color
        /// </summary>
        /// <param name="color"></param>
        public void ValidateIconColor(string color)
        {

            var Icon = _driver.FindElement(_locators.IconFavorite);
            Assert.That(Icon.Displayed);
            var iconColor = Icon.GetCssValue("fill");
            Assert.That(iconColor, Is.EqualTo(color));

        }

        /// <summary>
        /// clicks the delte monster button if it has the same name
        /// </summary>
        /// <param name="name"></param>
        public void DeleteMonster(string name) {

            var CardElement = _driver.FindElement(_locators.CardName);
            var CardNameText = CardElement.Text;

            if (CardNameText == name)
            {
                ClickElement(_locators.ButtonDeleteMonster);

            }


        }
    }
}
