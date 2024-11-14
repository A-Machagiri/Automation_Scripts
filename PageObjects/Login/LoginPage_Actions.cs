using OpenQA.Selenium;
using Utilities;

namespace PageObjects.Login
{
    public class LoginPage_Actions
    {
        private WebUtilities _webUtilities;

        public LoginPage_Actions(IWebDriver driver)
        {
            _webUtilities = new WebUtilities(driver);
        }

        public void EnterCredentials(string username, string password)
        {
            _webUtilities.SendKeys(LoginPage_Locators.UsernameField, username);
            _webUtilities.SendKeys(LoginPage_Locators.PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginPage_Locators.LoginButton);
        }

        public bool IsProductPageDisplayed()
        {
            return _webUtilities.FindElement(LoginPage_Locators.ProductLabel).Displayed;
        }

        public string GetErrorMessage()
        {
            return _webUtilities.FindElement(LoginPage_Locators.ErrorMessage).Text;
        }
    }
}