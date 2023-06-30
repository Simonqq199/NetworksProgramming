namespace networksLAB03
{
    partial class Form3
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
            txbIP = new TextBox();
            txbPort = new TextBox();
            label3 = new Label();
            btnSend = new Button();
            rtxbMessage = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 53);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "IP remote host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 53);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // txbIP
            // 
            txbIP.Location = new Point(59, 88);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(395, 27);
            txbIP.TabIndex = 2;
            // 
            // txbPort
            // 
            txbPort.Location = new Point(513, 88);
            txbPort.Name = "txbPort";
            txbPort.Size = new Size(174, 27);
            txbPort.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 155);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Message";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(59, 379);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // rtxbMessage
            // 
            rtxbMessage.Location = new Point(59, 178);
            rtxbMessage.Name = "rtxbMessage";
            rtxbMessage.Size = new Size(628, 195);
            rtxbMessage.TabIndex = 7;
            rtxbMessage.Text = "";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 450);
            Controls.Add(rtxbMessage);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(txbPort);
            Controls.Add(txbIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbIP;
        private TextBox txbPort;
        private Label label3;
        private Button btnSend;
        private RichTextBox rtxbMessage;
    }
}