using FS_Crew_Config_Tool.Classes.Listings;
using System.Drawing;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class ShipSelector : Form
    {
        public ShipSelector()
        {
            InitializeComponent();
            ConfigureToolTip();
            AddCheckBoxes();
        }

        private void AddCheckBoxes()
        {
            Point startingPoint = new Point(40, 50);
            Point shiftingPoint = startingPoint;

            for (int index = 0; index < (int)ShipEnum.END_OF_LIST; index++)
            {
                if (index == (int)ShipEnum.ENDEAVOUR || index == (int)ShipEnum.INTERCEPTOR || index == (int)ShipEnum.RANGER)
                {
                    shiftingPoint.X += 110;
                    shiftingPoint.Y = startingPoint.Y;
                }

                CheckBox checkBox = new CheckBox();
                checkBox.Name = "CheckBox" + ShipList.ShipListing[index].ID;
                checkBox.Text = ShipList.ShipListing[index].Name;

                checkBox.Location = shiftingPoint;

                shiftingPoint.Y += 20;

                this.Controls.Add(checkBox);
            }
        }

        private void ConfigureToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ButtonSmartSelect , "Selects all ships that aren't named within a config.\n" +
                                                      "E.g. if you don't have a crew named enforcer, this will,\n" +
                                                      "select enforcer automatically.\n");
        }
    }
}
