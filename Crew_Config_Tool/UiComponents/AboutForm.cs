using FS_Crew_Config_Tool.Classes;
using System.Diagnostics;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class AboutForm : Form
    {
        private string softwareVersion;

        public AboutForm()
        {
            InitializeComponent();

            softwareVersion = Utilities.GetCurrentVersion();

            LabelVersion.Text = "Version: " + softwareVersion;
        }

        private void LinkLabelFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string feedbackFormAddress = "https://docs.google.com/forms/d/e/1FAIpQLSfhzr-7Iz3vfyJrAUggUdf7VNO1y4A6V4vVpxiSgIqXkO5nug/viewform?entry.1235937830="
                                         + softwareVersion;

            Process.Start(feedbackFormAddress);
        }

        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string gitHubAddress = "https://github.com/O3ObijuanKenobi/FracturedSpace";
            Process.Start(gitHubAddress);
        }
    }
}
