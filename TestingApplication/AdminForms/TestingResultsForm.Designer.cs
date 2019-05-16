namespace TestingApplication.AdminForms
{
    partial class TestingResultsForm
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
            this.CategoriesList = new System.Windows.Forms.ListBox();
            this.CriterionLabel = new System.Windows.Forms.Label();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.CriterionDescriptionLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.TestingResultsList = new System.Windows.Forms.ListBox();
            this.ExitFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoriesList
            // 
            this.CategoriesList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesList.FormattingEnabled = true;
            this.CategoriesList.ItemHeight = 17;
            this.CategoriesList.Location = new System.Drawing.Point(12, 53);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(244, 106);
            this.CategoriesList.TabIndex = 0;
            this.CategoriesList.SelectedIndexChanged += new System.EventHandler(this.CategoriesList_SelectedIndexChanged);
            // 
            // CriterionLabel
            // 
            this.CriterionLabel.AutoSize = true;
            this.CriterionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CriterionLabel.Location = new System.Drawing.Point(85, 30);
            this.CriterionLabel.Name = "CriterionLabel";
            this.CriterionLabel.Size = new System.Drawing.Size(80, 20);
            this.CriterionLabel.TabIndex = 9;
            this.CriterionLabel.Text = "Categories";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(408, 89);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(167, 20);
            this.CategoryNameBox.TabIndex = 11;
            // 
            // CriterionDescriptionLabel
            // 
            this.CriterionDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CriterionDescriptionLabel.Location = new System.Drawing.Point(285, 53);
            this.CriterionDescriptionLabel.Name = "CriterionDescriptionLabel";
            this.CriterionDescriptionLabel.Size = new System.Drawing.Size(433, 23);
            this.CriterionDescriptionLabel.TabIndex = 10;
            this.CriterionDescriptionLabel.Text = "Name of the category, resulting tests of which you want to view";
            this.CriterionDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(408, 136);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(167, 23);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // TestingResultsList
            // 
            this.TestingResultsList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestingResultsList.FormattingEnabled = true;
            this.TestingResultsList.ItemHeight = 17;
            this.TestingResultsList.Location = new System.Drawing.Point(12, 197);
            this.TestingResultsList.Name = "TestingResultsList";
            this.TestingResultsList.Size = new System.Drawing.Size(706, 174);
            this.TestingResultsList.TabIndex = 13;
            // 
            // ExitFormButton
            // 
            this.ExitFormButton.BackColor = System.Drawing.Color.Red;
            this.ExitFormButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFormButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitFormButton.Location = new System.Drawing.Point(295, 404);
            this.ExitFormButton.Name = "ExitFormButton";
            this.ExitFormButton.Size = new System.Drawing.Size(167, 23);
            this.ExitFormButton.TabIndex = 14;
            this.ExitFormButton.Text = "Exit";
            this.ExitFormButton.UseVisualStyleBackColor = false;
            this.ExitFormButton.Click += new System.EventHandler(this.ExitFormButton_Click);
            // 
            // TestingResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitFormButton);
            this.Controls.Add(this.TestingResultsList);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CategoryNameBox);
            this.Controls.Add(this.CriterionDescriptionLabel);
            this.Controls.Add(this.CriterionLabel);
            this.Controls.Add(this.CategoriesList);
            this.Name = "TestingResultsForm";
            this.Text = "Printing testing results";
            this.Shown += new System.EventHandler(this.TestingResultsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesList;
        private System.Windows.Forms.Label CriterionLabel;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.Label CriterionDescriptionLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ListBox TestingResultsList;
        private System.Windows.Forms.Button ExitFormButton;
    }
}