using OpenQA.Selenium;

namespace POM
{
    public class ProductPage
    {
        private IWebDriver driver;
        private By product = By.CssSelector(".inventory_item");
        private By addToCartButton = By.CssSelector(".btn_inventory");
        private By removeButton = By.CssSelector(".cart_button");

        public ProductPage(IWebDriver driver)
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

        public void RemoveFromCart()
        {
            driver.FindElement(removeButton).Click();
        }
    }
}