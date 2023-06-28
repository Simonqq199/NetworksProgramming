namespace N106.N21.ATCL_LAB03
{
    partial class Lab3B1UDPClient
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textHostIP = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.HostIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(43, 325);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 27);
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(43, 115);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(517, 204);
            this.textMessage.TabIndex = 29;
            this.textMessage.Text = "Message here";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(460, 46);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 22);
            this.textPort.TabIndex = 28;
            // 
            // textHostIP
            // 
            this.textHostIP.Location = new System.Drawing.Point(43, 47);
            this.textHostIP.Name = "textHostIP";
            this.textHostIP.Size = new System.Drawing.Size(411, 22);
            this.textHostIP.TabIndex = 27;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(50, 87);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(64, 16);
            this.Message.TabIndex = 26;
            this.Message.Text = "Message";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(457, 27);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(31, 16);
            this.Port.TabIndex = 25;
            this.Port.Text = "Port";
            // 
            // HostIP
            // 
            this.HostIP.AutoSize = true;
            this.HostIP.Location = new System.Drawing.Point(50, 27);
            this.HostIP.Name = "HostIP";
            this.HostIP.Size = new System.Drawing.Size(98, 16);
            this.HostIP.TabIndex = 24;
            this.HostIP.Text = "IP Remote host";
            // 
            // Lab3B1UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 379);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHostIP);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.HostIP);
            this.Name = "Lab3B1UDPClient";
            this.Text = "UDP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textHostIP;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label HostIP;
    }
}