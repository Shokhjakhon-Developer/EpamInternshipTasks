using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Locators;

[TestFixture, Parallelizable(ParallelScope.Children), FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class LocatorsTest
{
    private IWebDriver _driver = null!;

    [SetUp]
    public void SetUp()
    {
        _driver = new ChromeDriver();
        Uri url = new Uri("https://www.bbc.com/sport");
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl(url);
    }

    [Test]
    public void Task_1()
    {
        var signInIcon = _driver.FindElement(Locators.SignIn);
        Assert.That(signInIcon.Displayed);

        var homeIcon = _driver.FindElement(Locators.Home);
        Assert.That(homeIcon.Displayed);

        var logoIcon = _driver.FindElement(Locators.Logo);
        Assert.That(logoIcon.Displayed);

        var searchBarIcon = _driver.FindElement(Locators.SearchBar);
        Assert.That(searchBarIcon.Displayed);
    }

    [Test]
    public void Task_2()
    {
        var homeIconXpath = _driver.FindElement(Locators.HomeXpathAxes);
        Assert.That(homeIconXpath.Displayed);

        var signInIconXpath = _driver.FindElement(Locators.SignInXpathAxes);
        Assert.That(signInIconXpath.Displayed);

        var logoIconXpath = _driver.FindElement(Locators.LogoXpathAxes);
        Assert.That(logoIconXpath.Displayed);

        var searchBarIconXpath = _driver.FindElement(Locators.SearchBarXpathAxes);
        Assert.That(searchBarIconXpath.Displayed);
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
    }
}