using OpenQA.Selenium;

namespace Locators;

public static class Locators
{
    public static By SignIn => By.XPath("//header[@id=\"header-content\"]//a[contains(@class,\"ssrcss-7qt8yw\")]");

    public static By SignInXpathAxes =>
        By.XPath("//header[@id=\"header-content\"]//descendant::a[contains(@class,\"7qt8yw\")]");

    public static By Home =>
        By.XPath(
            "//header[@id=\"header-content\"]//li[contains(@class,\"15542on\")]//a[contains(@class,\"e1gviwgp17\")]");

    public static By HomeXpathAxes => By.XPath(
        "//header[@id=\"header-content\"]//descendant::li[contains(@class,\"15542on\")]//a[contains(@class,\"e1gviwgp17\")]");

    public static By Logo => By.XPath("//header[@id=\"header-content\"]//div[contains(@class,\"g08l83\")]");

    public static By LogoXpathAxes =>
        By.XPath("//header[@id=\"header-content\"]//descendant::div[contains(@class,\"g08l83\")]");

    public static By SearchBar =>
        By.XPath("//header[@id=\"header-content\"]//div[contains(@aria-label,\"Search BBC\")]");

    public static By SearchBarXpathAxes =>
        By.XPath("//header[@id=\"header-content\"]//descendant::div[contains(@aria-label,\"Search BBC\")]");
    
}