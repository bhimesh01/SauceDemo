namespace SauceDemo.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Code to call the NavigateToLoginPage() method from the POM
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            // Code to call the EnterValidCredentials() method from the POM
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            // Code to call the EnterInvalidCredentials() method from the POM
        }

        [Then("I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            // Code to call the CheckHomePageRedirection() method from the POM
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Code to call the CheckErrorMessageDisplay() method from the POM
        }
    }
}