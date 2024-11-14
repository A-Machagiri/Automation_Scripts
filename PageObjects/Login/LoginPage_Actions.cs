using PageObjects.Login;
using Utilities;

namespace PageObjects.Login {
    public class LoginPage_Actions {
        private WebUtilities webUtilities;

        public LoginPage_Actions(WebUtilities webUtilities) {
            this.webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password) {
            webUtilities.SendKeys(LoginPage_Locators.UsernameField, username);
            webUtilities.SendKeys(LoginPage_Locators.PasswordField, password);
        }

        public void ClickLoginButton() {
            webUtilities.Click(LoginPage_Locators.LoginButton);
        }

        public bool IsErrorMessageVisible() {
            return webUtilities.FindElements(LoginPage_Locators.ErrorMessage).Count > 0;
        }

        public bool IsProductPageVisible() {
            return webUtilities.FindElements(LoginPage_Locators.ProductPageTitle).Count > 0;
        }
    }
}