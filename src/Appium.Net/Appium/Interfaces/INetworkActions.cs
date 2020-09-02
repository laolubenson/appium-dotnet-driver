using System;
using OpenQA.Selenium.Appium.Enums;

namespace OpenQA.Selenium.Appium.Interfaces
{
    public interface INetworkActions
    {
        /// <summary>
        /// Toggle airplane mode on device
        /// </summary>
        void ToggleAirplaneMode();

        /// <summary>
        /// Set GSM voice state (Emulator only)
        /// </summary>
        /// <param name="gsmVoiceState"></param>
        void SetGsmVoice(GsmVoiceState gsmVoiceState);
    }
}
