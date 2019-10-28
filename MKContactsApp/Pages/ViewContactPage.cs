using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace MKContactsApp.Pages
{
    class ViewContactPage
    {
        private AndroidDriver<AndroidElement> _androidDriver;

        public ViewContactPage(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;

        }

        // Find First Contact
        [FindsBy(How = How.Id, Using = "com.donato.contactsapp:id/text_title")]
        IWebElement btnViewContact { get; set; }

        //Find Mobile Lable
        [FindsBy(How = How.Id, Using = "com.donato.contactsapp:id/mobile_text")]
        IWebElement lblMobile { get; set; }

        //Check if mobile lable exists and throws an error if it doesnt. 
        // This will identify the 'Can't load contact' bug 
        public void CheckMobileLable()
        {                      
            try
            {
                 if (lblMobile.GetAttribute("text").Equals("Mobile"))
                {
                    Console.WriteLine("Successfully opened the contact");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to open the contact. Error is displayed");

            }
        }
    }
}
