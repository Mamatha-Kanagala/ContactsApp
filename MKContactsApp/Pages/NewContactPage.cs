using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKContactsApp.Pages
{
    class NewContactPage
    {
        //local variable 
        AndroidDriver<AndroidElement> _androidDriver;

        public NewContactPage(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;
        }

        // Find ADD contact icon by Id
        [FindsBy(How = How.Id, Using = "com.donato.contactsapp:id/fab")]
        IWebElement btnCreateNew { get; set; }

        //Click on Add
        public void CreateNewContact()
        {
            btnCreateNew.Click();
        }
    }
}
