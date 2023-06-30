namespace NT106_Lab5
{
    partial class MailSender
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.rtbCnt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.tbSubj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(41, 42);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 89);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbFrom
            // 
            this.txbFrom.Location = new System.Drawing.Point(259, 36);
            this.txbFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.Size = new System.Drawing.Size(225, 22);
            this.txbFrom.TabIndex = 2;
            this.txbFrom.Text = "minhvo@minh1146.nt106";
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(259, 92);
            this.txbTo.Margin = new System.Windows.Forms.Padding(2);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(615, 22);
            this.txbTo.TabIndex = 3;
            this.txbTo.Text = "ninhvo@minh1146.nt106";
            // 
            // rtbCnt
            // 
            this.rtbCnt.Location = new System.Drawing.Point(29, 196);
            this.rtbCnt.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCnt.Name = "rtbCnt";
            this.rtbCnt.Size = new System.Drawing.Size(845, 259);
            this.rtbCnt.TabIndex = 5;
            this.rtbCnt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "BODY";
            // 
            // txbPass
            // 
            this.txbPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txbPass.Location = new System.Drawing.Point(621, 39);
            this.txbPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(253, 22);
            this.txbPass.TabIndex = 8;
            this.txbPass.Text = "NT106@N21@atcl";
            this.txbPass.TextChanged += new System.EventHandler(this.txbPass_TextChanged);
            // 
            // tbSubj
            // 
            this.tbSubj.Location = new System.Drawing.Point(259, 147);
            this.tbSubj.Margin = new System.Windows.Forms.Padding(2);
            this.tbSubj.Name = "tbSubj";
            this.tbSubj.Size = new System.Drawing.Size(615, 22);
            this.tbSubj.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUBJECT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "PASSWORD:";
            // 
            // MailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubj);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbCnt);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.txbFrom);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MailSender";
            this.Text = "MAIL SENDER";
            this.Load += new System.EventHandler(this.MailSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.RichTextBox rtbCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox tbSubj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

