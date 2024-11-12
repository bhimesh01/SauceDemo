using OpenQA.Selenium;

namespace POM
{
    public class ProductsPage
    {
        private IWebDriver driver;
        private By product = By.ClassName("inventory_item_name");
        private By addToCartButton = By.ClassName("btn_inventory");
        private By cartButton = By.ClassName("shopping_cart_link");
        private By removeButton = By.ClassName("cart_button");
        private By continueShoppingButton = By.ClassName("btn_secondary");

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectProduct()
        {
            driver.FindElement(product).Click();
        }

        public void AddToCart()
        {
            driver.FindElement(addToCartButton).Click();
        }

        public void GoToCart()
        {
            driver.FindElement(cartButton).Click();
        }

        public void RemoveFromCart()
        {
            driver.FindElement(removeButton).Click();
        }

        public void ContinueShopping()
        {
            driver.FindElement(continueShoppingButton).Click();
        }
    }
}