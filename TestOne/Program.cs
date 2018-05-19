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
        IWebDriver driver = new ChromeDriver();
        private string URL = "http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login";
        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initial()
        {
            driver.Navigate().GoToUrl(URL);
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown(driver,"TitleId","Ms.","Id");
            SeleniumSetMethods.EnterText(driver,"Initial","executeautomation","Name");
            /*
             * 
             */
            string titleContent = SeleniumGetMethods.GetTextFromDdl(driver, "TitleId", "Id");
            Console.WriteLine("title content: "+titleContent);
            string initialVontent = SeleniumGetMethods.GetText(driver, "Initial", "Name");
            Console.WriteLine("initial content: "+initialVontent);


        }

        [TearDown]
        public void ClearUp()
        {
         //   driver.Close();
        }
    }
}