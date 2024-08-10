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
    public class MonsterListComponent : CommonActions
    {
        private readonly MonsterLocators _locators;
        public MonsterListComponent(IWebDriver driver):base(driver) {

            _locators = new MonsterLocators();

        }

        /// <summary>
        /// selects a random monster image
        /// </summary>
        /// <param name="number"></param>
        public void SelectAMonsterImage(string number) {

            ClickElement(_locators.GetMonsterNumber(number));

        }
        
            
        

       



    }
}
