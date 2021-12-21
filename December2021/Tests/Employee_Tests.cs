using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace December2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {
            
        [Test, Order(1), Description("Check if user is able to create an Employee record with valid data")]
        public void CreateEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // TM page object initialization and definition
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit an Employee record with valid data")]
        public void EditEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // TM page object initialization and definition
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete an existing Employee record")]
        public void DeleteEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }
    }
}
