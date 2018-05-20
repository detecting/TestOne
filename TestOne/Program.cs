using System;
using System.ComponentModel.Design;
using System.Management.Instrumentation;
using System.Resources;
using NUnit.Framework;
using NUnit.Framework.Internal;
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
            //initialize the page obj by calling its reference
            EAPageObject page = new EAPageObject();
            page.TxtInitial.Clear();
            page.TxtInitial.SendKeys("executeautomation");
            page.BtnSave.Click();
            
            


            /*SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertiesCollection.PropType.Id);
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertiesCollection.PropType.Name);
            /*
             * 
             #1#
            string titleContent = SeleniumGetMethods.GetTextFromDdl("TitleId", PropertiesCollection.PropType.Id);
            Console.WriteLine("title content: " + titleContent);
            string initialVontent = SeleniumGetMethods.GetText("Initial", PropertiesCollection.PropType.Name);
            Console.WriteLine("initial content: " + initialVontent);*/
        }

        [TearDown]
        public void ClearUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}