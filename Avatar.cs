
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFramework
{
    public class Avatar
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        private IWebElement avatar;

        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement userName;


        Actions action = new Actions(Browser.Driver2);
       
        public void see()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 7));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            Assert.IsTrue(avatar.Displayed);



        }

        public void logout()
        {
            IWebElement element = Browser.Driver2.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a"));
            action.MoveToElement(avatar).Build().Perform();
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
            Assert.IsTrue(userName.Displayed);
        }

        public void setting()
        {
            IWebElement setButton = Browser.Driver2.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a"));
            action.MoveToElement(avatar).Build().Perform();
            action.MoveToElement(setButton).Click().Perform();
            Thread.Sleep(1000);
        }


        public void adminSet()
        {

            IWebElement adminSetting = Browser.Driver2.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[6]/a"));
            action.MoveToElement(avatar).Build().Perform();
            action.MoveToElement(adminSetting).Click().Perform();
            Thread.Sleep(1000);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[2]/a")]
        private IWebElement myStudyButton;

        public void MyStudy()
        {
            myStudyButton.Click();
        }

        public void myAccount()
        {
            IWebElement setButton = Browser.Driver2.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[5]/a"));
            action.MoveToElement(avatar).Build().Perform();
            action.MoveToElement(setButton).Click().Perform();
            Thread.Sleep(1000);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/ul[1]/li[1]/a")]
        private IWebElement studyCenterSidebar;

        public void StudyCenterSidebar()
        {
            studyCenterSidebar.Click();
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[5]/div[2]/div[3]/ul/li[1]/a")]
        private IWebElement misson3;



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div[1]/a")]
        private IWebElement misson3Confirm;

        public void Misson3()
        {
            WebDriverWait wai = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 7));
            wai.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div[5]/div[2]/div[3]/ul/li[1]/a")));

            misson3.Click();

            

            Thread.Sleep(2000);

            Browser.Driver2.SwitchTo().Window(Browser.Driver2.WindowHandles.Last());



            Assert.IsTrue(misson3Confirm.Displayed);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[2]/a")]
        private IWebElement adminPersonalHome;

        public void AdminPersonalHome()
        {

            IWebElement adminHome = Browser.Driver2.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[2]/a"));
            action.MoveToElement(avatar).Build().Perform();
            action.MoveToElement(adminHome).Click().Perform();
            Thread.Sleep(1000);
        }

    }
}
