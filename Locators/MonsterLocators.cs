using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAutomation_MonsterCreation.Locators
{
    public class MonsterLocators
    {
        /// <summary>
        /// set a number to add in the data-testid
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public By GetMonsterNumber(string number)
        {

            return By.CssSelector($"div[data-testid='monster-{number}']");
        }

        public By MonsterNameInput = By.CssSelector("div[data-testid='monster-name'] input[name='name']");
        public By MonsterHpInput = By.CssSelector("div[data-testid='hp-value'] input[name='hp']");
        public By MonsterAttackInput = By.CssSelector("div[data-testid='attack-value'] input[name='attack']");
        public By MonsterDefenseInput = By.CssSelector("div[data-testid='defense-value'] input[name='defense']");
        public By MonsterSpeedInput = By.CssSelector("div[data-testid='speed-value'] input[name='speed']");
        public By ButtonCreateMonster = By.CssSelector("button[data-testid='btn-create-monster']");
        public By MonsterCard = By.CssSelector("div[data-testid='monster-card']");
        public By CardName = By.CssSelector("p[data-testid='card-monster-name']");
        public By AlertInvalidvalues = By.CssSelector("div[data-testid='alert-required-fields']");
        public By IconFavorite = By.CssSelector("svg[data-testid='favorite-btn']");
        public By ButtonDeleteMonster = By.CssSelector("button[data-testid='btn-delete']");
        public By Dynamictext = By.CssSelector("p[data-testid='dynamic-title']");
    }
}
