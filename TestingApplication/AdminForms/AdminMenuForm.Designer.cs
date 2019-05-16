namespace TestingApplication.AdminForms
{
    partial class AdminMenuForm
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
            this.MenuClauses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SaveTxtFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveXmlFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // MenuClauses
            // 
            this.MenuClauses.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuClauses.FormattingEnabled = true;
            this.MenuClauses.ItemHeight = 31;
            this.MenuClauses.Location = new System.Drawing.Point(12, 57);
            this.MenuClauses.Name = "MenuClauses";
            this.MenuClauses.Size = new System.Drawing.Size(904, 438);
            this.MenuClauses.TabIndex = 0;
            this.MenuClauses.SelectedIndexChanged += new System.EventHandler(this.MenuClauses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Green;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton.Location = new System.Drawing.Point(349, 501);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(245, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SaveTxtFileDialog
            // 
            this.SaveTxtFileDialog.DefaultExt = "txt";
            this.SaveTxtFileDialog.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // SaveXmlFileDialog
            // 
            this.SaveXmlFileDialog.DefaultExt = "xml";
            this.SaveXmlFileDialog.Filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // OpenXmlFileDialog
            // 
            this.OpenXmlFileDialog.DefaultExt = "xml";
            this.OpenXmlFileDialog.Filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(955, 541);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuClauses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenuForm";
            this.Text = "Menu for Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MenuClauses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.SaveFileDialog SaveTxtFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveXmlFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenXmlFileDialog;
    }
}