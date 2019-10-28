using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MKContactsApp.Pages
{
    class ContactsListPage
    {
        AndroidDriver<AndroidElement> _androidDriver;

        public ContactsListPage(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;

        }

        // Find First Contact
        [FindsBy(How = How.Id, Using = "com.donato.contactsapp:id/text_title")]
        IWebElement btnFirstContact { get; set; }

        // Find Create New Button
        [FindsBy(How = How.Id, Using = "com.donato.contactsapp:id/fab")]
        IWebElement btnCreateNewContact { get; set; }

        //Click to view first contact
        public void ClickToViewContact()
        {
            _androidDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnFirstContact.Click();
            
        }
        
        //Create a new contact
        public void ClickCreateNewContact()
        {
            _androidDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnCreateNewContact.Click();

        }

        //Check if Create New button exists
        internal bool IsCreateNewContactExist()
        {
            _androidDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return btnCreateNewContact.Displayed;
        }
       
    }
}
