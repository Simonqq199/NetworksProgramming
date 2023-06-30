namespace LAB01
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbInput1 = new TextBox();
            txbInput2 = new TextBox();
            txbInput3 = new TextBox();
            btnDo = new Button();
            btnDel = new Button();
            btnExit = new Button();
            label4 = new Label();
            label5 = new Label();
            txtMinOutput = new TextBox();
            txbMaxOutput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 76);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 76);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 76);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ ba";
            // 
            // txbInput1
            // 
            txbInput1.Location = new Point(140, 69);
            txbInput1.Name = "txbInput1";
            txbInput1.Size = new Size(125, 27);
            txbInput1.TabIndex = 3;
            // 
            // txbInput2
            // 
            txbInput2.Location = new Point(370, 69);
            txbInput2.Name = "txbInput2";
            txbInput2.Size = new Size(125, 27);
            txbInput2.TabIndex = 4;
            // 
            // txbInput3
            // 
            txbInput3.Location = new Point(597, 69);
            txbInput3.Name = "txbInput3";
            txbInput3.Size = new Size(125, 27);
            txbInput3.TabIndex = 5;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(140, 161);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(94, 29);
            btnDo.TabIndex = 6;
            btnDo.Text = "Tìm";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += btnDo_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(370, 161);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 7;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(597, 161);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 264);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 9;
            label4.Text = "Số bé nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 264);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Số lớn nhất";
            // 
            // txtMinOutput
            // 
            txtMinOutput.Location = new Point(240, 257);
            txtMinOutput.Name = "txtMinOutput";
            txtMinOutput.Size = new Size(125, 27);
            txtMinOutput.TabIndex = 11;
            // 
            // txbMaxOutput
            // 
            txbMaxOutput.Location = new Point(518, 257);
            txbMaxOutput.Name = "txbMaxOutput";
            txbMaxOutput.Size = new Size(125, 27);
            txbMaxOutput.TabIndex = 12;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 365);
            Controls.Add(txbMaxOutput);
            Controls.Add(txtMinOutput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnDo);
            Controls.Add(txbInput3);
            Controls.Add(txbInput2);
            Controls.Add(txbInput1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Tìm số nhỏ nhất, lớn nhất";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbInput1;
        private TextBox txbInput2;
        private TextBox txbInput3;
        private Button btnDo;
        private Button btnDel;
        private Button btnExit;
        private Label label4;
        private Label label5;
        private TextBox txtMinOutput;
        private TextBox txbMaxOutput;
    }
}