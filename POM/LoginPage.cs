using OpenQA.Selenium;

namespace POM
{
    public class LoginPage
    {
        private By username = By.XPath("//input[@name='user-name']");
        private By password = By.XPath("//input[@name='password']");
        private By loginButton = By.XPath("//input[@name='login-button']");
    }
}
