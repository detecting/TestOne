using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestOne
{
    public class SeleniumSetMethods
    {
//        public static void EnterText(string element, string value, PropertiesCollection.PropType elementType)
//        {
//            if (elementType == PropertiesCollection.PropType.Id)
//            {
//                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
//            }
//
//            if (elementType == PropertiesCollection.PropType.Name)
//            {
//                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
//            }
//        }
        

//        public static void Click(string element, PropertiesCollection.PropType elementType)
//        {
//            if (elementType == PropertiesCollection.PropType.Id)
//            {
//                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
//            }
//
//            if (elementType == PropertiesCollection.PropType.Name)
//            {
//                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
//            }
//        }

//        public static void SelectDropDown(string element, string value, PropertiesCollection.PropType elementType)
//        {
//            if (elementType == PropertiesCollection.PropType.Id)
//            {
//                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
//            }
//
//            if (elementType == PropertiesCollection.PropType.Name)
//            {
//                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
//            }
//        }
        
        
        /*simplify the methods*/
        public static void EnterText(IWebElement webElement,string value)
        {
            webElement.SendKeys(value);
        }

        public static void Click(IWebElement webElement)
        {
            webElement.Click();
        }
        public static void SelectDropDown(IWebElement webElement, string value)
        {
           new SelectElement(webElement).SelectByText(value);
        }

    }
}