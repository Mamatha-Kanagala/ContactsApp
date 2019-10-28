using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKContactsApp.Utilities
{
    public class AppiumUtilities
    {
        
        public AndroidDriver<AndroidElement> InitializeAndrioidApp()
        {
            AppiumOptions desktopCapabilities = new AppiumOptions();

            // Desired capababilities 

            desktopCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            desktopCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "My Device");
            desktopCapabilities.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\mamra\\Downloads\\Contacts\\app-debug.apk");
            desktopCapabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.donato.contactsapp");
            desktopCapabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.donato.contactsapp.ui.list.view.ContactListActivity");

            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), desktopCapabilities);
            return androidDriver;
        }
              
    }
}
