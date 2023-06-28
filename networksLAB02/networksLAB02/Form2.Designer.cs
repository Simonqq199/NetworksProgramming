namespace networksLAB02
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
            btnRead = new Button();
            btnWrite = new Button();
            txtContent = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(56, 66);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(113, 46);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(56, 185);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(113, 46);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(216, 66);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(437, 27);
            txtContent.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 323);
            Controls.Add(txtContent);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Form2";
            Text = "Ghi và đọc file";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private TextBox txtContent;
    }
}