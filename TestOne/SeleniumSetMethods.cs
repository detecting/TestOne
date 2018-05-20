using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestOne
{
    public static class SeleniumSetMethods
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


//        public static void EnterText(IWebElement webElement,string value)
//        {
//            webElement.SendKeys(value);
//        }
//
//        public static void Click(IWebElement webElement)
//        {
//            webElement.Click();
//        }
//        public static void SelectDropDown(IWebElement webElement, string value)
//        {
//           new SelectElement(webElement).SelectByText(value);
//        }

/*simplify the methods*/
        /// <summary>
        /// ectended methods for entering text in the control
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="value"></param>
        /// 将方法EnterText添加到IWebElement中，注意这个类必须是static的。
        public static void EnterText(this IWebElement webElement, string value)
        {
            webElement.SendKeys(value);
        }

        public static void Click(this IWebElement webElement)
        {
            webElement.Click();
        }

        public static void SelectDropDown(this IWebElement webElement, string value)
        {
            new SelectElement(webElement).SelectByText(value);
        }
    }
}