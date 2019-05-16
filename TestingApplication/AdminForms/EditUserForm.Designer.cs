namespace TestingApplication.AdminForms
{
    partial class EditUserForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameButton = new System.Windows.Forms.RadioButton();
            this.NewValueBox = new System.Windows.Forms.TextBox();
            this.NewValueLabel = new System.Windows.Forms.Label();
            this.SurnameButton = new System.Windows.Forms.RadioButton();
            this.MiddleNameButton = new System.Windows.Forms.RadioButton();
            this.AddressButton = new System.Windows.Forms.RadioButton();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(301, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(151, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name of editing User";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(305, 72);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(147, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(305, 143);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(147, 20);
            this.SurnameBox.TabIndex = 1;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(301, 120);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(169, 20);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Surname of editing User";
            // 
            // NameButton
            // 
            this.NameButton.AutoSize = true;
            this.NameButton.Checked = true;
            this.NameButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameButton.Location = new System.Drawing.Point(305, 254);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(94, 24);
            this.NameButton.TabIndex = 6;
            this.NameButton.TabStop = true;
            this.NameButton.Text = "Edit name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // NewValueBox
            // 
            this.NewValueBox.Location = new System.Drawing.Point(305, 207);
            this.NewValueBox.Name = "NewValueBox";
            this.NewValueBox.Size = new System.Drawing.Size(147, 20);
            this.NewValueBox.TabIndex = 2;
            // 
            // NewValueLabel
            // 
            this.NewValueLabel.AutoSize = true;
            this.NewValueLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewValueLabel.Location = new System.Drawing.Point(338, 184);
            this.NewValueLabel.Name = "NewValueLabel";
            this.NewValueLabel.Size = new System.Drawing.Size(78, 20);
            this.NewValueLabel.TabIndex = 5;
            this.NewValueLabel.Text = "New value";
            // 
            // SurnameButton
            // 
            this.SurnameButton.AutoSize = true;
            this.SurnameButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameButton.Location = new System.Drawing.Point(305, 284);
            this.SurnameButton.Name = "SurnameButton";
            this.SurnameButton.Size = new System.Drawing.Size(113, 24);
            this.SurnameButton.TabIndex = 7;
            this.SurnameButton.Text = "Edit surname";
            this.SurnameButton.UseVisualStyleBackColor = true;
            this.SurnameButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // MiddleNameButton
            // 
            this.MiddleNameButton.AutoSize = true;
            this.MiddleNameButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameButton.Location = new System.Drawing.Point(305, 314);
            this.MiddleNameButton.Name = "MiddleNameButton";
            this.MiddleNameButton.Size = new System.Drawing.Size(145, 24);
            this.MiddleNameButton.TabIndex = 8;
            this.MiddleNameButton.Text = "Edit middle name";
            this.MiddleNameButton.UseVisualStyleBackColor = true;
            this.MiddleNameButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // AddressButton
            // 
            this.AddressButton.AutoSize = true;
            this.AddressButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressButton.Location = new System.Drawing.Point(305, 344);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(150, 24);
            this.AddressButton.TabIndex = 9;
            this.AddressButton.Text = "Edit home address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(305, 392);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(147, 23);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.MiddleNameButton);
            this.Controls.Add(this.SurnameButton);
            this.Controls.Add(this.NewValueBox);
            this.Controls.Add(this.NewValueLabel);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "EditUserForm";
            this.Text = "Editing User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.RadioButton NameButton;
        private System.Windows.Forms.TextBox NewValueBox;
        private System.Windows.Forms.Label NewValueLabel;
        private System.Windows.Forms.RadioButton SurnameButton;
        private System.Windows.Forms.RadioButton MiddleNameButton;
        private System.Windows.Forms.RadioButton AddressButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}