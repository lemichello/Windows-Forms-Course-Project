namespace TestingApplication.UserForms
{
    partial class PreviousResultsForm
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
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.ExitFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsLabel.Location = new System.Drawing.Point(346, 68);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(110, 20);
            this.ResultsLabel.TabIndex = 0;
            this.ResultsLabel.Text = "Previous results";
            // 
            // ResultsBox
            // 
            this.ResultsBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsBox.FormattingEnabled = true;
            this.ResultsBox.ItemHeight = 17;
            this.ResultsBox.Location = new System.Drawing.Point(225, 106);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(369, 191);
            this.ResultsBox.TabIndex = 1;
            // 
            // ExitFormButton
            // 
            this.ExitFormButton.BackColor = System.Drawing.Color.Red;
            this.ExitFormButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFormButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitFormButton.Location = new System.Drawing.Point(332, 329);
            this.ExitFormButton.Name = "ExitFormButton";
            this.ExitFormButton.Size = new System.Drawing.Size(148, 23);
            this.ExitFormButton.TabIndex = 2;
            this.ExitFormButton.Text = "Exit";
            this.ExitFormButton.UseVisualStyleBackColor = false;
            this.ExitFormButton.Click += new System.EventHandler(this.ExitFormButton_Click);
            // 
            // PreviousResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitFormButton);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.ResultsLabel);
            this.Name = "PreviousResultsForm";
            this.Text = "Previous results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.ListBox ResultsBox;
        private System.Windows.Forms.Button ExitFormButton;
    }
}