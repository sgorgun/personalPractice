using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.PagesObject
{
    internal class HomePage
    {
        public readonly IWebElement DiscoveryTeamsButton;

        private ChromeDriver Driver;
        public HomePage(ChromeDriver driver)
        {
            Driver = driver;
            DiscoveryTeamsButton = Driver.FindElement(By.XPath("//a[@href='https://stackoverflow.co/teams/'][.='Discover Teams']"));
        }
    }
}
