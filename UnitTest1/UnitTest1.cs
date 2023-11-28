using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;
using UnitTest1.PagesObject;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace UnitTest1
{
    public class Tests
    {
        public ChromeDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }

        [Test]
        public void Test1()
        {
            // 1. Open browser
            // 2. Open page https://stackoverflow.com/
            Driver.Navigate().GoToUrl("https://stackoverflow.com/");

            
            var HomePage = new HomePage(Driver);


            // 3. Click butten "Discower teams".

            HomePage.DiscoveryTeamsButton.Click();
            var TeamsPage = new TeamsPage(Driver);

            // 4. Button "DiscowerEmpower your teams" is not displayedvisible.

            Assert.IsTrue(TeamsPage.EmpowerBotton.Displayed, "Teams botton is not visible.");

            // 5. Click button "Empower your teams".

            TeamsPage.EmpowerBotton.Click();
            var popUp = new PopUp(Driver);
            System.Threading.Thread.Sleep(1000);
            Assert.IsTrue(popUp.EmployerYourTeamButton.Displayed, "PopUp botton is not visible.");
        }

        public void WaitForVisible(IWebElement locator)
        {
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(Driver, System.TimeSpan.FromSeconds(102));
            wait.Until(ElementIsVisible((By)locator));
        }
    }
}