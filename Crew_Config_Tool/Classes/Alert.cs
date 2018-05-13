using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.Classes
{
    public class Alert
    {
        /// <summary>
        /// Creates a message box that generates populated bug reports
        /// </summary>
        /// <param name="visibleMessage">Message to be shown on-screen</param>
        /// <param name="e">Stack trace causing pain</param>
        /// <param name="callingPoint">String to indicate where error occurred</param>
        public static void CreateMessageBox(string visibleMessage, Exception e, string callingPoint = "")
        {
            string message = "The following error has occurred:\n\n";
            message += visibleMessage + "\n\n";
            message += "Would you like to report this?";

            DialogResult result = MessageBox.Show(message, "Error", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string osVersion = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
                string osRelease = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();

                string feedbackAddress = "https://docs.google.com/forms/d/e/1FAIpQLSfhzr-7Iz3vfyJrAUggUdf7VNO1y4A6V4vVpxiSgIqXkO5nug/viewform?entry.1235937830="
                                         + Utilities.GetCurrentVersion()
                                         + "&entry.2145434213=Stack+Trace"
                                         + "&entry.1687052561=" + e.Message + " with source: " + callingPoint
                                         + "&entry.1479586596=" + osVersion + " - Build " + osRelease;

                Process.Start(feedbackAddress);
            }
        }
    }
}
