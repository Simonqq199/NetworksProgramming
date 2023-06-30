namespace LAB01
{
    partial class Form6
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
            txbScore = new TextBox();
            btnPrint = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_Del = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(214, 50);
            label1.Name = "label1";
            label1.Size = new Size(365, 38);
            label1.TabIndex = 0;
            label1.Text = "Phần mềm quản lý điểm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 134);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Danh sách điểm:";
            // 
            // txbScore
            // 
            txbScore.Location = new Point(228, 127);
            txbScore.Name = "txbScore";
            txbScore.Size = new Size(452, 27);
            txbScore.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(586, 173);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Xuất";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(80, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 200);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 208);
            label3.Name = "label3";
            label3.Size = new Size(199, 20);
            label3.TabIndex = 5;
            label3.Text = "Danh sách môn học và điểm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 443);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 6;
            label4.Text = "Điểm trung bình:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 475);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 7;
            label5.Text = "Điểm cao nhất: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 509);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 8;
            label6.Text = "Số môn đậu: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 443);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 9;
            label7.Text = "Xếp loại học lực: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 475);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 10;
            label8.Text = "Điểm thấp nhất: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(412, 509);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 11;
            label9.Text = "Số môn không đậu: ";
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(469, 173);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(94, 29);
            btn_Del.TabIndex = 12;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(585, 60);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 13;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 580);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnPrint);
            Controls.Add(txbScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbScore;
        private Button btnPrint;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btn_Del;
        private Button btn_Exit;
    }
}