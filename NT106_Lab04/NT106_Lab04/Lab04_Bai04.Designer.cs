namespace NT106_Lab04
{
    partial class Lab04_Bai04
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
            Lab4_txtURL = new TextBox();
            Lab4_btnSearch = new Button();
            Lab4_btnSource = new Button();
            Lab4_btnDownload = new Button();
            SuspendLayout();
            // 
            // Lab4_txtURL
            // 
            Lab4_txtURL.BackColor = SystemColors.Info;
            Lab4_txtURL.Location = new Point(12, 12);
            Lab4_txtURL.Name = "Lab4_txtURL";
            Lab4_txtURL.Size = new Size(701, 27);
            Lab4_txtURL.TabIndex = 0;
            // 
            // Lab4_btnSearch
            // 
            Lab4_btnSearch.BackColor = SystemColors.AppWorkspace;
            Lab4_btnSearch.Location = new Point(719, 12);
            Lab4_btnSearch.Name = "Lab4_btnSearch";
            Lab4_btnSearch.Size = new Size(94, 29);
            Lab4_btnSearch.TabIndex = 1;
            Lab4_btnSearch.Text = "Search";
            Lab4_btnSearch.UseVisualStyleBackColor = false;
            Lab4_btnSearch.Click += Lab4_btnSearch_Click;
            // 
            // Lab4_btnSource
            // 
            Lab4_btnSource.BackColor = SystemColors.ControlDark;
            Lab4_btnSource.Location = new Point(842, 10);
            Lab4_btnSource.Name = "Lab4_btnSource";
            Lab4_btnSource.Size = new Size(64, 29);
            Lab4_btnSource.TabIndex = 2;
            Lab4_btnSource.Text = "View";
            Lab4_btnSource.UseVisualStyleBackColor = false;
            Lab4_btnSource.Click += Lab4_btnSource_Click;
            // 
            // Lab4_btnDownload
            // 
            Lab4_btnDownload.BackColor = SystemColors.ControlDark;
            Lab4_btnDownload.Location = new Point(912, 10);
            Lab4_btnDownload.Name = "Lab4_btnDownload";
            Lab4_btnDownload.Size = new Size(65, 29);
            Lab4_btnDownload.TabIndex = 3;
            Lab4_btnDownload.Text = "Down";
            Lab4_btnDownload.UseVisualStyleBackColor = false;
            Lab4_btnDownload.Click += Lab4_btnDownload_Click;
            // 
            // Lab04_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 450);
            Controls.Add(Lab4_btnDownload);
            Controls.Add(Lab4_btnSource);
            Controls.Add(Lab4_btnSearch);
            Controls.Add(Lab4_txtURL);
            Name = "Lab04_Bai04";
            Text = "Lab04_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Lab4_txtURL;
        private Button Lab4_btnSearch;
        private Button Lab4_btnSource;
        private Button Lab4_btnDownload;
    }
}