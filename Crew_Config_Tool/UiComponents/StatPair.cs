using FS_Crew_Config_Tool.Classes.Listings;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class StatPair : UserControl
    {
        public StatPair()
        {
            InitializeComponent();
        }

        public void ClearDownValues()
        {
            LabelStatName.Text = string.Empty;
            LabelStatValue.Text = string.Empty;
        }

        public void SetValues(StatCombination stat)
        {
            LabelStatName.Text = stat.Name;
            LabelStatValue.Text = stat.Value.ToString();
        }
    }
}
