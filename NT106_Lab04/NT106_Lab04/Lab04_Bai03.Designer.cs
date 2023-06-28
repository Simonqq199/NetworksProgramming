namespace NT106_Lab04
{
    partial class Lab04_Bai03
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
            url = new TextBox();
            path = new TextBox();
            btnDownload = new Button();
            rtbSourceCode = new RichTextBox();
            SuspendLayout();
            // 
            // url
            // 
            url.Location = new Point(12, 12);
            url.Name = "url";
            url.Size = new Size(617, 27);
            url.TabIndex = 0;
            url.Text = "http://";
            // 
            // path
            // 
            path.Location = new Point(12, 55);
            path.Name = "path";
            path.Size = new Size(617, 27);
            path.TabIndex = 1;
            path.Text = "file path (D:\\)";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(646, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 70);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Down Source";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rtbSourceCode
            // 
            rtbSourceCode.Location = new Point(12, 88);
            rtbSourceCode.Name = "rtbSourceCode";
            rtbSourceCode.Size = new Size(728, 339);
            rtbSourceCode.TabIndex = 3;
            rtbSourceCode.Text = "";
            // 
            // Lab04_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(rtbSourceCode);
            Controls.Add(btnDownload);
            Controls.Add(path);
            Controls.Add(url);
            Name = "Lab04_Bai03";
            Text = "Lab04_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox url;
        private TextBox path;
        private Button btnDownload;
        private RichTextBox rtbSourceCode;
    }
}