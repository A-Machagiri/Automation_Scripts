using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

[Binding]
public class LoginSteps
{
    private LoginPage_Actions _loginPageActions;

    public LoginSteps(WebUtilities webUtilities)
    {
        _loginPageActions = new LoginPage_Actions(webUtilities);
    }

    [Given("I navigate to the URL '(.*)'")]
    public void GivenINavigateToTheURL(string url)
    {
        _loginPageActions._webUtilities.NavigateToUrl(url);
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPageActions.EnterCredentials("standard_user", "secret_sauce");
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        _loginPageActions.EnterCredentials("invalid_user", "wrong_password");
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPageActions.ClickLoginButton();
    }

    [Then("I should be redirected to the product page")]
    public void ThenIShouldBeRedirectedToTheProductPage()
    {
        Assert.IsTrue(_loginPageActions.IsProductPageDisplayed());
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(_loginPageActions._webUtilities.FindElement(LoginPage_Locators.ErrorMessage).Displayed);
    }
}