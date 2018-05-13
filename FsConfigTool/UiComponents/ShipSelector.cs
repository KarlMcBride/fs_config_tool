using FS_Crew_Config_Tool.Classes.Listings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class ShipSelector : Form
    {
        private CheckBox[] checkboxArray;

        public event EventHandler<ShipArgs> GenerateButtonClicked;

        public ShipSelector()
        {
            InitializeComponent();
            AddCheckBoxes();
        }

        private void AddCheckBoxes()
        {
            Point startingPoint = new Point(40, 50);
            Point shiftingPoint = startingPoint;

            checkboxArray = new CheckBox[(int)ShipEnum.END_OF_LIST];

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

                Controls.Add(checkBox);
                checkboxArray[index] = checkBox;
            }
        }

        private void ButtonSelectAll_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = sender as Button;

            bool markAsChecked = (clickedButton.Name.Equals(ButtonSelectAll.Name));

            for (int index = 0; index < (int)ShipEnum.END_OF_LIST; index++)
            {
                checkboxArray[index].Checked = markAsChecked;
            }
        }

        private void ButtonGenerate_Click(object sender, System.EventArgs e)
        {
            if (GenerateButtonClicked != null)
            {
                ShipArgs args = new ShipArgs(checkboxArray);

                GenerateButtonClicked(this, args);
            }

            Close();
        }
    }
}
