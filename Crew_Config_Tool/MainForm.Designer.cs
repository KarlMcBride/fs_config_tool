namespace FS_Crew_Config_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListBoxCrews = new System.Windows.Forms.ListBox();
            this.ButtonSortAlpha = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelFsRunningWarning = new System.Windows.Forms.Label();
            this.labelCcuCount = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.RadioButtonCrewCag = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewCaptain = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewComms = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewEngineer = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewJump = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewNav = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewRepair = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewTactical = new System.Windows.Forms.RadioButton();
            this.RadioButtonCrewUtility = new System.Windows.Forms.RadioButton();
            this.ListViewFilteredCrew = new System.Windows.Forms.ListView();
            this.ListViewImplants = new System.Windows.Forms.ListView();
            this.RadioButtonImpUtil = new System.Windows.Forms.RadioButton();
            this.RadioButtonImpDef = new System.Windows.Forms.RadioButton();
            this.RadioButtonImpAtk = new System.Windows.Forms.RadioButton();
            this.GroupBoxCrewMembers = new System.Windows.Forms.GroupBox();
            this.GroupBoxImplants = new System.Windows.Forms.GroupBox();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonRenameSelected = new System.Windows.Forms.Button();
            this.StatsBox = new FS_Crew_Config_Tool.UiComponents.StatsBox();
            this.CrewSetBoxMain = new FS_Crew_Config_Tool.UiComponents.CrewSetBox();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.GroupBoxCrewMembers.SuspendLayout();
            this.GroupBoxImplants.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxCrews
            // 
            this.ListBoxCrews.FormattingEnabled = true;
            this.ListBoxCrews.Location = new System.Drawing.Point(12, 109);
            this.ListBoxCrews.Name = "ListBoxCrews";
            this.ListBoxCrews.Size = new System.Drawing.Size(228, 589);
            this.ListBoxCrews.TabIndex = 5;
            this.ListBoxCrews.SelectedIndexChanged += new System.EventHandler(this.ListBoxCrews_SelectedIndexChanged);
            // 
            // ButtonSortAlpha
            // 
            this.ButtonSortAlpha.Location = new System.Drawing.Point(131, 38);
            this.ButtonSortAlpha.Name = "ButtonSortAlpha";
            this.ButtonSortAlpha.Size = new System.Drawing.Size(109, 23);
            this.ButtonSortAlpha.TabIndex = 4;
            this.ButtonSortAlpha.Text = "Sort Alphabetically";
            this.ButtonSortAlpha.UseVisualStyleBackColor = true;
            this.ButtonSortAlpha.Click += new System.EventHandler(this.ButtonSortAlpha_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(90, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(72, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelFsRunningWarning
            // 
            this.LabelFsRunningWarning.AutoSize = true;
            this.LabelFsRunningWarning.Location = new System.Drawing.Point(1427, 639);
            this.LabelFsRunningWarning.Name = "LabelFsRunningWarning";
            this.LabelFsRunningWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelFsRunningWarning.TabIndex = 10;
            this.LabelFsRunningWarning.Text = "FS is Running";
            // 
            // labelCcuCount
            // 
            this.labelCcuCount.AutoSize = true;
            this.labelCcuCount.Location = new System.Drawing.Point(1506, 639);
            this.labelCcuCount.Name = "labelCcuCount";
            this.labelCcuCount.Size = new System.Drawing.Size(56, 13);
            this.labelCcuCount.TabIndex = 11;
            this.labelCcuCount.TabStop = true;
            this.labelCcuCount.Text = "CCU: - - - -";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(168, 9);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(72, 23);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // RadioButtonCrewCag
            // 
            this.RadioButtonCrewCag.AutoSize = true;
            this.RadioButtonCrewCag.Location = new System.Drawing.Point(6, 88);
            this.RadioButtonCrewCag.Name = "RadioButtonCrewCag";
            this.RadioButtonCrewCag.Size = new System.Drawing.Size(47, 17);
            this.RadioButtonCrewCag.TabIndex = 0;
            this.RadioButtonCrewCag.Text = "CAG";
            this.RadioButtonCrewCag.UseVisualStyleBackColor = true;
            this.RadioButtonCrewCag.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewCaptain
            // 
            this.RadioButtonCrewCaptain.AutoSize = true;
            this.RadioButtonCrewCaptain.Location = new System.Drawing.Point(6, 111);
            this.RadioButtonCrewCaptain.Name = "RadioButtonCrewCaptain";
            this.RadioButtonCrewCaptain.Size = new System.Drawing.Size(61, 17);
            this.RadioButtonCrewCaptain.TabIndex = 1;
            this.RadioButtonCrewCaptain.Text = "Captain";
            this.RadioButtonCrewCaptain.UseVisualStyleBackColor = true;
            this.RadioButtonCrewCaptain.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewComms
            // 
            this.RadioButtonCrewComms.AutoSize = true;
            this.RadioButtonCrewComms.Location = new System.Drawing.Point(6, 134);
            this.RadioButtonCrewComms.Name = "RadioButtonCrewComms";
            this.RadioButtonCrewComms.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonCrewComms.TabIndex = 2;
            this.RadioButtonCrewComms.Text = "Comms";
            this.RadioButtonCrewComms.UseVisualStyleBackColor = true;
            this.RadioButtonCrewComms.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewEngineer
            // 
            this.RadioButtonCrewEngineer.AutoSize = true;
            this.RadioButtonCrewEngineer.Location = new System.Drawing.Point(6, 157);
            this.RadioButtonCrewEngineer.Name = "RadioButtonCrewEngineer";
            this.RadioButtonCrewEngineer.Size = new System.Drawing.Size(67, 17);
            this.RadioButtonCrewEngineer.TabIndex = 3;
            this.RadioButtonCrewEngineer.Text = "Engineer";
            this.RadioButtonCrewEngineer.UseVisualStyleBackColor = true;
            this.RadioButtonCrewEngineer.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewJump
            // 
            this.RadioButtonCrewJump.AutoSize = true;
            this.RadioButtonCrewJump.Location = new System.Drawing.Point(6, 180);
            this.RadioButtonCrewJump.Name = "RadioButtonCrewJump";
            this.RadioButtonCrewJump.Size = new System.Drawing.Size(50, 17);
            this.RadioButtonCrewJump.TabIndex = 4;
            this.RadioButtonCrewJump.Text = "Jump";
            this.RadioButtonCrewJump.UseVisualStyleBackColor = true;
            this.RadioButtonCrewJump.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewNav
            // 
            this.RadioButtonCrewNav.AutoSize = true;
            this.RadioButtonCrewNav.Location = new System.Drawing.Point(6, 203);
            this.RadioButtonCrewNav.Name = "RadioButtonCrewNav";
            this.RadioButtonCrewNav.Size = new System.Drawing.Size(45, 17);
            this.RadioButtonCrewNav.TabIndex = 5;
            this.RadioButtonCrewNav.Text = "Nav";
            this.RadioButtonCrewNav.UseVisualStyleBackColor = true;
            this.RadioButtonCrewNav.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewRepair
            // 
            this.RadioButtonCrewRepair.AutoSize = true;
            this.RadioButtonCrewRepair.Location = new System.Drawing.Point(6, 226);
            this.RadioButtonCrewRepair.Name = "RadioButtonCrewRepair";
            this.RadioButtonCrewRepair.Size = new System.Drawing.Size(56, 17);
            this.RadioButtonCrewRepair.TabIndex = 6;
            this.RadioButtonCrewRepair.Text = "Repair";
            this.RadioButtonCrewRepair.UseVisualStyleBackColor = true;
            this.RadioButtonCrewRepair.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewTactical
            // 
            this.RadioButtonCrewTactical.AutoSize = true;
            this.RadioButtonCrewTactical.Location = new System.Drawing.Point(6, 249);
            this.RadioButtonCrewTactical.Name = "RadioButtonCrewTactical";
            this.RadioButtonCrewTactical.Size = new System.Drawing.Size(63, 17);
            this.RadioButtonCrewTactical.TabIndex = 7;
            this.RadioButtonCrewTactical.Text = "Tactical";
            this.RadioButtonCrewTactical.UseVisualStyleBackColor = true;
            this.RadioButtonCrewTactical.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // RadioButtonCrewUtility
            // 
            this.RadioButtonCrewUtility.AutoSize = true;
            this.RadioButtonCrewUtility.Location = new System.Drawing.Point(6, 272);
            this.RadioButtonCrewUtility.Name = "RadioButtonCrewUtility";
            this.RadioButtonCrewUtility.Size = new System.Drawing.Size(50, 17);
            this.RadioButtonCrewUtility.TabIndex = 8;
            this.RadioButtonCrewUtility.Text = "Utility";
            this.RadioButtonCrewUtility.UseVisualStyleBackColor = true;
            this.RadioButtonCrewUtility.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // ListViewFilteredCrew
            // 
            this.ListViewFilteredCrew.Location = new System.Drawing.Point(85, 19);
            this.ListViewFilteredCrew.MultiSelect = false;
            this.ListViewFilteredCrew.Name = "ListViewFilteredCrew";
            this.ListViewFilteredCrew.Size = new System.Drawing.Size(551, 377);
            this.ListViewFilteredCrew.TabIndex = 9;
            this.ListViewFilteredCrew.UseCompatibleStateImageBehavior = false;
            this.ListViewFilteredCrew.View = System.Windows.Forms.View.Tile;
            this.ListViewFilteredCrew.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewFilteredCrew_MouseDoubleClick);
            // 
            // ListViewImplants
            // 
            this.ListViewImplants.Location = new System.Drawing.Point(85, 19);
            this.ListViewImplants.MultiSelect = false;
            this.ListViewImplants.Name = "ListViewImplants";
            this.ListViewImplants.Size = new System.Drawing.Size(383, 377);
            this.ListViewImplants.TabIndex = 3;
            this.ListViewImplants.TileSize = new System.Drawing.Size(168, 30);
            this.ListViewImplants.UseCompatibleStateImageBehavior = false;
            this.ListViewImplants.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewImplants_MouseDoubleClick);
            // 
            // RadioButtonImpUtil
            // 
            this.RadioButtonImpUtil.AutoSize = true;
            this.RadioButtonImpUtil.Location = new System.Drawing.Point(6, 203);
            this.RadioButtonImpUtil.Name = "RadioButtonImpUtil";
            this.RadioButtonImpUtil.Size = new System.Drawing.Size(50, 17);
            this.RadioButtonImpUtil.TabIndex = 2;
            this.RadioButtonImpUtil.Text = "Utility";
            this.RadioButtonImpUtil.UseVisualStyleBackColor = true;
            this.RadioButtonImpUtil.CheckedChanged += new System.EventHandler(this.CheckBoxImplantFilters_CheckedChanged);
            // 
            // RadioButtonImpDef
            // 
            this.RadioButtonImpDef.AutoSize = true;
            this.RadioButtonImpDef.Location = new System.Drawing.Point(6, 180);
            this.RadioButtonImpDef.Name = "RadioButtonImpDef";
            this.RadioButtonImpDef.Size = new System.Drawing.Size(65, 17);
            this.RadioButtonImpDef.TabIndex = 1;
            this.RadioButtonImpDef.Text = "Defense";
            this.RadioButtonImpDef.UseVisualStyleBackColor = true;
            this.RadioButtonImpDef.CheckedChanged += new System.EventHandler(this.CheckBoxImplantFilters_CheckedChanged);
            // 
            // RadioButtonImpAtk
            // 
            this.RadioButtonImpAtk.AutoSize = true;
            this.RadioButtonImpAtk.Location = new System.Drawing.Point(6, 157);
            this.RadioButtonImpAtk.Name = "RadioButtonImpAtk";
            this.RadioButtonImpAtk.Size = new System.Drawing.Size(56, 17);
            this.RadioButtonImpAtk.TabIndex = 0;
            this.RadioButtonImpAtk.Text = "Attack";
            this.RadioButtonImpAtk.UseVisualStyleBackColor = true;
            this.RadioButtonImpAtk.CheckedChanged += new System.EventHandler(this.CheckBoxImplantFilters_CheckedChanged);
            // 
            // GroupBoxCrewMembers
            // 
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewCag);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewCaptain);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewComms);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewEngineer);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewJump);
            this.GroupBoxCrewMembers.Controls.Add(this.ListViewFilteredCrew);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewNav);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewUtility);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewRepair);
            this.GroupBoxCrewMembers.Controls.Add(this.RadioButtonCrewTactical);
            this.GroupBoxCrewMembers.Location = new System.Drawing.Point(262, 296);
            this.GroupBoxCrewMembers.Name = "GroupBoxCrewMembers";
            this.GroupBoxCrewMembers.Size = new System.Drawing.Size(642, 403);
            this.GroupBoxCrewMembers.TabIndex = 8;
            this.GroupBoxCrewMembers.TabStop = false;
            this.GroupBoxCrewMembers.Text = "Crew Members";
            // 
            // GroupBoxImplants
            // 
            this.GroupBoxImplants.Controls.Add(this.RadioButtonImpAtk);
            this.GroupBoxImplants.Controls.Add(this.RadioButtonImpDef);
            this.GroupBoxImplants.Controls.Add(this.ListViewImplants);
            this.GroupBoxImplants.Controls.Add(this.RadioButtonImpUtil);
            this.GroupBoxImplants.Location = new System.Drawing.Point(927, 296);
            this.GroupBoxImplants.Name = "GroupBoxImplants";
            this.GroupBoxImplants.Size = new System.Drawing.Size(474, 403);
            this.GroupBoxImplants.TabIndex = 9;
            this.GroupBoxImplants.TabStop = false;
            this.GroupBoxImplants.Text = "Implants";
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(12, 9);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(72, 23);
            this.ButtonNew.TabIndex = 0;
            this.ButtonNew.Text = "Create New";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(12, 38);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(109, 23);
            this.ButtonGenerate.TabIndex = 3;
            this.ButtonGenerate.Text = "Generate Multiple";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonRenameSelected
            // 
            this.ButtonRenameSelected.Location = new System.Drawing.Point(12, 80);
            this.ButtonRenameSelected.Name = "ButtonRenameSelected";
            this.ButtonRenameSelected.Size = new System.Drawing.Size(228, 23);
            this.ButtonRenameSelected.TabIndex = 12;
            this.ButtonRenameSelected.Text = "Rename Selected Crew";
            this.ButtonRenameSelected.UseVisualStyleBackColor = true;
            this.ButtonRenameSelected.Click += new System.EventHandler(this.ButtonRenameSelected_Click);
            // 
            // StatsBox
            // 
            this.StatsBox.AutoSize = true;
            this.StatsBox.Location = new System.Drawing.Point(1078, 2);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(492, 281);
            this.StatsBox.TabIndex = 7;
            // 
            // CrewSetBoxMain
            // 
            this.CrewSetBoxMain.Location = new System.Drawing.Point(259, 12);
            this.CrewSetBoxMain.Name = "CrewSetBoxMain";
            this.CrewSetBoxMain.Size = new System.Drawing.Size(812, 270);
            this.CrewSetBoxMain.TabIndex = 6;
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Location = new System.Drawing.Point(1430, 668);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(132, 23);
            this.ButtonAbout.TabIndex = 13;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 703);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.ButtonRenameSelected);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.StatsBox);
            this.Controls.Add(this.GroupBoxImplants);
            this.Controls.Add(this.GroupBoxCrewMembers);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.labelCcuCount);
            this.Controls.Add(this.LabelFsRunningWarning);
            this.Controls.Add(this.CrewSetBoxMain);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonSortAlpha);
            this.Controls.Add(this.ListBoxCrews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FS Crew Config Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxCrewMembers.ResumeLayout(false);
            this.GroupBoxCrewMembers.PerformLayout();
            this.GroupBoxImplants.ResumeLayout(false);
            this.GroupBoxImplants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxCrews;
        private System.Windows.Forms.Button ButtonSortAlpha;
        private System.Windows.Forms.Button ButtonSave;
        private UiComponents.CrewSetBox CrewSetBoxMain;
        private System.Windows.Forms.Label LabelFsRunningWarning;
        private System.Windows.Forms.Label labelCcuCount;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.RadioButton RadioButtonCrewCag;
        private System.Windows.Forms.RadioButton RadioButtonCrewCaptain;
        private System.Windows.Forms.RadioButton RadioButtonCrewComms;
        private System.Windows.Forms.RadioButton RadioButtonCrewEngineer;
        private System.Windows.Forms.RadioButton RadioButtonCrewJump;
        private System.Windows.Forms.RadioButton RadioButtonCrewNav;
        private System.Windows.Forms.RadioButton RadioButtonCrewRepair;
        private System.Windows.Forms.RadioButton RadioButtonCrewTactical;
        private System.Windows.Forms.RadioButton RadioButtonCrewUtility;
        private System.Windows.Forms.ListView ListViewFilteredCrew;
        private System.Windows.Forms.ListView ListViewImplants;
        private System.Windows.Forms.RadioButton RadioButtonImpUtil;
        private System.Windows.Forms.RadioButton RadioButtonImpDef;
        private System.Windows.Forms.RadioButton RadioButtonImpAtk;
        private System.Windows.Forms.GroupBox GroupBoxCrewMembers;
        private System.Windows.Forms.GroupBox GroupBoxImplants;
        private UiComponents.StatsBox StatsBox;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button ButtonRenameSelected;
        private System.Windows.Forms.Button ButtonAbout;
    }
}

