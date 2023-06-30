namespace LAB01
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            txbInput1 = new TextBox();
            txbInput2 = new TextBox();
            label3 = new Label();
            btnSum = new Button();
            label4 = new Label();
            txbSumOutput = new TextBox();
            btnDel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 205);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ hai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 130);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // txbInput1
            // 
            txbInput1.Location = new Point(219, 123);
            txbInput1.Name = "txbInput1";
            txbInput1.Size = new Size(190, 27);
            txbInput1.TabIndex = 2;
            // 
            // txbInput2
            // 
            txbInput2.Location = new Point(219, 198);
            txbInput2.Name = "txbInput2";
            txbInput2.Size = new Size(190, 27);
            txbInput2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 42);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 4;
            label3.Text = "Nhập hai số nguyên để tính tổng";
            // 
            // btnSum
            // 
            btnSum.Location = new Point(468, 294);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(94, 29);
            btnSum.TabIndex = 5;
            btnSum.Text = "Tính tổng";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnDo_Click;
            btnSum.Enter += btnDo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 303);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Tổng";
            // 
            // txbSumOutput
            // 
            txbSumOutput.Location = new Point(219, 296);
            txbSumOutput.Name = "txbSumOutput";
            txbSumOutput.Size = new Size(190, 27);
            txbSumOutput.TabIndex = 7;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(468, 196);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(468, 121);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(txbSumOutput);
            Controls.Add(label4);
            Controls.Add(btnSum);
            Controls.Add(label3);
            Controls.Add(txbInput2);
            Controls.Add(txbInput1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Chương trình tính tổng của 2 số nguyên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbInput1;
        private TextBox txbInput2;
        private Label label3;
        private Button btnSum;
        private Label label4;
        private TextBox txbSumOutput;
        private Button btnDel;
        private Button btnExit;
    }
}