using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium.IDE
{
    class Header
    {
        public Header()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement Introdustio { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement Selectrs { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement SpecialElements { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement TestCases { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement TestScenario { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement Introdustio { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/nav/div/ul/li[1]/a")]
        public IWebElement Introdustio { get; set; }
    }
}
