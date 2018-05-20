using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestOne
{
    public class EAPageObject
    {
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver,this);
        }
    }
}