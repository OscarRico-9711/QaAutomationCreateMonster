using OpenQA.Selenium;
using QaAutomation_MonsterCreation.Drivers;
using QaAutomation_MonsterCreation.Pages;
using QaAutomation_MonsterCreation.Support;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace QaAutomation_MonsterCreation.StepDefinitions
{
    [Binding]
    public class MonsterSteps
    {

        private readonly CommonActions _commonActions;
        private readonly MonsterListComponent _monsterListComponent;
        private readonly FormCreateMonsterComponet _formCreateMonsterComponet;
        private readonly MonsterCardComponent _monsterCardComponent;
        private readonly CreatedMonsterComponent _createdMonsterComponent;


        public MonsterSteps()
        {
            _commonActions = new CommonActions(DriverConfig.driver);
            _monsterListComponent = new MonsterListComponent(DriverConfig.driver);
            _formCreateMonsterComponet = new FormCreateMonsterComponet(DriverConfig.driver);
            _monsterCardComponent = new MonsterCardComponent(DriverConfig.driver);
            _createdMonsterComponent = new CreatedMonsterComponent(DriverConfig.driver);

        }


        [Given(@"the user is on the url ""([^""]*)""")]
        public void GivenTheUserIsOnTheUrl(string url)
        {
            _commonActions.OpenBrowser(url);
        }

        [When(@"the user selects a monster option ""([^""]*)""")]
        public void WhenTheUserSelectsAMonsterOption(string number)
        {
            _monsterListComponent.SelectAMonsterImage(number);
        }

        [When(@"the user fills the monster name with ""([^""]*)""")]
        public void WhenTheUserFillsTheMonsterNameWith(string name)
        {
            _formCreateMonsterComponet.FillName(name);
        }

        [When(@"the user fills the monster hp with ""([^""]*)""")]
        public void WhenTheUserFillsTheMonsterHpWith(string hp)
        {
            _formCreateMonsterComponet.FillHp(hp);
        }

        [When(@"the user fills the monster attack with ""([^""]*)""")]
        public void WhenTheUserFillsTheMonsterAttackWith(string attack)
        {
            _formCreateMonsterComponet.FillAttack(attack);
        }

        [When(@"the user fills the monster defense with ""([^""]*)""")]
        public void WhenTheUserFillsTheMonsterDefenseWith(string defense)
        {
            _formCreateMonsterComponet.FillDefense(defense);
        }

        [When(@"the user fills the monster speed with ""([^""]*)""")]
        public void WhenTheUserFillsTheMonsterSpeedWith(string speed)
        {
            _formCreateMonsterComponet.FillSpeed(speed);
        }

        [When(@"the user clicks the create monster button")]
        public void WhenTheUserClicksTheCreateMonsterButton()
        {
            _formCreateMonsterComponet.ClickCreateMonsterButton();
        }

        [Then(@"the monster should be created with the name ""([^""]*)""")]
        public void ThenTheMonsterShouldBeCreatedWithTheName(string name)
        {
            _monsterCardComponent.ValidateCreatedMonster(name);
        }

        [Then(@"alert with the text ""([^""]*)"" should be displayed")]
        public void ThenAlertWithTheTextShouldBeDisplayed(string text)
        {
            _formCreateMonsterComponet.ValidateAlert(text);
        }

        [When(@"the user selects the icon favorite")]
        public void WhenTheUserSelectsTheIconFavorite()
        {
            _monsterCardComponent.ClickIconFavorite();
        }

        [Then(@"the icon must have the color ""([^""]*)""")]
        public void ThenTheIconMustHaveTheColor(string color)
        {
            _monsterCardComponent.ValidateIconColor(color);
        }


        [When(@"the user deletes the monster ""([^""]*)""")]
        public void WhenTheUserDeletesTheMonster(string dante)
        {
            _monsterCardComponent.DeleteMonster(dante);
        }

        [When(@"the text ""([^""]*)"" should be displayed")]
        public void WhenTheTextShouldBeDisplayed(string text)
        {
            _createdMonsterComponent.ValidateDynamicText(text);
        }




    }
}
