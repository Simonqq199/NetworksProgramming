namespace LAB01
{
    partial class Form5
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
            panel1 = new Panel();
            btnDel = new Button();
            btnDo = new Button();
            cbbDestination = new ComboBox();
            label4 = new Label();
            cbbSource = new ComboBox();
            label3 = new Label();
            txbInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txbOutput = new TextBox();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnDo);
            panel1.Controls.Add(cbbDestination);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbbSource);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbInput);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(100, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 187);
            panel1.TabIndex = 0;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(374, 131);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 7;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(204, 131);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(94, 29);
            btnDo.TabIndex = 6;
            btnDo.Text = "Thực hiện";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += btnDo_Click;
            // 
            // cbbDestination
            // 
            cbbDestination.FormattingEnabled = true;
            cbbDestination.Items.AddRange(new object[] { "Decimal", "Binary", "Octal", "Hexadecimal" });
            cbbDestination.Location = new Point(422, 71);
            cbbDestination.Name = "cbbDestination";
            cbbDestination.Size = new Size(156, 28);
            cbbDestination.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 79);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 4;
            label4.Text = "Sang";
            // 
            // cbbSource
            // 
            cbbSource.FormattingEnabled = true;
            cbbSource.Items.AddRange(new object[] { "Decimal", "Binary", "Octal", "Hexadecimal" });
            cbbSource.Location = new Point(204, 71);
            cbbSource.Name = "cbbSource";
            cbbSource.Size = new Size(153, 28);
            cbbSource.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 79);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Chọn định dạng:";
            // 
            // txbInput
            // 
            txbInput.Location = new Point(204, 31);
            txbInput.Name = "txbInput";
            txbInput.Size = new Size(374, 27);
            txbInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 38);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhập số cần chuyển đổi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 51);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 281);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 2;
            label5.Text = "Kết quả:";
            // 
            // txbOutput
            // 
            txbOutput.Location = new Point(235, 274);
            txbOutput.Name = "txbOutput";
            txbOutput.Size = new Size(443, 27);
            txbOutput.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(350, 352);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 410);
            Controls.Add(btnExit);
            Controls.Add(txbOutput);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Chuyển đổi hệ cơ số";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cbbSource;
        private Label label3;
        private TextBox txbInput;
        private Label label2;
        private ComboBox cbbDestination;
        private Label label4;
        private Label label5;
        private TextBox txbOutput;
        private Button btnDel;
        private Button btnDo;
        private Button btnExit;
    }
}