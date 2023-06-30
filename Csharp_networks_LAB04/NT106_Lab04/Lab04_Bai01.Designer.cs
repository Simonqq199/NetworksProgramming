namespace NT106_Lab04
{
    partial class Lab04_Bai01
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
            btnGet = new Button();
            rtxResponse = new RichTextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(643, 27);
            txtURL.TabIndex = 0;
            txtURL.Text = "http://";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(682, 10);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 1;
            btnGet.Text = "View";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtxResponse
            // 
            rtxResponse.Location = new Point(12, 45);
            rtxResponse.Name = "rtxResponse";
            rtxResponse.Size = new Size(764, 393);
            rtxResponse.TabIndex = 2;
            rtxResponse.Text = "";
            // 
            // Lab04_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtxResponse);
            Controls.Add(btnGet);
            Controls.Add(txtURL);
            Name = "Lab04_Bai01";
            Text = "Lab04_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnGet;
        private RichTextBox rtxResponse;
    }
}