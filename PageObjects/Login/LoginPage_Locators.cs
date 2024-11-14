namespace PageObjects.Login
{
    public static class LoginPage_Locators
    {
        public static readonly string UsernameField = "input[data-test='username']";
        public static readonly string PasswordField = "input[data-test='password']";
        public static readonly string LoginButton = "input[data-test='login-button']";
        public static readonly string ErrorMessage = "h3[data-test='error']";
        public static readonly string ProductPageTitle = "span.title"; // Locator for product page title after login
    }
}