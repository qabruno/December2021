using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace December2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // indetify the password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            // check if user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

            // Create Time and Material record

            // Go to TM page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

            // Click on Create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select Material from TypeCode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();

            // Identify the Code textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("December2021");

            // Identify the Description textbox and input a description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("December2021");

            // Identify the Price textbox and input a price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            // check if record created is present in the table and has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if(actualCode.Text == "December2021")
            {
                Console.WriteLine("Material record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }



        }
    }
}
