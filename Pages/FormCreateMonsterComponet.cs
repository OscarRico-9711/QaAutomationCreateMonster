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
    public class FormCreateMonsterComponet : CommonActions
    {

        private readonly MonsterLocators _locators;
        public FormCreateMonsterComponet(IWebDriver driver) : base(driver)
        {

            _locators = new MonsterLocators();

        }

        /// <summary>
        /// Method fills the monster's name
        /// </summary>
        /// <param name="text"></param>
        public void FillName(string text)
        {

            SendData(_locators.MonsterNameInput, text);

        }
        /// <summary>
        /// send the monster's hp
        /// </summary>
        /// <param name="text"></param>
        public void FillHp(string text)
        {

            SendData(_locators.MonsterHpInput, text);

        }

        /// <summary>
        /// fills the monster attack
        /// </summary>
        /// <param name="text"></param>
        public void FillAttack(string text)
        {

            SendData(_locators.MonsterAttackInput, text);

        }

        /// <summary>
        /// fills the monster defense
        /// </summary>
        /// <param name="text"></param>
        public void FillDefense(string text)
        {

            SendData(_locators.MonsterDefenseInput, text);

        }

        /// <summary>
        /// fills the speed
        /// </summary>
        /// <param name="text"></param>
        public void FillSpeed(string text)
        {

            SendData(_locators.MonsterSpeedInput, text);

        }

        /// <summary>
        /// Clicks the crate monster button
        /// </summary>
        public void ClickCreateMonsterButton()
        {

            ClickElement(_locators.ButtonCreateMonster);

        }

        /// <summary>
        /// validates the type of alert depending on the test
        /// </summary>
        /// <param name="text"></param>
        public void ValidateAlert(string text)
        {


            var Alert = _driver.FindElement(_locators.AlertInvalidvalues);

            Assert.That(Alert.Displayed);
            var AletText = Alert.Text;

            Assert.That(AletText, Is.EqualTo(text));


        }



    }
}
