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
            this.CheckBoxCag = new System.Windows.Forms.CheckBox();
            this.CheckBoxCaptain = new System.Windows.Forms.CheckBox();
            this.CheckBoxComms = new System.Windows.Forms.CheckBox();
            this.CheckBoxEngineer = new System.Windows.Forms.CheckBox();
            this.CheckBoxJump = new System.Windows.Forms.CheckBox();
            this.CheckBoxNav = new System.Windows.Forms.CheckBox();
            this.CheckBoxRepair = new System.Windows.Forms.CheckBox();
            this.CheckBoxTactical = new System.Windows.Forms.CheckBox();
            this.CheckBoxUtility = new System.Windows.Forms.CheckBox();
            this.ListViewFilteredCrew = new System.Windows.Forms.ListView();
            this.CrewSetBoxMain = new FS_Crew_Config_Tool.UiComponents.CrewSetBox();
            this.SuspendLayout();
            // 
            // ListBoxCrews
            // 
            this.ListBoxCrews.FormattingEnabled = true;
            this.ListBoxCrews.Location = new System.Drawing.Point(12, 70);
            this.ListBoxCrews.Name = "ListBoxCrews";
            this.ListBoxCrews.Size = new System.Drawing.Size(223, 511);
            this.ListBoxCrews.TabIndex = 0;
            this.ListBoxCrews.SelectedIndexChanged += new System.EventHandler(this.ListBoxCrews_SelectedIndexChanged);
            // 
            // ButtonSortAlpha
            // 
            this.ButtonSortAlpha.Location = new System.Drawing.Point(11, 9);
            this.ButtonSortAlpha.Name = "ButtonSortAlpha";
            this.ButtonSortAlpha.Size = new System.Drawing.Size(109, 23);
            this.ButtonSortAlpha.TabIndex = 1;
            this.ButtonSortAlpha.Text = "Sort Alphabetically";
            this.ButtonSortAlpha.UseVisualStyleBackColor = true;
            this.ButtonSortAlpha.Click += new System.EventHandler(this.ButtonSortAlpha_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(127, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(109, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelFsRunningWarning
            // 
            this.LabelFsRunningWarning.AutoSize = true;
            this.LabelFsRunningWarning.Location = new System.Drawing.Point(910, 799);
            this.LabelFsRunningWarning.Name = "LabelFsRunningWarning";
            this.LabelFsRunningWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelFsRunningWarning.TabIndex = 4;
            this.LabelFsRunningWarning.Text = "FS is Running";
            // 
            // labelCcuCount
            // 
            this.labelCcuCount.AutoSize = true;
            this.labelCcuCount.Location = new System.Drawing.Point(989, 799);
            this.labelCcuCount.Name = "labelCcuCount";
            this.labelCcuCount.Size = new System.Drawing.Size(56, 13);
            this.labelCcuCount.TabIndex = 5;
            this.labelCcuCount.TabStop = true;
            this.labelCcuCount.Text = "CCU: - - - -";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(11, 38);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(225, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // CheckBoxCag
            // 
            this.CheckBoxCag.AutoSize = true;
            this.CheckBoxCag.Location = new System.Drawing.Point(251, 293);
            this.CheckBoxCag.Name = "CheckBoxCag";
            this.CheckBoxCag.Size = new System.Drawing.Size(48, 17);
            this.CheckBoxCag.TabIndex = 7;
            this.CheckBoxCag.Text = "CAG";
            this.CheckBoxCag.UseVisualStyleBackColor = true;
            this.CheckBoxCag.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxCaptain
            // 
            this.CheckBoxCaptain.AutoSize = true;
            this.CheckBoxCaptain.Location = new System.Drawing.Point(251, 316);
            this.CheckBoxCaptain.Name = "CheckBoxCaptain";
            this.CheckBoxCaptain.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxCaptain.TabIndex = 8;
            this.CheckBoxCaptain.Text = "Captain";
            this.CheckBoxCaptain.UseVisualStyleBackColor = true;
            this.CheckBoxCaptain.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxComms
            // 
            this.CheckBoxComms.AutoSize = true;
            this.CheckBoxComms.Location = new System.Drawing.Point(251, 339);
            this.CheckBoxComms.Name = "CheckBoxComms";
            this.CheckBoxComms.Size = new System.Drawing.Size(60, 17);
            this.CheckBoxComms.TabIndex = 9;
            this.CheckBoxComms.Text = "Comms";
            this.CheckBoxComms.UseVisualStyleBackColor = true;
            this.CheckBoxComms.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxEngineer
            // 
            this.CheckBoxEngineer.AutoSize = true;
            this.CheckBoxEngineer.Location = new System.Drawing.Point(251, 362);
            this.CheckBoxEngineer.Name = "CheckBoxEngineer";
            this.CheckBoxEngineer.Size = new System.Drawing.Size(68, 17);
            this.CheckBoxEngineer.TabIndex = 10;
            this.CheckBoxEngineer.Text = "Engineer";
            this.CheckBoxEngineer.UseVisualStyleBackColor = true;
            this.CheckBoxEngineer.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxJump
            // 
            this.CheckBoxJump.AutoSize = true;
            this.CheckBoxJump.Location = new System.Drawing.Point(251, 385);
            this.CheckBoxJump.Name = "CheckBoxJump";
            this.CheckBoxJump.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxJump.TabIndex = 11;
            this.CheckBoxJump.Text = "Jump";
            this.CheckBoxJump.UseVisualStyleBackColor = true;
            this.CheckBoxJump.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxNav
            // 
            this.CheckBoxNav.AutoSize = true;
            this.CheckBoxNav.Location = new System.Drawing.Point(251, 408);
            this.CheckBoxNav.Name = "CheckBoxNav";
            this.CheckBoxNav.Size = new System.Drawing.Size(46, 17);
            this.CheckBoxNav.TabIndex = 12;
            this.CheckBoxNav.Text = "Nav";
            this.CheckBoxNav.UseVisualStyleBackColor = true;
            this.CheckBoxNav.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxRepair
            // 
            this.CheckBoxRepair.AutoSize = true;
            this.CheckBoxRepair.Location = new System.Drawing.Point(251, 431);
            this.CheckBoxRepair.Name = "CheckBoxRepair";
            this.CheckBoxRepair.Size = new System.Drawing.Size(57, 17);
            this.CheckBoxRepair.TabIndex = 13;
            this.CheckBoxRepair.Text = "Repair";
            this.CheckBoxRepair.UseVisualStyleBackColor = true;
            this.CheckBoxRepair.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxTactical
            // 
            this.CheckBoxTactical.AutoSize = true;
            this.CheckBoxTactical.Location = new System.Drawing.Point(251, 454);
            this.CheckBoxTactical.Name = "CheckBoxTactical";
            this.CheckBoxTactical.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxTactical.TabIndex = 14;
            this.CheckBoxTactical.Text = "Tactical";
            this.CheckBoxTactical.UseVisualStyleBackColor = true;
            this.CheckBoxTactical.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // CheckBoxUtility
            // 
            this.CheckBoxUtility.AutoSize = true;
            this.CheckBoxUtility.Location = new System.Drawing.Point(251, 477);
            this.CheckBoxUtility.Name = "CheckBoxUtility";
            this.CheckBoxUtility.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxUtility.TabIndex = 15;
            this.CheckBoxUtility.Text = "Utility";
            this.CheckBoxUtility.UseVisualStyleBackColor = true;
            this.CheckBoxUtility.CheckedChanged += new System.EventHandler(this.CheckBoxFilters_CheckedChanged);
            // 
            // ListViewFilteredCrew
            // 
            this.ListViewFilteredCrew.Location = new System.Drawing.Point(347, 293);
            this.ListViewFilteredCrew.Name = "ListViewFilteredCrew";
            this.ListViewFilteredCrew.Size = new System.Drawing.Size(662, 377);
            this.ListViewFilteredCrew.TabIndex = 16;
            this.ListViewFilteredCrew.UseCompatibleStateImageBehavior = false;
            this.ListViewFilteredCrew.View = System.Windows.Forms.View.Tile;
            // 
            // CrewSetBoxMain
            // 
            this.CrewSetBoxMain.Location = new System.Drawing.Point(241, 7);
            this.CrewSetBoxMain.Name = "CrewSetBoxMain";
            this.CrewSetBoxMain.Size = new System.Drawing.Size(812, 289);
            this.CrewSetBoxMain.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 821);
            this.Controls.Add(this.ListViewFilteredCrew);
            this.Controls.Add(this.CheckBoxUtility);
            this.Controls.Add(this.CheckBoxTactical);
            this.Controls.Add(this.CheckBoxRepair);
            this.Controls.Add(this.CheckBoxNav);
            this.Controls.Add(this.CheckBoxJump);
            this.Controls.Add(this.CheckBoxEngineer);
            this.Controls.Add(this.CheckBoxComms);
            this.Controls.Add(this.CheckBoxCaptain);
            this.Controls.Add(this.CheckBoxCag);
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
        private System.Windows.Forms.CheckBox CheckBoxCag;
        private System.Windows.Forms.CheckBox CheckBoxCaptain;
        private System.Windows.Forms.CheckBox CheckBoxComms;
        private System.Windows.Forms.CheckBox CheckBoxEngineer;
        private System.Windows.Forms.CheckBox CheckBoxJump;
        private System.Windows.Forms.CheckBox CheckBoxNav;
        private System.Windows.Forms.CheckBox CheckBoxRepair;
        private System.Windows.Forms.CheckBox CheckBoxTactical;
        private System.Windows.Forms.CheckBox CheckBoxUtility;
        private System.Windows.Forms.ListView ListViewFilteredCrew;
    }
}

