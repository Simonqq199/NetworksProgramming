namespace LAB01
{
    partial class Form4
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
            txbInput = new TextBox();
            btnDo = new Button();
            btnDel = new Button();
            btnExit = new Button();
            label2 = new Label();
            txbOutput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 116);
            label1.Name = "label1";
            label1.Size = new Size(242, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số từ -9999 đến 9999 để đọc:";
            // 
            // txbInput
            // 
            txbInput.Location = new Point(308, 109);
            txbInput.Name = "txbInput";
            txbInput.Size = new Size(141, 27);
            txbInput.TabIndex = 1;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(485, 107);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(94, 29);
            btnDo.TabIndex = 2;
            btnDo.Text = "Đọc";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += btnDo_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(485, 182);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 3;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(485, 247);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 251);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Kết quả";
            // 
            // txbOutput
            // 
            txbOutput.Location = new Point(65, 290);
            txbOutput.Name = "txbOutput";
            txbOutput.Size = new Size(345, 27);
            txbOutput.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 369);
            Controls.Add(txbOutput);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnDo);
            Controls.Add(txbInput);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Đọc số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbInput;
        private Button btnDo;
        private Button btnDel;
        private Button btnExit;
        private Label label2;
        private TextBox txbOutput;
    }
}