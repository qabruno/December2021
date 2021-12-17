using December2021.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace December2021
{
    class TM_Tests
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

            // Edit TM
            tmPageObj.EditTM(driver);

            // Delete TM
            tmPageObj.DeleteTM(driver);
            





        }
    }
}
