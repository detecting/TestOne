using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestOne
{
    public class EAPageObject
    {
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement Initial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName { get; set; }    

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        public void FillUserForm(string initial, string firstName, string middleName)
        {
            Initial.SendKeys(initial);
            FirstName.SendKeys(firstName);
            MiddleName.SendKeys(middleName);
            BtnSave.Click();
        }
    }
}