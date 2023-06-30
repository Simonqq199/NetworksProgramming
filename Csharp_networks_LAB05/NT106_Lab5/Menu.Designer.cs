namespace NT106_Lab5
{
    partial class EmailCenter
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
            this.btnMailSender = new System.Windows.Forms.Button();
            this.btnMailReader = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMailSender
            // 
            this.btnMailSender.Location = new System.Drawing.Point(88, 137);
            this.btnMailSender.Name = "btnMailSender";
            this.btnMailSender.Size = new System.Drawing.Size(123, 69);
            this.btnMailSender.TabIndex = 0;
            this.btnMailSender.Text = "Mail Sender";
            this.btnMailSender.UseVisualStyleBackColor = true;
            this.btnMailSender.Click += new System.EventHandler(this.btnMailSender_Click);
            // 
            // btnMailReader
            // 
            this.btnMailReader.Location = new System.Drawing.Point(326, 137);
            this.btnMailReader.Name = "btnMailReader";
            this.btnMailReader.Size = new System.Drawing.Size(123, 69);
            this.btnMailReader.TabIndex = 1;
            this.btnMailReader.Text = "Mail Reader";
            this.btnMailReader.UseVisualStyleBackColor = true;
            this.btnMailReader.Click += new System.EventHandler(this.btnMailReader_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(178, 42);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(271, 22);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.Text = "ninhvo@minh1146.nt106";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(178, 83);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(271, 22);
            this.txbPass.TabIndex = 3;
            this.txbPass.Text = "NT106@N21@atcl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // EmailCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.btnMailReader);
            this.Controls.Add(this.btnMailSender);
            this.Name = "EmailCenter";
            this.Text = "EmailCenter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMailSender;
        private System.Windows.Forms.Button btnMailReader;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}