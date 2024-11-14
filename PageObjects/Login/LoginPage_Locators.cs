using OpenQA.Selenium;

namespace PageObjects.Login
{
    public static class LoginPage_Locators
    {
        public static By UsernameField = By.Id("user-name");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.Id("login-button");
        public static By ErrorMessage = By.CssSelector("[data-test='error']");
        public static By ProductPageTitle = By.ClassName("title");
    }
}