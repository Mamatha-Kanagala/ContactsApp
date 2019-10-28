using MKContactsApp.Pages;
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
    class ViewContacts
    {

        private ContactsListPage ContactListPage = null;
       HomePage homePage = new HomePage((AndroidDriver<AndroidElement>)ScenarioContext.Current["andriotContext"]);
      

        [Given(@"I am on the Contacts List page")]
        public void GivenIAmOnTheContactsListPage()
        {
           ContactListPage = homePage.ClickAllow();                      
            
        }

        [When(@"I press on a Contact")]
        public void WhenIPressOnAContact()
        {
             ContactListPage.ClickToViewContact();
        }

        [Then(@"I see the Contact Info page")]
        public void ThenISeeTheContactInfoPage()
        {
            ViewContactPage Viewpage = new ViewContactPage((AndroidDriver<AndroidElement>)ScenarioContext.Current["andriotContext"]);
            Viewpage.CheckMobileLable();

        }

    }
}
