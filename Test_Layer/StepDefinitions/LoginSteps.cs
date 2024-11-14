using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects.Login;
using TechTalk.SpecFlow;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage_Actions _loginPageActions;

        public LoginSteps(IWebDriver driver)
        {
            _loginPageActions = new LoginPage_Actions(driver);
        }

        [Given("I navigate to the login page at (.*)")]
        public void GivenINavigateToTheLoginPage(string url)
        {
            _loginPageActions.NavigateToUrl(url);
        }

        [When("I enter username (.*) and password (.*)")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPageActions.EnterCredentials(username, password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPageActions.ClickLoginButton();
        }

        [Then("I should see the product page")]
        public void ThenIShouldSeeTheProductPage()
        {
            Assert.IsTrue(_loginPageActions.IsProductPageDisplayed());
        }

        [Then("I should see an error message saying (.*)")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            Assert.AreEqual(message, _loginPageActions.GetErrorMessage());
        }
    }
}