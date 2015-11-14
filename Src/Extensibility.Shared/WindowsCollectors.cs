﻿namespace Microsoft.HockeyApp
{
    using System;

    /// <summary>
    /// Windows auto collectors provide automatic collection of telemetry context and automatic collection of telemetry data points for Windows Applications.
    /// </summary>
    [Flags]
    internal enum WindowsCollectors  
    {
        /// <summary>
        /// Collector to auto populate TelemetryContext for all telemetry.
        /// </summary>
        Metadata = 1, // 000001
        
        /// <summary>
        /// Auto collection of user and session information from application startup.
        /// </summary>
        Session = 1 << 2, // 000010

        /// <summary>
        /// Auto collection of page view telemetry from view navigation events.
        /// </summary>
        PageView = 1 << 3, // 000100

        /// <summary>
        /// Auto collection of application crashes from unhandled exception handler. 
        /// </summary>
        UnhandledException = 1 << 4 // 001000
    }
}
