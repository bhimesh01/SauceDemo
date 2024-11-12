using OpenQA.Selenium;

namespace POM
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By username = By.XPath("//input[@name='user-name']");
        private By password = By.XPath("//input[@name='password']");
        private By loginButton = By.XPath("//input[@name='login-button']");
        private By errorMessage = By.XPath("//h3[@data-test='error']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string user, string pass)
        {
            driver.FindElement(username).SendKeys(user);
            driver.FindElement(password).SendKeys(pass);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public bool IsHomePageDisplayed()
        {
            // Assuming the presence of a specific element indicates that the home page is displayed
            // Replace By.XPath("//...") with the appropriate locator
            return driver.FindElement(By.XPath("//span[text()='Products']")).Displayed;
        }

        public bool IsErrorMessageDisplayed()
        {
            return driver.FindElement(errorMessage).Displayed;
        }
    }
}
