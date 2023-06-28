namespace NT106_Lab5
{
    partial class MailReader
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.RetrieveEmailsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(61, 60);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(422, 22);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Text = "ninhvo@minh1146.nt106";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(61, 115);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(422, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "NT106@N21@atcl";
            // 
            // RetrieveEmailsButton
            // 
            this.RetrieveEmailsButton.Location = new System.Drawing.Point(571, 60);
            this.RetrieveEmailsButton.Name = "RetrieveEmailsButton";
            this.RetrieveEmailsButton.Size = new System.Drawing.Size(138, 61);
            this.RetrieveEmailsButton.TabIndex = 2;
            this.RetrieveEmailsButton.Text = "Login";
            this.RetrieveEmailsButton.UseVisualStyleBackColor = true;
            this.RetrieveEmailsButton.Click += new System.EventHandler(this.RetrieveEmailsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 256);
            this.dataGridView1.TabIndex = 3;
            // 
            // MailReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RetrieveEmailsButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Name = "MailReader";
            this.Text = "MailReader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button RetrieveEmailsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}