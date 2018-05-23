using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestOne
{
    public class LoginPageObj
    {
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UserName { set; get; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement Password { set; get; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement SubmitLogin { get; set; }

        public LoginPageObj()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
       
        public EAPageObject Login(string userName, string password)
        {
            UserName.SendKeys(userName);
            Password.SendKeys(password);
            SubmitLogin.Submit();
            return new EAPageObject();
        }
    }
}