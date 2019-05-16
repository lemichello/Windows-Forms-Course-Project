namespace TestingApplication.AdminForms
{
    partial class AddTestForm
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
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.TestNameBox = new System.Windows.Forms.TextBox();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.NumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.QuestionsNumberLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CategoriesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryNameLabel.Location = new System.Drawing.Point(316, 58);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(154, 23);
            this.CategoryNameLabel.TabIndex = 0;
            this.CategoryNameLabel.Text = "Name of the category";
            this.CategoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(320, 97);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(150, 20);
            this.CategoryNameBox.TabIndex = 1;
            // 
            // TestNameBox
            // 
            this.TestNameBox.Location = new System.Drawing.Point(320, 174);
            this.TestNameBox.Name = "TestNameBox";
            this.TestNameBox.Size = new System.Drawing.Size(150, 20);
            this.TestNameBox.TabIndex = 3;
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestNameLabel.Location = new System.Drawing.Point(316, 139);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(154, 23);
            this.TestNameLabel.TabIndex = 2;
            this.TestNameLabel.Text = "Name of the test";
            this.TestNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfQuestions
            // 
            this.NumberOfQuestions.Location = new System.Drawing.Point(320, 247);
            this.NumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfQuestions.Name = "NumberOfQuestions";
            this.NumberOfQuestions.Size = new System.Drawing.Size(150, 20);
            this.NumberOfQuestions.TabIndex = 4;
            this.NumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QuestionsNumberLabel
            // 
            this.QuestionsNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionsNumberLabel.Location = new System.Drawing.Point(316, 214);
            this.QuestionsNumberLabel.Name = "QuestionsNumberLabel";
            this.QuestionsNumberLabel.Size = new System.Drawing.Size(154, 23);
            this.QuestionsNumberLabel.TabIndex = 5;
            this.QuestionsNumberLabel.Text = "Number of questions";
            this.QuestionsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(320, 308);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(150, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CategoriesList
            // 
            this.CategoriesList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesList.FormattingEnabled = true;
            this.CategoriesList.ItemHeight = 17;
            this.CategoriesList.Location = new System.Drawing.Point(13, 58);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(227, 276);
            this.CategoriesList.TabIndex = 7;
            this.CategoriesList.SelectedIndexChanged += new System.EventHandler(this.CategoriesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categories";
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriesList);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.QuestionsNumberLabel);
            this.Controls.Add(this.NumberOfQuestions);
            this.Controls.Add(this.TestNameBox);
            this.Controls.Add(this.TestNameLabel);
            this.Controls.Add(this.CategoryNameBox);
            this.Controls.Add(this.CategoryNameLabel);
            this.Name = "AddTestForm";
            this.Text = "Adding Test";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.TextBox TestNameBox;
        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.NumericUpDown NumberOfQuestions;
        private System.Windows.Forms.Label QuestionsNumberLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ListBox CategoriesList;
        private System.Windows.Forms.Label label1;
    }
}