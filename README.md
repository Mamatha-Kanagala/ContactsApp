# ContactsApp
Prereqs to run the code:
    - Visual studio (I have used Visual Studio 2017)
    - Appium Server must be running
    - Your virtual device must be running
   

1. Download the code
2. Open the solution in Visual Studio 
3. Open AppiumUtilities class - Open InitializeAndrioidApp method and update the .apk path under desirede capablities to the location where your apk file exists. 
4. Under desired capabalities (deviceName) I used a virtual device called 'My device' in my code. Please update this to your device name.
5. Make sure Appium is runnig. At BigHand, we had plans to start the appium server from the code itself but havent had a chance to do that yet. So, skipped that part.

Notes: 
I have created the framework with Speckflow that we use at BigHand. After creating the framework, i only had time to write 2 tests with in the given time. 
1. SystemPermissions.feature - Will test if the user can allow the permissions to the app.
2. ViewContacts.feature - This will test if the user can view contact. 
3. AddNewContact.feature -  Havent had a chance to finish this test.
 
