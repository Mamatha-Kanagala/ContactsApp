using MKContactsApp.Hooks;
using MKContactsApp.Pages;
using MKContactsApp.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MKContactsApp.Steps
{
    [Binding]
    class SystemPermissions 
    {
        
        private ContactsListPage ContactListPage = null;
        HomePage page = new HomePage((AndroidDriver<AndroidElement>)ScenarioContext.Current["andriotContext"]);

        [Given(@"I have launched the application")]
        public void GivenIHaveLaunchedTheApplication()
        {
           // Test Intializer is doing this
        }

        [When(@"I press allow")]
        public void WhenIPressAllow()
        {
            ContactListPage = page.ClickAllow();
        }

        [Then(@"I see the Contacts List Page")]
        public void ThenISeeTheContactsListPage()
        {
          
           Assert.That(ContactListPage.IsCreateNewContactExist(), Is.True, "the button does  not exist");
        }
                
    }
}
