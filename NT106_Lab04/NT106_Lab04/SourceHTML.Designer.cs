namespace NT106_Lab04
{
    partial class SourceHTML
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
            rtbSource = new RichTextBox();
            SuspendLayout();
            // 
            // rtbSource
            // 
            rtbSource.Location = new Point(12, 12);
            rtbSource.Name = "rtbSource";
            rtbSource.Size = new Size(776, 426);
            rtbSource.TabIndex = 0;
            rtbSource.Text = "";
            // 
            // SourceHTML
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbSource);
            Name = "SourceHTML";
            Text = "SourceHTML";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbSource;
    }
}