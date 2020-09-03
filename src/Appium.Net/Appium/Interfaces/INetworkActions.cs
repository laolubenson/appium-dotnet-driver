using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Interfaces
{
    public interface INetworkActions
    {
        /// <summary>
        /// Toggle airplane mode on device
        /// </summary>
        void ToggleAirplaneMode();

        /// <summary>
        /// Retrieve visibility and bounds information of the status and navigation bars
        /// </summary>
        IDictionary<string, object> GetSystemBars();
    }
}
