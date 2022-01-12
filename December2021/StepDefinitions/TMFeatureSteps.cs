using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace December2021.StepDefinitions
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logeed into turnup portal successfully")]
        public void GivenILogeedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            
            loginPageObj.LoginSteps(driver);
        }
        
        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
   
            homePageObj.GoToTMPage(driver);
        }
        
        [When(@"I create a time and material record")]
        public void WhenICreateATimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            
            tmPageObj.CreateTM(driver);
        }
        
        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
           

            string actualCode = tmPageObj.GetCode(driver);
            string actualTypeCode = tmPageObj.GetTypeCode(driver);
            string actualDescription = tmPageObj.GetDescription(driver);
            string actualPrice = tmPageObj.GetPrice(driver);

            Assert.That(actualCode == "December2021", "Actual Code and expected code do not match.");
            Assert.That(actualTypeCode == "M", "Actual TypeCode and expected typecode do not match.");
            Assert.That(actualDescription == "December2021", "Actual Description and expected description do not match.");
            Assert.That(actualPrice == "$12.00", "Actual Price and expected price do not match.");
        }

        [When(@"I update '(.*)' an existing time and material record")]
        public void WhenIUpdateAnExistingTimeAndMaterialRecord(string p0)
        {
            
            tmPageObj.EditTM(driver, p0);
              
        }

        [Then(@"the record should have an updated '(.*)'")]
        public void ThenTheRecordShouldHaveAnUpdated(string p0)
        {
            string editedDescription = tmPageObj.GetEditedDescription(driver);

            Assert.That(editedDescription == p0, "Actual Description an expected description do not match.");
        }


    }
}
