namespace networksLAB02
{
    partial class Form3
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
            btnRead = new Button();
            txtContent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbName = new TextBox();
            txbURL = new TextBox();
            txbLine = new TextBox();
            txbWord = new TextBox();
            txbChar = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(70, 72);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(113, 46);
            btnRead.TabIndex = 1;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.White;
            txtContent.Location = new Point(255, 72);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(437, 27);
            txtContent.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 143);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 357);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 6;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 178);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Số dòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 220);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "Số từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 264);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Số chữ";
            // 
            // txbName
            // 
            txbName.Location = new Point(113, 140);
            txbName.Name = "txbName";
            txbName.Size = new Size(125, 27);
            txbName.TabIndex = 10;
            // 
            // txbURL
            // 
            txbURL.Location = new Point(113, 357);
            txbURL.Name = "txbURL";
            txbURL.Size = new Size(579, 27);
            txbURL.TabIndex = 11;
            // 
            // txbLine
            // 
            txbLine.Location = new Point(113, 175);
            txbLine.Name = "txbLine";
            txbLine.Size = new Size(125, 27);
            txbLine.TabIndex = 12;
            // 
            // txbWord
            // 
            txbWord.Location = new Point(113, 213);
            txbWord.Name = "txbWord";
            txbWord.Size = new Size(125, 27);
            txbWord.TabIndex = 13;
            // 
            // txbChar
            // 
            txbChar.Location = new Point(113, 257);
            txbChar.Name = "txbChar";
            txbChar.Size = new Size(125, 27);
            txbChar.TabIndex = 14;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 440);
            Controls.Add(txtContent);
            Controls.Add(txbChar);
            Controls.Add(txbWord);
            Controls.Add(txbLine);
            Controls.Add(txbURL);
            Controls.Add(txbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Name = "Form3";
            Text = "Đọc thông tin file txt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private TextBox txtContent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbName;
        private TextBox txbURL;
        private TextBox txbLine;
        private TextBox txbWord;
        private TextBox txbChar;
    }
}