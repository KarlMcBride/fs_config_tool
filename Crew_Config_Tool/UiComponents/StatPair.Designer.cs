namespace FS_Crew_Config_Tool.UiComponents
{
    partial class StatPair
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
            this.LabelStatName = new System.Windows.Forms.Label();
            this.LabelStatValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelStatName
            // 
            this.LabelStatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatName.Location = new System.Drawing.Point(3, 0);
            this.LabelStatName.Name = "LabelStatName";
            this.LabelStatName.Size = new System.Drawing.Size(100, 26);
            this.LabelStatName.TabIndex = 0;
            this.LabelStatName.Text = "Broken Armour Damage Reduction";
            this.LabelStatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelStatValue
            // 
            this.LabelStatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LabelStatValue.Location = new System.Drawing.Point(84, 0);
            this.LabelStatValue.Name = "LabelStatValue";
            this.LabelStatValue.Size = new System.Drawing.Size(70, 26);
            this.LabelStatValue.TabIndex = 1;
            this.LabelStatValue.Text = "+1000 HP";
            this.LabelStatValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatPair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelStatName);
            this.Controls.Add(this.LabelStatValue);
            this.Name = "StatPair";
            this.Size = new System.Drawing.Size(154, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelStatName;
        private System.Windows.Forms.Label LabelStatValue;
    }
}
