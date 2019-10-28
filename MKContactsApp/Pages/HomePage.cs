using MKContactsApp.Hooks;
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
    class HomePage 
    {
        //local variable 
        AndroidDriver<AndroidElement>  _androidDriver;

        public HomePage(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;
        }

        // Find Allow button by Id
        [FindsBy(How = How.Id, Using = "com.android.packageinstaller:id/permission_allow_button")]
        IWebElement btnAllow { get; set; }

        // Find deny button by Id
        [FindsBy(How = How.Id, Using = "com.android.packageinstaller:id/permission_deny_button")]
        IWebElement btnDeny { get; set; }

        // Find No permission button by Id
        [FindsBy(How = How.Id, Using = "android:id/button1")]
        IWebElement lblNoPermission { get; set; }

        //Click Allow button
        public ContactsListPage ClickAllow()
        {
            btnAllow.Click();
            return new ContactsListPage(_androidDriver);
        }

        //Click Deny button
        public ContactsListPage ClickDeny()
        {
            btnDeny.Click();
            return new ContactsListPage(_androidDriver);
        }

        //Check if No permission window is displayed
        internal bool IsNoPermissionWindowExist()
        {
            return lblNoPermission.Displayed;
        }


    }
}
