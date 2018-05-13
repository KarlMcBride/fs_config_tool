namespace FS_Crew_Config_Tool.UiComponents
{
    partial class CrewBox
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
            this.PictureBoxImplant2 = new System.Windows.Forms.PictureBox();
            this.PictureBoxImplant1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxImplant0 = new System.Windows.Forms.PictureBox();
            this.PictureBoxCrew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImplant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImplant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImplant0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxImplant2
            // 
            this.PictureBoxImplant2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxImplant2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxImplant2.Location = new System.Drawing.Point(91, 214);
            this.PictureBoxImplant2.Name = "PictureBoxImplant2";
            this.PictureBoxImplant2.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxImplant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImplant2.TabIndex = 3;
            this.PictureBoxImplant2.TabStop = false;
            this.PictureBoxImplant2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImplant2_MouseDoubleClick);
            // 
            // PictureBoxImplant1
            // 
            this.PictureBoxImplant1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxImplant1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxImplant1.Location = new System.Drawing.Point(48, 214);
            this.PictureBoxImplant1.Name = "PictureBoxImplant1";
            this.PictureBoxImplant1.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxImplant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImplant1.TabIndex = 2;
            this.PictureBoxImplant1.TabStop = false;
            this.PictureBoxImplant1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImplant1_MouseDoubleClick);
            // 
            // PictureBoxImplant0
            // 
            this.PictureBoxImplant0.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxImplant0.Location = new System.Drawing.Point(5, 214);
            this.PictureBoxImplant0.Name = "PictureBoxImplant0";
            this.PictureBoxImplant0.Size = new System.Drawing.Size(48, 48);
            this.PictureBoxImplant0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImplant0.TabIndex = 1;
            this.PictureBoxImplant0.TabStop = false;
            this.PictureBoxImplant0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImplant0_MouseDoubleClick);
            // 
            // PictureBoxCrew
            // 
            this.PictureBoxCrew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxCrew.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxCrew.Name = "PictureBoxCrew";
            this.PictureBoxCrew.Size = new System.Drawing.Size(158, 275);
            this.PictureBoxCrew.TabIndex = 0;
            this.PictureBoxCrew.TabStop = false;
            this.PictureBoxCrew.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxCrew_MouseDoubleClick);
            // 
            // CrewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PictureBoxImplant2);
            this.Controls.Add(this.PictureBoxImplant1);
            this.Controls.Add(this.PictureBoxImplant0);
            this.Controls.Add(this.PictureBoxCrew);
            this.Name = "CrewBox";
            this.Size = new System.Drawing.Size(165, 282);
            this.Load += new System.EventHandler(this.CrewBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImplant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImplant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImplant0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCrew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBoxCrew;
        public System.Windows.Forms.PictureBox PictureBoxImplant0;
        public System.Windows.Forms.PictureBox PictureBoxImplant1;
        public System.Windows.Forms.PictureBox PictureBoxImplant2;
    }
}
