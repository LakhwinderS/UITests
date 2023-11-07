using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MsTestDemoProject.PageObjects
{
    public class UVP_step1_PageObjects
    {
        private readonly IWebDriver _driver;
    

        public UVP_step1_PageObjects(IWebDriver driver)
        {
           _driver = driver;
        }
        public IWebElement vehicle => _driver.FindElement(By.XPath("//label[text()='Vehicle type ']/following-sibling::span/span/Select"));
        public IWebElement vehicleType => _driver.FindElement(By.XPath("//label[contains(text(),'Passenger')]/following-sibling::span/span/Select"));

        public IWebElement Address => _driver.FindElement(By.XPath("//label[contains(text(),'Address where')]/following-sibling::input"));
        public IWebElement permitDuration => _driver.FindElement(By.XPath("//label[contains(text(),'Permit Duration')]/following-sibling::span/span/select"));
        public IWebElement nextButton => _driver.FindElement(By.XPath("//input[@value=\"Next\"]"));
        public IWebElement selectPermitType => _driver.FindElement(By.XPath("//p[contains(text(),' Select permit type')]"));


        public void navigateToURL(string url)
        {
            _driver.Url = url;

        }
        public void enterDetails(string details, string vehicleTyp, string NumberOfDays, string date )
        {
            _driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", vehicle);
        
            var selectVehicle = new SelectElement(vehicle);
            selectVehicle.SelectByValue(details);

            
            var selectVehicleType = new SelectElement(vehicleType);
            selectVehicleType.SelectByValue(vehicleTyp);
            Address.SendKeys("10 Kent Road Lalor VIC 3075");
         
            var selectPermitDuration = new SelectElement(permitDuration);
            selectPermitDuration.SelectByValue(NumberOfDays);
            Thread.Sleep(5000);
            nextButton.Click();





        }
        public void ValidatePermitTypeDisplayed()

        {
        
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(driver => selectPermitType);
            Assert.IsTrue(selectPermitType.Displayed);
            
        }
        
    }
}
