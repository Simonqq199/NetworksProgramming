namespace NT106_Lab04
{
    partial class Lab04_Bai02
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
            txtURL = new TextBox();
            rtxResponse = new RichTextBox();
            txtContent = new TextBox();
            btnPost = new Button();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(776, 27);
            txtURL.TabIndex = 0;
            txtURL.Text = "http://";
            // 
            // rtxResponse
            // 
            rtxResponse.Location = new Point(12, 45);
            rtxResponse.Name = "rtxResponse";
            rtxResponse.Size = new Size(776, 337);
            rtxResponse.TabIndex = 1;
            rtxResponse.Text = "";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 401);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(652, 27);
            txtContent.TabIndex = 2;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(670, 388);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(118, 50);
            btnPost.TabIndex = 3;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // Lab04_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPost);
            Controls.Add(txtContent);
            Controls.Add(rtxResponse);
            Controls.Add(txtURL);
            Name = "Lab04_Bai02";
            Text = "Lab04_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private RichTextBox rtxResponse;
        private TextBox txtContent;
        private Button btnPost;
    }
}