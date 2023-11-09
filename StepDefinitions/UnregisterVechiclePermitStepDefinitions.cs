using MsTestDemoProject.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MsTestDemoProject.StepDefinitions
{
    [Binding]
    public class UnregisterVechiclePermitStepDefinitions
    {
        private IWebDriver driver;
        UVP_step1_PageObjects uVP_Step1;
        
        public UnregisterVechiclePermitStepDefinitions(IWebDriver driver, UVP_step1_PageObjects uVP_Step1)
        {
            this.driver = driver;
            this.uVP_Step1 = uVP_Step1;

        }

        [Given(@"Navigate to vic road register vehicle page '([^']*)'")]
        public void GivenNavigateToVicRoadRegisterVehiclePage(string url)
        {
            UVP_step1_PageObjects uVP_Step1 = new UVP_step1_PageObjects(driver);
           uVP_Step1.navigateToURL(url);
        }

        [When(@"Enter vehicle detail '([^']*)','([^']*)','([^']*)','([^']*)' and click on Next")]
        public void WhenEnterVehicleDetailAndClickOnNext(string vehicle, string vehicleType, string date, string NumberOfDays)
        {
            uVP_Step1.enterDetails(vehicle,vehicleType,date, NumberOfDays);
        }

        [Then(@"Click on Calculate ,validate the amount '([^']*)' and Click on Next")]
        public void ThenClickOnCalculateValidateTheAmountAndClickOnNext(string amount)
        {
            uVP_Step1.calculateAmount(amount);
        }


        [Then(@"Validate the Select permit type” is displayed")]
        public void ThenValidateTheSelectPermitTypeIsDisplayed()
        {
            uVP_Step1.ValidatePermitTypeDisplayed();
        }
    }
}
