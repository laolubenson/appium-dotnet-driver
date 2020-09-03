using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Interfaces
{
    public interface IHasDeviceDetails
    {
        /// <summary>
        /// Retrieve visibility and bounds information of the status and navigation bars
        /// </summary>
        IDictionary<string, object> GetSystemBars();

        /// <summary>
        /// Retrieve display density(dpi) of the Android device
        /// </summary>
        /// <returns></returns>
        float GetDisplayDensity();
    }
}
