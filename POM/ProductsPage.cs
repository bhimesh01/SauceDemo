using OpenQA.Selenium;

namespace POM
{
    public class ProductsPage
    {
        private IWebDriver driver;
        private By product = By.XPath("//div[@class='inventory_item']");
        private By addToCartButton = By.XPath("//button[text()='ADD TO CART']");
        private By removeFromCartButton = By.XPath("//button[text()='REMOVE']");
        private By continueShoppingButton = By.XPath("//button[text()='Continue Shopping']");

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectProduct()
        {
            driver.FindElement(product).Click();
        }

        public void ClickAddToCartButton()
        {
            driver.FindElement(addToCartButton).Click();
        }

        public void ClickRemoveFromCartButton()
        {
            driver.FindElement(removeFromCartButton).Click();
        }

        public void ClickContinueShoppingButton()
        {
            driver.FindElement(continueShoppingButton).Click();
        }

        public bool IsProductInCart()
        {
            // Assuming the presence of a specific element indicates that the product is in the cart
            // Replace By.XPath("//...") with the appropriate locator
            return driver.FindElement(By.XPath("//div[@class='cart_item']")).Displayed;
        }

        public bool IsProductPageDisplayed()
        {
            return driver.FindElement(product).Displayed;
        }
    }
}