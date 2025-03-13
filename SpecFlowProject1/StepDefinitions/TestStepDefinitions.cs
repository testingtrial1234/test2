using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestStepDefinitions
    {
        private IWebDriver _driver;
        private Uri GridUrl;
        [Given(@"I launch docker grid")]
        public void GivenILaunchDockerGrid()
        {
            GridUrl = new Uri("http://localhost:9999");
            var options = new ChromeOptions();
            try { _driver = new RemoteWebDriver(GridUrl, options); } catch (Exception ex) { Console.WriteLine(ex); }
            //_driver.Manage().Window.Maximize();
            //_driver.Navigate().GoToUrl("https://www.google.mu/");
            _driver.Navigate().GoToUrl("https://dev-business.edbmauritius.org/wps/portal/business/!ut/p/z1/04_Sj9CPykssy0xPLMnMz0vMAfIjo8ziDVCAo4FTkJGTsYGBu7OJfjghBVEY0sgKgfqjwErMjRyNPB0tDPz9nYKdDAK9Q8yMDYNNjAwsTNEVWISAFLg7mXuaensamJgaQxXgsaQgN8Ig09NREQDE8w0D/dz/d5/L2dBISEvZ0FBIS9nQSEh/#/lastLogin");


        }




    }

    }

