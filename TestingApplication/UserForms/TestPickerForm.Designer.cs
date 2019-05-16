namespace TestingApplication.UserForms
{
    partial class TestPickerForm
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
            this.TestsBox = new System.Windows.Forms.ListBox();
            this.TestsLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestsBox
            // 
            this.TestsBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestsBox.FormattingEnabled = true;
            this.TestsBox.ItemHeight = 17;
            this.TestsBox.Location = new System.Drawing.Point(214, 115);
            this.TestsBox.Name = "TestsBox";
            this.TestsBox.Size = new System.Drawing.Size(394, 106);
            this.TestsBox.TabIndex = 0;
            this.TestsBox.SelectedIndexChanged += new System.EventHandler(this.TestsBox_SelectedIndexChanged);
            // 
            // TestsLabel
            // 
            this.TestsLabel.AutoSize = true;
            this.TestsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestsLabel.Location = new System.Drawing.Point(317, 92);
            this.TestsLabel.Name = "TestsLabel";
            this.TestsLabel.Size = new System.Drawing.Size(178, 20);
            this.TestsLabel.TabIndex = 1;
            this.TestsLabel.Text = "Choose one of these tests";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(339, 256);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(156, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // TestPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TestsLabel);
            this.Controls.Add(this.TestsBox);
            this.Name = "TestPickerForm";
            this.Text = "Test Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TestsBox;
        private System.Windows.Forms.Label TestsLabel;
        private System.Windows.Forms.Button ConfirmButton;
    }
}