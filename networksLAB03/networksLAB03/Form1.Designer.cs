namespace networksLAB03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnEx04 = new Button();
            btnEx03 = new Button();
            btnEx02 = new Button();
            btnEx01 = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 259);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEx04
            // 
            btnEx04.Location = new Point(258, 171);
            btnEx04.Name = "btnEx04";
            btnEx04.Size = new Size(94, 29);
            btnEx04.TabIndex = 9;
            btnEx04.Text = "Bài tập 04";
            btnEx04.UseVisualStyleBackColor = true;
            btnEx04.Click += btnEx04_Click;
            // 
            // btnEx03
            // 
            btnEx03.Location = new Point(258, 79);
            btnEx03.Name = "btnEx03";
            btnEx03.Size = new Size(94, 29);
            btnEx03.TabIndex = 8;
            btnEx03.Text = "Bài tập 03";
            btnEx03.UseVisualStyleBackColor = true;
            btnEx03.Click += btnEx03_Click;
            // 
            // btnEx02
            // 
            btnEx02.Location = new Point(87, 171);
            btnEx02.Name = "btnEx02";
            btnEx02.Size = new Size(94, 29);
            btnEx02.TabIndex = 7;
            btnEx02.Text = "Bài tập 02";
            btnEx02.UseVisualStyleBackColor = true;
            btnEx02.Click += btnEx02_Click;
            // 
            // btnEx01
            // 
            btnEx01.Location = new Point(87, 79);
            btnEx01.Name = "btnEx01";
            btnEx01.Size = new Size(94, 29);
            btnEx01.TabIndex = 6;
            btnEx01.Text = "Bài tập 01";
            btnEx01.UseVisualStyleBackColor = true;
            btnEx01.Click += btnEx01_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 341);
            Controls.Add(btnExit);
            Controls.Add(btnEx04);
            Controls.Add(btnEx03);
            Controls.Add(btnEx02);
            Controls.Add(btnEx01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnEx04;
        private Button btnEx03;
        private Button btnEx02;
        private Button btnEx01;
    }
}