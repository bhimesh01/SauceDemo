using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[Binding]
public class Hooks
{
    private IWebDriver driver;

    [BeforeScenario]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

    [AfterScenario]
    public void TearDown()
    {
        driver.Quit();
    }
}