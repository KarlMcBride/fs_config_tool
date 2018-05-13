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
            this.LinkLabelFeedback = new System.Windows.Forms.LinkLabel();
            this.LabelFeedback = new System.Windows.Forms.Label();
            this.LabelOpenSource = new System.Windows.Forms.Label();
            this.LinkLabelGitHub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxObi)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxObi
            // 
            this.PictureBoxObi.BackgroundImage = global::FS_Crew_Config_Tool.Properties.Resources.ObiwanDog;
            this.PictureBoxObi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxObi.Location = new System.Drawing.Point(296, 12);
            this.PictureBoxObi.Name = "PictureBoxObi";
            this.PictureBoxObi.Size = new System.Drawing.Size(141, 132);
            this.PictureBoxObi.TabIndex = 0;
            this.PictureBoxObi.TabStop = false;
            this.PictureBoxObi.Click += new System.EventHandler(this.PictureBoxObi_Click);
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
            // LinkLabelFeedback
            // 
            this.LinkLabelFeedback.AutoSize = true;
            this.LinkLabelFeedback.Location = new System.Drawing.Point(73, 66);
            this.LinkLabelFeedback.Name = "LinkLabelFeedback";
            this.LinkLabelFeedback.Size = new System.Drawing.Size(28, 13);
            this.LinkLabelFeedback.TabIndex = 2;
            this.LinkLabelFeedback.TabStop = true;
            this.LinkLabelFeedback.Text = "here";
            this.LinkLabelFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelFeedback_LinkClicked);
            // 
            // LabelFeedback
            // 
            this.LabelFeedback.Location = new System.Drawing.Point(25, 53);
            this.LabelFeedback.Name = "LabelFeedback";
            this.LabelFeedback.Size = new System.Drawing.Size(248, 28);
            this.LabelFeedback.TabIndex = 3;
            this.LabelFeedback.Text = "Feedback, suggestions and bug reports are welcome";
            // 
            // LabelOpenSource
            // 
            this.LabelOpenSource.Location = new System.Drawing.Point(25, 101);
            this.LabelOpenSource.Name = "LabelOpenSource";
            this.LabelOpenSource.Size = new System.Drawing.Size(262, 43);
            this.LabelOpenSource.TabIndex = 4;
            this.LabelOpenSource.Text = "Thank you for taking the time to try out my config tool. This project is hosted o" +
    "n ";
            // 
            // LinkLabelGitHub
            // 
            this.LinkLabelGitHub.AutoSize = true;
            this.LinkLabelGitHub.Location = new System.Drawing.Point(146, 115);
            this.LinkLabelGitHub.Name = "LinkLabelGitHub";
            this.LinkLabelGitHub.Size = new System.Drawing.Size(40, 13);
            this.LinkLabelGitHub.TabIndex = 5;
            this.LinkLabelGitHub.TabStop = true;
            this.LinkLabelGitHub.Text = "GitHub";
            this.LinkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGitHub_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 158);
            this.Controls.Add(this.LinkLabelGitHub);
            this.Controls.Add(this.LabelOpenSource);
            this.Controls.Add(this.LinkLabelFeedback);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.PictureBoxObi);
            this.Controls.Add(this.LabelFeedback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxObi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxObi;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.LinkLabel LinkLabelFeedback;
        private System.Windows.Forms.Label LabelFeedback;
        private System.Windows.Forms.Label LabelOpenSource;
        private System.Windows.Forms.LinkLabel LinkLabelGitHub;
    }
}