namespace FS_Crew_Config_Tool.UiComponents
{
    partial class StatsBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelAttack = new System.Windows.Forms.Panel();
            this.GroupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxStatistics
            // 
            this.GroupBoxStatistics.Controls.Add(this.panel2);
            this.GroupBoxStatistics.Controls.Add(this.panel1);
            this.GroupBoxStatistics.Controls.Add(this.PanelAttack);
            this.GroupBoxStatistics.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxStatistics.Name = "GroupBoxStatistics";
            this.GroupBoxStatistics.Size = new System.Drawing.Size(505, 271);
            this.GroupBoxStatistics.TabIndex = 24;
            this.GroupBoxStatistics.TabStop = false;
            this.GroupBoxStatistics.Text = "Statistics";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(338, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 248);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.panel1.Location = new System.Drawing.Point(172, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 248);
            this.panel1.TabIndex = 1;
            // 
            // PanelAttack
            // 
            this.PanelAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.PanelAttack.Location = new System.Drawing.Point(6, 19);
            this.PanelAttack.Name = "PanelAttack";
            this.PanelAttack.Size = new System.Drawing.Size(160, 248);
            this.PanelAttack.TabIndex = 0;
            // 
            // StatsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxStatistics);
            this.Name = "StatsBox";
            this.Size = new System.Drawing.Size(511, 279);
            this.GroupBoxStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxStatistics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelAttack;
    }
}
