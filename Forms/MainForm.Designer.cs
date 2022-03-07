namespace RetailStoreCashRegister.Forms
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
            this.adminAndStatsBtn = new System.Windows.Forms.Button();
            this.salesAndBillingBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminAndStatsBtn
            // 
            this.adminAndStatsBtn.Location = new System.Drawing.Point(102, 114);
            this.adminAndStatsBtn.Name = "adminAndStatsBtn";
            this.adminAndStatsBtn.Size = new System.Drawing.Size(109, 58);
            this.adminAndStatsBtn.TabIndex = 0;
            this.adminAndStatsBtn.Text = "Administration\r\n&&\r\nStatistics";
            this.adminAndStatsBtn.UseVisualStyleBackColor = true;
            // 
            // salesAndBillingBtn
            // 
            this.salesAndBillingBtn.Location = new System.Drawing.Point(217, 114);
            this.salesAndBillingBtn.Name = "salesAndBillingBtn";
            this.salesAndBillingBtn.Size = new System.Drawing.Size(126, 58);
            this.salesAndBillingBtn.TabIndex = 1;
            this.salesAndBillingBtn.Text = "Sales\r\n&&\r\nBilling";
            this.salesAndBillingBtn.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(155, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(127, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 184);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.salesAndBillingBtn);
            this.Controls.Add(this.adminAndStatsBtn);
            this.Name = "MainForm";
            this.Text = "Cash register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button adminAndStatsBtn;
        private Button salesAndBillingBtn;
        private Label welcomeLabel;
    }
}