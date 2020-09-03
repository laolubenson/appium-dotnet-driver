using System;

namespace OpenQA.Selenium.Appium.Interfaces
{
    public interface INetworkActions
    {
        /// <summary>
        /// Toggle airplane mode on device
        /// </summary>
        void ToggleAirplaneMode();


        /// <summary>
        /// Retrieve display density(dpi) of the Android device
        /// </summary>
        /// <returns></returns>
        float GetDisplayDensity();
    }
}
