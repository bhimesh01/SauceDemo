using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;

namespace SauceDemo.StepDefinitions
{
    [Binding]
    public class ProductStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private ProductPage productPage;

        [Given("I am on the products page")]
        public void GivenIAmOnTheProductsPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");
            productPage = new ProductPage(driver);
        }

        [When("I select a product")]
        public void WhenISelectAProduct()
        {
            productPage.SelectProduct();
        }

        [When("I click on the add to cart button")]
        public void WhenIClickOnTheAddToCartButton()
        {
            productPage.AddToCart();
        }

        [When("I click on the remove button")]
        public void WhenIClickOnTheRemoveButton()
        {
            productPage.RemoveFromCart();
        }
    }
}