using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace December2021
{
    [TestFixture]
    [Parallelizable]
    class TM_Tests : CommonDriver
    {

        [Test, Order (1), Description("Check if user is able to create a Material record with valid data")]
        public void CreateTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order (2), Description("Check if user is able to edit a Material record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, "dummy");
        }

        [Test, Order (3), Description("Check if user is able to delete an existing Material record")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }


    }
}
