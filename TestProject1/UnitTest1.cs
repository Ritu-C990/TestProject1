using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        
        public void Main(string[] str)
        {
           IWebDriver driver = new ChromeDriver("C:\\Users\\RkiMishra\\source\\repos\\TestProject1\\TestProject1\\NewFolder");
            driver.Url = "https://www.liberis.com/";
           IWebElement ele = driver.FindElement(By.TagName("Get a Demo"));
            ele.SendKeys("https://www.liberis.com/become-a-partner");
            IWebElement radio = driver.FindElement(By.Id("I'm a Broker"));
            radio.Click();
            IWebElement radio2 = driver.FindElement(By.Id("I'm an ISO"));
            radio2.Click();
            IWebElement radio3 = driver.FindElement(By.Id("I'm a Strategic Partner"));
            radio3.Click();
            IWebElement button = driver.FindElement(By.TagName("Get a Demo"));
            button.Click();
            if(button.Selected)
            {
                Console.WriteLine("Please select a type of partner");
            }
        }

        
    }
}