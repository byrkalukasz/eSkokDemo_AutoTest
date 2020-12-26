using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Selenium.IDE
{
    class RecentPost
    {
        public RecentPost()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/aside/div[2]/ul/li[1]/a")]
        public IWebElement DragAndDrop { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/aside/div[2]/ul/li[2]/a")]
        public IWebElement NewTab { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/aside/div[2]/ul/li[3]/a")]
        public IWebElement AlertBox { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/aside/div[2]/ul/li[4]/a")]
        public IWebElement Name { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/aside/div[2]/ul/li[5]/a")]
        public IWebElement ID { get; set; }
    }
}
