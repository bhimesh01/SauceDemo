using OpenQA.Selenium;

namespace POM
{
    public class LoginPage
    {
        private By username = By.XPath("//input[@name='user-name']");
        private By password = By.XPath("//input[@name='password']");
        private By loginButton = By.XPath("//input[@name='login-button']");

        public void NavigateToLoginPage()
        {
            // Code to navigate to the login page
        }

        public void EnterValidCredentials()
        {
            // Code to enter valid credentials and click the login button
        }

        public void EnterInvalidCredentials()
        {
            // Code to enter invalid credentials and click the login button
        }

        public void CheckHomePageRedirection()
        {
            // Code to check if the user is redirected to the home page
        }

        public void CheckErrorMessageDisplay()
        {
            // Code to check if an error message is displayed
        }
    }
}
