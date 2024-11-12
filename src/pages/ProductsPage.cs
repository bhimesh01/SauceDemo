public class ProductsPage
{
    IWebDriver driver;

    By product1 = By.Id("product-1");
    By addToCartButton = By.Id("add-to-cart");
    By removeButton = By.Id("remove");
    By backToProductsButton = By.Id("back-to-products");

    public ProductsPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void SelectProduct1()
    {
        driver.FindElement(product1).Click();
    }

    public void ClickAddToCartButton()
    {
        driver.FindElement(addToCartButton).Click();
    }

    public void ClickRemoveButton()
    {
        driver.FindElement(removeButton).Click();
    }

    public void ClickBackToProductsButton()
    {
        driver.FindElement(backToProductsButton).Click();
    }
}
