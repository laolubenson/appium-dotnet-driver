using System.Collections.Generic;

namespace OpenQA.Selenium.Appium.Interfaces
{
    public interface IHasDeviceDetails
    {
        /// <summary>
        /// Retrieve visibility and bounds information of the status and navigation bars
        /// </summary>
        IDictionary<string, object> GetSystemBars();
    }
}
