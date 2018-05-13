namespace FS_Crew_Config_Tool.UiComponents
{
    partial class ShipSelector
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
            this.LabelDescriptor = new System.Windows.Forms.Label();
            this.ButtonSelectAll = new System.Windows.Forms.Button();
            this.ButtonSelectNone = new System.Windows.Forms.Button();
            this.ButtonSmartSelect = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDescriptor
            // 
            this.LabelDescriptor.AutoSize = true;
            this.LabelDescriptor.Location = new System.Drawing.Point(12, 20);
            this.LabelDescriptor.Name = "LabelDescriptor";
            this.LabelDescriptor.Size = new System.Drawing.Size(234, 13);
            this.LabelDescriptor.TabIndex = 0;
            this.LabelDescriptor.Text = "Select ships you wish to generate new crews for";
            // 
            // ButtonSelectAll
            // 
            this.ButtonSelectAll.Location = new System.Drawing.Point(476, 54);
            this.ButtonSelectAll.Name = "ButtonSelectAll";
            this.ButtonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelectAll.TabIndex = 1;
            this.ButtonSelectAll.Text = "Select All";
            this.ButtonSelectAll.UseVisualStyleBackColor = true;
            // 
            // ButtonSelectNone
            // 
            this.ButtonSelectNone.Location = new System.Drawing.Point(476, 83);
            this.ButtonSelectNone.Name = "ButtonSelectNone";
            this.ButtonSelectNone.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelectNone.TabIndex = 2;
            this.ButtonSelectNone.Text = "Select None";
            this.ButtonSelectNone.UseVisualStyleBackColor = true;
            // 
            // ButtonSmartSelect
            // 
            this.ButtonSmartSelect.Location = new System.Drawing.Point(476, 112);
            this.ButtonSmartSelect.Name = "ButtonSmartSelect";
            this.ButtonSmartSelect.Size = new System.Drawing.Size(75, 23);
            this.ButtonSmartSelect.TabIndex = 3;
            this.ButtonSmartSelect.Text = "Smart Select";
            this.ButtonSmartSelect.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(476, 157);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 4;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            // 
            // ShipSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 257);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.ButtonSmartSelect);
            this.Controls.Add(this.ButtonSelectNone);
            this.Controls.Add(this.ButtonSelectAll);
            this.Controls.Add(this.LabelDescriptor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(583, 296);
            this.Name = "ShipSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ShipSelector";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDescriptor;
        private System.Windows.Forms.Button ButtonSelectAll;
        private System.Windows.Forms.Button ButtonSelectNone;
        private System.Windows.Forms.Button ButtonSmartSelect;
        private System.Windows.Forms.Button ButtonGenerate;
    }
}