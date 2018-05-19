using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestOne
{
    public class SeleniumGetMethods
    {
        public static string GetText( string element, PropertiesCollection.PropType elementType)
        {
            if (elementType == PropertiesCollection.PropType.Id)
            {
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            }

            if (elementType == PropertiesCollection.PropType.Name)
            {
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
            {
                return string.Empty;
            }
        }

        public static string GetTextFromDdl( string element, PropertiesCollection.PropType elementType)
        {
            if (elementType == PropertiesCollection.PropType.Id)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }

            if (elementType == PropertiesCollection.PropType.Name)
            {
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}