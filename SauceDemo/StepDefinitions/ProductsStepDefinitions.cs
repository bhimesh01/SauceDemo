using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;

namespace StepDefinitions
{
    [Binding]
    public class ProductsStepDefinitions
    {
        private IWebDriver driver = new ChromeDriver();
        private LoginPage loginPage;
        private ProductsPage productsPage;

        [Given(@"I am on the products page")]
        public void GivenIAmOnTheProductsPage()
        {
            loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.EnterCredentials("standard_user", "secret_sauce");
            loginPage.ClickLoginButton();

            productsPage = new ProductsPage(driver);
        }

        [When(@"I select a product")]
        public void WhenISelectAProduct()
        {
            productsPage.SelectProduct();
        }

        [When(@"I click the add to cart button")]
        public void WhenIClickTheAddToCartButton()
        {
            productsPage.ClickAddToCartButton();
        }

        [Then(@"the product should be added to the cart")]
        public void ThenTheProductShouldBeAddedToTheCart()
        {
            Assert.IsTrue(productsPage.IsProductInCart());
        }

        [When(@"I click the remove button")]
        public void WhenIClickTheRemoveButton()
        {
            productsPage.ClickRemoveFromCartButton();
        }

        [Then(@"the product should be removed from the cart")]
        public void ThenTheProductShouldBeRemovedFromTheCart()
        {
            Assert.IsFalse(productsPage.IsProductInCart());
        }

        [And(@"I should be able to continue shopping")]
        public void AndIShouldBeAbleToContinueShopping()
        {
            productsPage.ClickContinueShoppingButton();
            Assert.IsTrue(productsPage.IsProductPageDisplayed());
        }
    }
}