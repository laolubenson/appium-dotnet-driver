﻿using System;
using Appium.Net.Integration.Tests.helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Appium.Net.Integration.Tests.Android.Device
{
    internal class NetworkTests
    {
        private AppiumDriver<IWebElement> _driver;
        private AppiumOptions _androidOptions;

        [OneTimeSetUp]
        public void SetUp()
        {
            _androidOptions = Caps.GetAndroidUIAutomatorCaps(Apps.Get(Apps.androidApiDemos));
            _driver = new AndroidDriver<IWebElement>(
                Env.ServerIsLocal() ? AppiumServers.LocalServiceUri : AppiumServers.RemoteServerUri,
                _androidOptions);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }

        [Test]
        public void CanToggleDataTest()
        {
            var androidDriver = (AndroidDriver<IWebElement>)_driver;

            androidDriver.ToggleData();
            androidDriver.ToggleData();
        }

        [Test]
        public void CanToggleAirplaneModeTest()
        {
            var androidDriver = (AndroidDriver<IWebElement>)_driver;

            androidDriver.ToggleAirplaneMode();
            
            var currentConnectionType = androidDriver.ConnectionType;
            Assert.That(currentConnectionType, Is.EqualTo(ConnectionType.AirplaneMode));

            androidDriver.ToggleAirplaneMode();
        }

        [Test]
        public void CanToggleWifiTest()
        {
            var androidDriver = (AndroidDriver<IWebElement>)_driver;
            var beforeToggleConnectionType = androidDriver.ConnectionType;
            androidDriver.ToggleWifi();

            var currentConnectionType = androidDriver.ConnectionType;
            Assert.That(currentConnectionType, Is.Not.EqualTo(beforeToggleConnectionType));

            androidDriver.ToggleWifi();
        }

        [Test]
        public void CanMakeGsmCallTest()
        {
            var androidDriver = (AndroidDriver<IWebElement>)_driver;

            Assert.Multiple(() =>
            {
                Assert.DoesNotThrow(() => androidDriver.MakeGsmCall("5551234567", GsmCallActions.Call));
                Assert.DoesNotThrow(() => androidDriver.MakeGsmCall("5551234567", GsmCallActions.Accept));
                Assert.DoesNotThrow(() => androidDriver.MakeGsmCall("5551234567", GsmCallActions.Cancel));
                Assert.DoesNotThrow(() => androidDriver.MakeGsmCall("5551234567", GsmCallActions.Hold));
            });
        }
    }
}
