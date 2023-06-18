using Xunit.Abstractions;

namespace ElectronicCommerce.UiTest; 

public class SearchTest{
    private readonly ITestOutputHelper _testOutputHelper;
    private IWebElement _searchInput;
    private IWebElement _searchButton;

    public SearchTest(ITestOutputHelper testOutputHelper) {
        _testOutputHelper = testOutputHelper;
        _searchInput = TestBase.Driver.FindElement(By.Id("searchInput"));
        _searchButton = TestBase.Driver.FindElement(By.Id("searchButton"));
        _searchInput.Clear();
    }

    [Fact]
    private void SearchTest1() {
        _searchInput.SendKeys("牛奶");
        _searchButton.Click();
        Thread.Sleep(1000);
    }
}