using System.Reflection;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            LabelVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
