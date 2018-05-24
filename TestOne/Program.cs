using System;
using System.ComponentModel.Design;
using System.Management.Instrumentation;
using System.Resources;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFirst;

namespace TestOne
{
    internal class Program
    {
//        IWebDriver driver = new ChromeDriver();
        private string LoginUrl = "http://www.executeautomation.com/demosite/Login.html";
        private string userName = "userName";
        private string password = "passwd";


        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initial()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl(LoginUrl);
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\hzha321\Desktop\data.xlsx");
            //initialize the page obj by calling its reference
            LoginPageObj loginPageObj = new LoginPageObj();
//            EAPageObject eaPageObject = loginPageObj.Login(ExcelLib.ReadData(1,userName),ExcelLib.ReadData(1,password));
            var username = ExcelLib.ReadData(1, userName);
            var pass=ExcelLib.ReadData(1, password);
            
            EAPageObject eaPageObject =
                loginPageObj.Login(ExcelLib.ReadData(1, userName), ExcelLib.ReadData(1, password));
            eaPageObject.FillUserForm("initial", "morgan", "zhang");


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
//            PropertiesCollection.driver.Close();
        }
    }
}