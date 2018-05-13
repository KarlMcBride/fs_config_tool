namespace FS_Crew_Config_Tool.UiComponents
{
    partial class AboutForm
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
            this.PictureBoxObi = new System.Windows.Forms.PictureBox();
            this.LabelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxObi)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxObi
            // 
            this.PictureBoxObi.BackgroundImage = global::FS_Crew_Config_Tool.Properties.Resources.ObiwanDog;
            this.PictureBoxObi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxObi.Location = new System.Drawing.Point(342, 139);
            this.PictureBoxObi.Name = "PictureBoxObi";
            this.PictureBoxObi.Size = new System.Drawing.Size(144, 132);
            this.PictureBoxObi.TabIndex = 0;
            this.PictureBoxObi.TabStop = false;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(25, 24);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(69, 13);
            this.LabelVersion.TabIndex = 1;
            this.LabelVersion.Text = "Version: - - - -";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.PictureBoxObi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxObi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxObi;
        private System.Windows.Forms.Label LabelVersion;
    }
}