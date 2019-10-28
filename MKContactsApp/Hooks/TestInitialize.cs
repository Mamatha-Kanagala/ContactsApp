using MKContactsApp.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MKContactsApp.Hooks
{
    [Binding]
    public class TestInitialize
    {
        public AndroidDriver<AndroidElement> AndroidContext;

        // Intializing the Android driver 
        [BeforeScenario]
        public void IntializeTest()
        {
            AppiumUtilities au = new AppiumUtilities();
           AndroidContext = au.InitializeAndrioidApp();
           ScenarioContext.Current["andriotContext"] = AndroidContext;
        }

        //Closing the android driver
        [AfterScenario]
        public void CleanUp()
        {
            AndroidContext.Dispose();
        } 
    }
}
