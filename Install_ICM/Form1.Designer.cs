namespace Install_ICM
{
    partial class InstallICMForm
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
            this.InstallICMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstallICMButton
            // 
            this.InstallICMButton.Location = new System.Drawing.Point(330, 188);
            this.InstallICMButton.Name = "InstallICMButton";
            this.InstallICMButton.Size = new System.Drawing.Size(117, 38);
            this.InstallICMButton.TabIndex = 0;
            this.InstallICMButton.Text = "Install ICM";
            this.InstallICMButton.UseVisualStyleBackColor = true;
            this.InstallICMButton.Click += new System.EventHandler(this.InstallICMButton_Click);
            // 
            // InstallICMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstallICMButton);
            this.Name = "InstallICMForm";
            this.Text = "Install ICM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstallICMButton;
    }
}

