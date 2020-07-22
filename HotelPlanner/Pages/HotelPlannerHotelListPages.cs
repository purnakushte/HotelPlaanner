using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System.IO;

namespace HotelPlanner.Pages
{
    public class HotelPlannerHotelListPages
    {
        public IWebDriver Driver;

        public HotelPlannerHotelListPages(IWebDriver Browse)
        {
            Driver = Browse;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement HotelDealslink;

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement Whereareyougoinglink;

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement datefield;

        //[FindsBy(How = How.ClassName, Using = "")]
        //public DatePicker datePicker;

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement curDate;

        [FindsBy(How = How.ClassName, Using = "")]
        public List<IWebElement> dates;

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement Roomslink;

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement Findhotelslink;

        [FindsBy(How = How.ClassName, Using = "")]
        public IWebElement Pageloadlink;

        string dateFormat = "dd MMM yyyy";  

        public void Navigatelink()
        {
            Driver.Navigate().GoToUrl("https://www.hotelplanner.com/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void SelecttheCity()
        {
            SelectElement Distance = new SelectElement(Driver.FindElement(By.Id("destination")));
            Distance.SelectByText("Mexico");
            System.Threading.Thread.Sleep(5000);
            //IWebElement dropDrownListBox = Driver.FindElement(By.Id("destination"));
            //SelectElement ClickThis = new SelectElement(dropDrownListBox);
            //ClickThis.SelectByText("Mexico");
        }
        public void getDatePicker()
        {
            dat

            
        }

    }
}
