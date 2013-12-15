namespace Compression_Plugin
{
    partial class settings_form
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
            this.DeleteWorldCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteWorldCheckBox
            // 
            this.DeleteWorldCheckBox.AutoSize = true;
            this.DeleteWorldCheckBox.Location = new System.Drawing.Point(12, 12);
            this.DeleteWorldCheckBox.Name = "DeleteWorldCheckBox";
            this.DeleteWorldCheckBox.Size = new System.Drawing.Size(163, 17);
            this.DeleteWorldCheckBox.TabIndex = 0;
            this.DeleteWorldCheckBox.Text = "Delete uncompressed world?";
            this.DeleteWorldCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 35);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 69);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteWorldCheckBox);
            this.Name = "settings_form";
            this.Text = "settings_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DeleteWorldCheckBox;
        private System.Windows.Forms.Button SaveButton;
    }
}