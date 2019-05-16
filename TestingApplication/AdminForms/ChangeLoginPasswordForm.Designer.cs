namespace TestingApplication.AdminForms
{
    partial class ChangeLoginPasswordForm
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
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginPasswordLabel.Location = new System.Drawing.Point(320, 119);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(146, 23);
            this.LoginPasswordLabel.TabIndex = 0;
            this.LoginPasswordLabel.Text = "Your new login";
            this.LoginPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(324, 159);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(142, 20);
            this.DataBox.TabIndex = 1;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(324, 220);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(142, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ChangeLoginPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Name = "ChangeLoginPasswordForm";
            this.Text = "Changing login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}