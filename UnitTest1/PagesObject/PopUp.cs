using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.PagesObject
{
    public class PopUp
    {    
        public readonly IWebElement EmployerYourTeamButton;
        private ChromeDriver Driver;
        public PopUp(ChromeDriver driver)
        {
            Driver = driver;
            EmployerYourTeamButton = Driver.FindElement(By.XPath("//button[.=' Empower your team ']"));
        }
    }
}
