using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;
using NUnit.Framework;

[Binding]
public class LoginStepDefinitions
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [Given(@"I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
        loginPage.NavigateTo();
    }

    [When(@"I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        loginPage.EnterCredentials("standard_user", "secret_sauce");
    }

    [When(@"I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        loginPage.EnterCredentials("invalid_user", "invalid_password");
    }

    [When(@"I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then(@"I should be redirected to the home page")]
    public void ThenIShouldBeRedirectedToTheHomePage()
    {
        Assert.IsTrue(loginPage.IsHomePageDisplayed());
    }

    [Then(@"I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(loginPage.IsErrorMessageDisplayed());
    }
}