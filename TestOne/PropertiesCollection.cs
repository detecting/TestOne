using OpenQA.Selenium;

namespace TestOne
{
    public class PropertiesCollection
    {
        //auto-implement properties 

        public enum PropType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }

        public static IWebDriver driver { get; set; }
    }
}