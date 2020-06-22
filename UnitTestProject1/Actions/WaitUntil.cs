// <copyright file="WaitUntil.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace UnitTestProject1.Actions
{
   
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    /// <summary>
    /// Wait Until.
    /// </summary>
    public static class WaitUntil
    {
        /// <summary>
        /// Element is present.
        /// </summary>
        /// <param name="locator">locator.</param>
        public static void ElementIsPresent(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetIntance(), TimeSpan.FromSeconds(300));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public static void ElementIsPresent(By locator, int seg)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetIntance(), TimeSpan.FromSeconds(seg));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public static void ElementIsVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetIntance(), TimeSpan.FromSeconds(120));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static void ElementIsClickeable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetIntance(), TimeSpan.FromSeconds(300));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
