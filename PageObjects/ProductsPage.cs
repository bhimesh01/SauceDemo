using OpenQA.Selenium;

namespace AutomationFramework.PageObjects
{
    public class ProductsPage
    {
        private IWebDriver driver;

        // Define product page locators
        private By productTitle = By.ClassName("product_title");
        private By productPrice = By.ClassName("product_price");
        private By addToCartButton = By.ClassName("add_to_cart_button");

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Define methods for interacting with the page
        public string GetProductTitle()
        {
            return driver.FindElement(productTitle).Text;
        }

        public string GetProductPrice()
        {
            return driver.FindElement(productPrice).Text;
        }

        public void ClickAddToCart()
        {
            driver.FindElement(addToCartButton).Click();
        }
    }
}