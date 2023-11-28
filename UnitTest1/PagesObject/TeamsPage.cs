using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.PagesObject
{
    public class TeamsPage
    {
        public readonly IWebElement EmpowerBotton;
        private ChromeDriver Driver;
        public TeamsPage(ChromeDriver driver)
        {
            Driver = driver;
            EmpowerBotton = Driver.FindElement(By.XPath("//button[.=' Empower your team ']"));
        }
    }
}
