using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace testing_todorvachev_4
{
    class program
    {
        static IWebDriver driver = new ChromeDriver(@"I:\G Gilbert's Documents\Selenium\Selenium 101 Location");

        static void Main(string[] args)
        {
            string url = "http://testing.todorvachev.com/selectors/name/";
            driver.Navigate().GoToUrl(url);


            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#menu-item-57 > a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            Thread.Sleep(10000);

            var scrolldown = driver.FindElement(By.Id("comment"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(scrolldown);
            actions.Perform(); //<= As of 15-05, when running, Selenium stops here and errors appear

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id=\"post-74\"]/div/p/a")).Click();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            Thread.Sleep(2000);

            var scrollpassword = driver.FindElement(By.Name("submit"));

            Actions actionpassword = new Actions(driver);
            actionpassword.MoveToElement(scrollpassword);
            actionpassword.Perform();

            Thread.Sleep(2000);

            driver.FindElement(By.Name("userid")).SendKeys("JonTaylor");
            driver.FindElement(By.Name("passid")).SendKeys("Christoph2");
            driver.FindElement(By.Name("repeatpassid")).SendKeys("Christoph2");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(0.30);

            driver.FindElement(By.Name("submit")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            Thread.Sleep(10000);

            driver.Quit();
        }



    }
}
