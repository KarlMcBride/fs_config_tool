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
            this.CrewSetBoxMain = new FS_Crew_Config_Tool.UiComponents.CrewSetBox();
            this.LabelFsRunningWarning = new System.Windows.Forms.Label();
            this.labelCcuCount = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxCrews
            // 
            this.ListBoxCrews.FormattingEnabled = true;
            this.ListBoxCrews.Location = new System.Drawing.Point(12, 38);
            this.ListBoxCrews.Name = "ListBoxCrews";
            this.ListBoxCrews.Size = new System.Drawing.Size(223, 394);
            this.ListBoxCrews.TabIndex = 0;
            this.ListBoxCrews.SelectedIndexChanged += new System.EventHandler(this.ListBoxCrews_SelectedIndexChanged);
            // 
            // ButtonSortAlpha
            // 
            this.ButtonSortAlpha.Location = new System.Drawing.Point(12, 9);
            this.ButtonSortAlpha.Name = "ButtonSortAlpha";
            this.ButtonSortAlpha.Size = new System.Drawing.Size(108, 23);
            this.ButtonSortAlpha.TabIndex = 1;
            this.ButtonSortAlpha.Text = "Sort Alphabetically";
            this.ButtonSortAlpha.UseVisualStyleBackColor = true;
            this.ButtonSortAlpha.Click += new System.EventHandler(this.ButtonSortAlpha_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(127, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(108, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CrewSetBoxMain
            // 
            this.CrewSetBoxMain.Location = new System.Drawing.Point(241, 7);
            this.CrewSetBoxMain.Name = "CrewSetBoxMain";
            this.CrewSetBoxMain.Size = new System.Drawing.Size(812, 289);
            this.CrewSetBoxMain.TabIndex = 3;
            // 
            // LabelFsRunningWarning
            // 
            this.LabelFsRunningWarning.AutoSize = true;
            this.LabelFsRunningWarning.Location = new System.Drawing.Point(910, 447);
            this.LabelFsRunningWarning.Name = "LabelFsRunningWarning";
            this.LabelFsRunningWarning.Size = new System.Drawing.Size(73, 13);
            this.LabelFsRunningWarning.TabIndex = 4;
            this.LabelFsRunningWarning.Text = "FS is Running";
            // 
            // labelCcuCount
            // 
            this.labelCcuCount.AutoSize = true;
            this.labelCcuCount.Location = new System.Drawing.Point(989, 447);
            this.labelCcuCount.Name = "labelCcuCount";
            this.labelCcuCount.Size = new System.Drawing.Size(56, 13);
            this.labelCcuCount.TabIndex = 5;
            this.labelCcuCount.TabStop = true;
            this.labelCcuCount.Text = "CCU: - - - -";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(12, 438);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(223, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 469);
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
    }
}

