namespace LANTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelChess = new Panel();
            panel2 = new Panel();
            picbAvatar = new PictureBox();
            panel3 = new Panel();
            picbMark = new PictureBox();
            button1 = new Button();
            txtbIPAddress = new TextBox();
            progressBar1 = new ProgressBar();
            txtbPlayerName = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbAvatar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbMark).BeginInit();
            SuspendLayout();
            // 
            // panelChess
            // 
            panelChess.BackColor = SystemColors.ActiveBorder;
            panelChess.Location = new Point(4, 5);
            panelChess.Name = "panelChess";
            panelChess.Size = new Size(600, 600);
            panelChess.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(picbAvatar);
            panel2.Location = new Point(619, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 269);
            panel2.TabIndex = 1;
            // 
            // picbAvatar
            // 
            picbAvatar.BackgroundImage = Properties.Resources.IMG_20220102_174533;
            picbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            picbAvatar.InitialImage = (Image)resources.GetObject("picbAvatar.InitialImage");
            picbAvatar.Location = new Point(3, 3);
            picbAvatar.Name = "picbAvatar";
            picbAvatar.Size = new Size(277, 263);
            picbAvatar.TabIndex = 0;
            picbAvatar.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(picbMark);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtbIPAddress);
            panel3.Controls.Add(progressBar1);
            panel3.Controls.Add(txtbPlayerName);
            panel3.Location = new Point(620, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 318);
            panel3.TabIndex = 2;
            // 
            // picbMark
            // 
            picbMark.Location = new Point(165, 3);
            picbMark.Name = "picbMark";
            picbMark.Size = new Size(114, 142);
            picbMark.TabIndex = 4;
            picbMark.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(21, 119);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtbIPAddress
            // 
            txtbIPAddress.Location = new Point(3, 86);
            txtbIPAddress.Name = "txtbIPAddress";
            txtbIPAddress.Size = new Size(156, 27);
            txtbIPAddress.TabIndex = 2;
            txtbIPAddress.Text = "192.168.1.1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 51);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(156, 29);
            progressBar1.TabIndex = 1;
            // 
            // txtbPlayerName
            // 
            txtbPlayerName.Location = new Point(0, 18);
            txtbPlayerName.Name = "txtbPlayerName";
            txtbPlayerName.Size = new Size(156, 27);
            txtbPlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 626);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelChess);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbAvatar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbMark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChess;
        private Panel panel2;
        private PictureBox picbAvatar;
        private Panel panel3;
        private PictureBox picbMark;
        private Button button1;
        private TextBox txtbIPAddress;
        private ProgressBar progressBar1;
        private TextBox txtbPlayerName;
    }
}