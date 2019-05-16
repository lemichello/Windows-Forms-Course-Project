namespace TestingApplication.UserForms
{
    partial class TestForm
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
            this.QuestionDescription = new System.Windows.Forms.TextBox();
            this.Answer1Text = new System.Windows.Forms.TextBox();
            this.Answer2Text = new System.Windows.Forms.TextBox();
            this.Answer3Text = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Answer1Correct = new System.Windows.Forms.RadioButton();
            this.Answer2Correct = new System.Windows.Forms.RadioButton();
            this.Answer3Correct = new System.Windows.Forms.RadioButton();
            this.InterruptButton = new System.Windows.Forms.Button();
            this.TestingProgress = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionDescription
            // 
            this.QuestionDescription.Enabled = false;
            this.QuestionDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionDescription.Location = new System.Drawing.Point(31, 26);
            this.QuestionDescription.Multiline = true;
            this.QuestionDescription.Name = "QuestionDescription";
            this.QuestionDescription.Size = new System.Drawing.Size(736, 102);
            this.QuestionDescription.TabIndex = 0;
            // 
            // Answer1Text
            // 
            this.Answer1Text.Enabled = false;
            this.Answer1Text.Location = new System.Drawing.Point(31, 149);
            this.Answer1Text.Multiline = true;
            this.Answer1Text.Name = "Answer1Text";
            this.Answer1Text.Size = new System.Drawing.Size(480, 74);
            this.Answer1Text.TabIndex = 1;
            // 
            // Answer2Text
            // 
            this.Answer2Text.Enabled = false;
            this.Answer2Text.Location = new System.Drawing.Point(31, 234);
            this.Answer2Text.Multiline = true;
            this.Answer2Text.Name = "Answer2Text";
            this.Answer2Text.Size = new System.Drawing.Size(480, 74);
            this.Answer2Text.TabIndex = 3;
            // 
            // Answer3Text
            // 
            this.Answer3Text.Enabled = false;
            this.Answer3Text.Location = new System.Drawing.Point(31, 319);
            this.Answer3Text.Multiline = true;
            this.Answer3Text.Name = "Answer3Text";
            this.Answer3Text.Size = new System.Drawing.Size(480, 74);
            this.Answer3Text.TabIndex = 5;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(328, 409);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(183, 23);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Answer1Correct
            // 
            this.Answer1Correct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1Correct.Location = new System.Drawing.Point(565, 149);
            this.Answer1Correct.Name = "Answer1Correct";
            this.Answer1Correct.Size = new System.Drawing.Size(202, 74);
            this.Answer1Correct.TabIndex = 8;
            this.Answer1Correct.TabStop = true;
            this.Answer1Correct.Text = "Correct";
            this.Answer1Correct.UseVisualStyleBackColor = true;
            // 
            // Answer2Correct
            // 
            this.Answer2Correct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2Correct.Location = new System.Drawing.Point(565, 234);
            this.Answer2Correct.Name = "Answer2Correct";
            this.Answer2Correct.Size = new System.Drawing.Size(202, 74);
            this.Answer2Correct.TabIndex = 9;
            this.Answer2Correct.TabStop = true;
            this.Answer2Correct.Text = "Correct";
            this.Answer2Correct.UseVisualStyleBackColor = true;
            // 
            // Answer3Correct
            // 
            this.Answer3Correct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3Correct.Location = new System.Drawing.Point(565, 319);
            this.Answer3Correct.Name = "Answer3Correct";
            this.Answer3Correct.Size = new System.Drawing.Size(202, 74);
            this.Answer3Correct.TabIndex = 10;
            this.Answer3Correct.TabStop = true;
            this.Answer3Correct.Text = "Correct";
            this.Answer3Correct.UseVisualStyleBackColor = true;
            // 
            // InterruptButton
            // 
            this.InterruptButton.BackColor = System.Drawing.Color.Red;
            this.InterruptButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InterruptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InterruptButton.Location = new System.Drawing.Point(31, 409);
            this.InterruptButton.Name = "InterruptButton";
            this.InterruptButton.Size = new System.Drawing.Size(183, 23);
            this.InterruptButton.TabIndex = 11;
            this.InterruptButton.Text = "Interrupt test";
            this.InterruptButton.UseVisualStyleBackColor = false;
            this.InterruptButton.Click += new System.EventHandler(this.InterruptButton_Click);
            // 
            // TestingProgress
            // 
            this.TestingProgress.Location = new System.Drawing.Point(31, 486);
            this.TestingProgress.Name = "TestingProgress";
            this.TestingProgress.Size = new System.Drawing.Size(480, 43);
            this.TestingProgress.Step = 1;
            this.TestingProgress.TabIndex = 12;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressLabel.Location = new System.Drawing.Point(533, 486);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(134, 43);
            this.ProgressLabel.TabIndex = 13;
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(939, 561);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.TestingProgress);
            this.Controls.Add(this.InterruptButton);
            this.Controls.Add(this.Answer3Correct);
            this.Controls.Add(this.Answer2Correct);
            this.Controls.Add(this.Answer1Correct);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.Answer3Text);
            this.Controls.Add(this.Answer2Text);
            this.Controls.Add(this.Answer1Text);
            this.Controls.Add(this.QuestionDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionDescription;
        private System.Windows.Forms.TextBox Answer1Text;
        private System.Windows.Forms.TextBox Answer2Text;
        private System.Windows.Forms.TextBox Answer3Text;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.RadioButton Answer1Correct;
        private System.Windows.Forms.RadioButton Answer2Correct;
        private System.Windows.Forms.RadioButton Answer3Correct;
        private System.Windows.Forms.Button InterruptButton;
        private System.Windows.Forms.ProgressBar TestingProgress;
        private System.Windows.Forms.Label ProgressLabel;
    }
}