using System;
using System.ComponentModel.Design;
using System.Management.Instrumentation;
using System.Resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestOne
{
    internal class Program
    {
//        IWebDriver driver = new ChromeDriver();
        private string URL = "http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login";

        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initial()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl(URL);
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown(PropertiesCollection.driver, "TitleId", "Ms.", "Id");
            SeleniumSetMethods.EnterText(PropertiesCollection.driver, "Initial", "executeautomation", "Name");
            /*
             * 
             */
            string titleContent = SeleniumGetMethods.GetTextFromDdl(PropertiesCollection.driver, "TitleId", "Id");
            Console.WriteLine("title content: " + titleContent);
            string initialVontent = SeleniumGetMethods.GetText(PropertiesCollection.driver, "Initial", "Name");
            Console.WriteLine("initial content: " + initialVontent);
        }

        [TearDown]
        public void ClearUp()
        {
            //   driver.Close();
        }
    }
}