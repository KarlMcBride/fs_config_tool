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
            this.CheckBoxCrewCag = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewCaptain = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewComms = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewEngineer = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewJump = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewNav = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewRepair = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewTactical = new System.Windows.Forms.CheckBox();
            this.CheckBoxCrewUtility = new System.Windows.Forms.CheckBox();
            this.ListViewFilteredCrew = new System.Windows.Forms.ListView();
            this.ListViewImplants = new System.Windows.Forms.ListView();
            this.CrewSetBoxMain = new FS_Crew_Config_Tool.UiComponents.CrewSetBox();
            this.CheckBoxImpUtil = new System.Windows.Forms.CheckBox();
            this.CheckBoxImpDef = new System.Windows.Forms.CheckBox();
            this.CheckBoxImpAtk = new System.Windows.Forms.CheckBox();
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
            // CheckBoxCrewCag
            // 
            this.CheckBoxCrewCag.AutoSize = true;
            this.CheckBoxCrewCag.Location = new System.Drawing.Point(262, 293);
            this.CheckBoxCrewCag.Name = "CheckBoxCrewCag";
            this.CheckBoxCrewCag.Size = new System.Drawing.Size(48, 17);
            this.CheckBoxCrewCag.TabIndex = 7;
            this.CheckBoxCrewCag.Text = "CAG";
            this.CheckBoxCrewCag.UseVisualStyleBackColor = true;
            this.CheckBoxCrewCag.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewCaptain
            // 
            this.CheckBoxCrewCaptain.AutoSize = true;
            this.CheckBoxCrewCaptain.Location = new System.Drawing.Point(262, 316);
            this.CheckBoxCrewCaptain.Name = "CheckBoxCrewCaptain";
            this.CheckBoxCrewCaptain.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxCrewCaptain.TabIndex = 8;
            this.CheckBoxCrewCaptain.Text = "Captain";
            this.CheckBoxCrewCaptain.UseVisualStyleBackColor = true;
            this.CheckBoxCrewCaptain.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewComms
            // 
            this.CheckBoxCrewComms.AutoSize = true;
            this.CheckBoxCrewComms.Location = new System.Drawing.Point(262, 339);
            this.CheckBoxCrewComms.Name = "CheckBoxCrewComms";
            this.CheckBoxCrewComms.Size = new System.Drawing.Size(60, 17);
            this.CheckBoxCrewComms.TabIndex = 9;
            this.CheckBoxCrewComms.Text = "Comms";
            this.CheckBoxCrewComms.UseVisualStyleBackColor = true;
            this.CheckBoxCrewComms.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewEngineer
            // 
            this.CheckBoxCrewEngineer.AutoSize = true;
            this.CheckBoxCrewEngineer.Location = new System.Drawing.Point(262, 362);
            this.CheckBoxCrewEngineer.Name = "CheckBoxCrewEngineer";
            this.CheckBoxCrewEngineer.Size = new System.Drawing.Size(68, 17);
            this.CheckBoxCrewEngineer.TabIndex = 10;
            this.CheckBoxCrewEngineer.Text = "Engineer";
            this.CheckBoxCrewEngineer.UseVisualStyleBackColor = true;
            this.CheckBoxCrewEngineer.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewJump
            // 
            this.CheckBoxCrewJump.AutoSize = true;
            this.CheckBoxCrewJump.Location = new System.Drawing.Point(262, 385);
            this.CheckBoxCrewJump.Name = "CheckBoxCrewJump";
            this.CheckBoxCrewJump.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxCrewJump.TabIndex = 11;
            this.CheckBoxCrewJump.Text = "Jump";
            this.CheckBoxCrewJump.UseVisualStyleBackColor = true;
            this.CheckBoxCrewJump.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewNav
            // 
            this.CheckBoxCrewNav.AutoSize = true;
            this.CheckBoxCrewNav.Location = new System.Drawing.Point(262, 408);
            this.CheckBoxCrewNav.Name = "CheckBoxCrewNav";
            this.CheckBoxCrewNav.Size = new System.Drawing.Size(46, 17);
            this.CheckBoxCrewNav.TabIndex = 12;
            this.CheckBoxCrewNav.Text = "Nav";
            this.CheckBoxCrewNav.UseVisualStyleBackColor = true;
            this.CheckBoxCrewNav.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewRepair
            // 
            this.CheckBoxCrewRepair.AutoSize = true;
            this.CheckBoxCrewRepair.Location = new System.Drawing.Point(262, 431);
            this.CheckBoxCrewRepair.Name = "CheckBoxCrewRepair";
            this.CheckBoxCrewRepair.Size = new System.Drawing.Size(57, 17);
            this.CheckBoxCrewRepair.TabIndex = 13;
            this.CheckBoxCrewRepair.Text = "Repair";
            this.CheckBoxCrewRepair.UseVisualStyleBackColor = true;
            this.CheckBoxCrewRepair.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewTactical
            // 
            this.CheckBoxCrewTactical.AutoSize = true;
            this.CheckBoxCrewTactical.Location = new System.Drawing.Point(262, 454);
            this.CheckBoxCrewTactical.Name = "CheckBoxCrewTactical";
            this.CheckBoxCrewTactical.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxCrewTactical.TabIndex = 14;
            this.CheckBoxCrewTactical.Text = "Tactical";
            this.CheckBoxCrewTactical.UseVisualStyleBackColor = true;
            this.CheckBoxCrewTactical.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // CheckBoxCrewUtility
            // 
            this.CheckBoxCrewUtility.AutoSize = true;
            this.CheckBoxCrewUtility.Location = new System.Drawing.Point(262, 477);
            this.CheckBoxCrewUtility.Name = "CheckBoxCrewUtility";
            this.CheckBoxCrewUtility.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxCrewUtility.TabIndex = 15;
            this.CheckBoxCrewUtility.Text = "Utility";
            this.CheckBoxCrewUtility.UseVisualStyleBackColor = true;
            this.CheckBoxCrewUtility.CheckedChanged += new System.EventHandler(this.CheckBoxCrewFilters_CheckedChanged);
            // 
            // ListViewFilteredCrew
            // 
            this.ListViewFilteredCrew.Location = new System.Drawing.Point(347, 293);
            this.ListViewFilteredCrew.Name = "ListViewFilteredCrew";
            this.ListViewFilteredCrew.Size = new System.Drawing.Size(662, 201);
            this.ListViewFilteredCrew.TabIndex = 16;
            this.ListViewFilteredCrew.UseCompatibleStateImageBehavior = false;
            this.ListViewFilteredCrew.View = System.Windows.Forms.View.Tile;
            this.ListViewFilteredCrew.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewFilteredCrew_MouseDoubleClick);
            // 
            // ListViewImplants
            // 
            this.ListViewImplants.Location = new System.Drawing.Point(347, 500);
            this.ListViewImplants.Name = "ListViewImplants";
            this.ListViewImplants.Size = new System.Drawing.Size(662, 201);
            this.ListViewImplants.TabIndex = 17;
            this.ListViewImplants.TileSize = new System.Drawing.Size(168, 30);
            this.ListViewImplants.UseCompatibleStateImageBehavior = false;
            // 
            // CrewSetBoxMain
            // 
            this.CrewSetBoxMain.Location = new System.Drawing.Point(241, 7);
            this.CrewSetBoxMain.Name = "CrewSetBoxMain";
            this.CrewSetBoxMain.Size = new System.Drawing.Size(812, 280);
            this.CrewSetBoxMain.TabIndex = 3;
            // 
            // CheckBoxImpUtil
            // 
            this.CheckBoxImpUtil.AutoSize = true;
            this.CheckBoxImpUtil.Location = new System.Drawing.Point(262, 601);
            this.CheckBoxImpUtil.Name = "CheckBoxImpUtil";
            this.CheckBoxImpUtil.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxImpUtil.TabIndex = 20;
            this.CheckBoxImpUtil.Text = "Utility";
            this.CheckBoxImpUtil.UseVisualStyleBackColor = true;
            this.CheckBoxImpUtil.CheckedChanged += new System.EventHandler(this.CheckBoxImplantFilters_CheckedChanged);
            // 
            // CheckBoxImpDef
            // 
            this.CheckBoxImpDef.AutoSize = true;
            this.CheckBoxImpDef.Location = new System.Drawing.Point(262, 578);
            this.CheckBoxImpDef.Name = "CheckBoxImpDef";
            this.CheckBoxImpDef.Size = new System.Drawing.Size(66, 17);
            this.CheckBoxImpDef.TabIndex = 19;
            this.CheckBoxImpDef.Text = "Defense";
            this.CheckBoxImpDef.UseVisualStyleBackColor = true;
            this.CheckBoxImpDef.CheckedChanged += new System.EventHandler(this.CheckBoxImplantFilters_CheckedChanged);
            // 
            // CheckBoxImpAtk
            // 
            this.CheckBoxImpAtk.AutoSize = true;
            this.CheckBoxImpAtk.Location = new System.Drawing.Point(262, 555);
            this.CheckBoxImpAtk.Name = "CheckBoxImpAtk";
            this.CheckBoxImpAtk.Size = new System.Drawing.Size(57, 17);
            this.CheckBoxImpAtk.TabIndex = 18;
            this.CheckBoxImpAtk.Text = "Attack";
            this.CheckBoxImpAtk.UseVisualStyleBackColor = true;
            this.CheckBoxImpAtk.CheckedChanged += new System.EventHandler(this.CheckBoxImplantFilters_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 821);
            this.Controls.Add(this.CheckBoxImpUtil);
            this.Controls.Add(this.CheckBoxImpDef);
            this.Controls.Add(this.CheckBoxImpAtk);
            this.Controls.Add(this.ListViewImplants);
            this.Controls.Add(this.ListViewFilteredCrew);
            this.Controls.Add(this.CheckBoxCrewUtility);
            this.Controls.Add(this.CheckBoxCrewTactical);
            this.Controls.Add(this.CheckBoxCrewRepair);
            this.Controls.Add(this.CheckBoxCrewNav);
            this.Controls.Add(this.CheckBoxCrewJump);
            this.Controls.Add(this.CheckBoxCrewEngineer);
            this.Controls.Add(this.CheckBoxCrewComms);
            this.Controls.Add(this.CheckBoxCrewCaptain);
            this.Controls.Add(this.CheckBoxCrewCag);
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
        private System.Windows.Forms.CheckBox CheckBoxCrewCag;
        private System.Windows.Forms.CheckBox CheckBoxCrewCaptain;
        private System.Windows.Forms.CheckBox CheckBoxCrewComms;
        private System.Windows.Forms.CheckBox CheckBoxCrewEngineer;
        private System.Windows.Forms.CheckBox CheckBoxCrewJump;
        private System.Windows.Forms.CheckBox CheckBoxCrewNav;
        private System.Windows.Forms.CheckBox CheckBoxCrewRepair;
        private System.Windows.Forms.CheckBox CheckBoxCrewTactical;
        private System.Windows.Forms.CheckBox CheckBoxCrewUtility;
        private System.Windows.Forms.ListView ListViewFilteredCrew;
        private System.Windows.Forms.ListView ListViewImplants;
        private System.Windows.Forms.CheckBox CheckBoxImpUtil;
        private System.Windows.Forms.CheckBox CheckBoxImpDef;
        private System.Windows.Forms.CheckBox CheckBoxImpAtk;
    }
}

