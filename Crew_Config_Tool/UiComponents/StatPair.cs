using FS_Crew_Config_Tool.Classes.Listings;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class StatPair : UserControl
    {
        /// <summary>
        /// Accessor for LabelStatName.Text
        /// </summary>
        public string StatName { get { return LabelStatName.Text; } }
        /// <summary>
        /// Accessor for LabelStatValue.Text
        /// </summary>
        public string StatValue { get { return LabelStatValue.Text; } }

        public StatPair()
        {
            InitializeComponent();
            ClearDownValues();
        }

        public void ClearDownValues()
        {
            LabelStatName.Text = string.Empty;
            LabelStatValue.Text = string.Empty;
        }

        public void SetValues(StatCombination stat)
        {
            LabelStatName.Text = stat.Name;
            LabelStatValue.Text = stat.GenerateFormattedStringForDisplay();
        }
    }
}
