using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class ProductsPage
    {
        private By product_1 = By.XPath("//div[text() = 'Sauce Labs Backpack']");
        private By product_2 = By.XPath("//div[text() = 'Sauce Labs Bolt T-Shirt']");
        private By addToCart = By.XPath("//button[text() = 'Add to cart']");
        private By remove = By.XPath("//button[text() = 'Remove']");
        private By backToProducts = By.XPath("//button[text() = 'Back to products']");
    }
}
