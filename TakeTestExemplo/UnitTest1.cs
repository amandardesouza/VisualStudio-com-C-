﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;



namespace TakeTestExemplo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://framedlife.com.br/fotoescambo/users/login");
            IWebElement element = driver.FindElement(By.Id("UserEmail"));
            element.SendKeys("guifreitag@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.Quit();


        }
    }
}
