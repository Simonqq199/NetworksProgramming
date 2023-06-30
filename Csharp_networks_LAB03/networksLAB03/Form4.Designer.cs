namespace networksLAB03
{
    partial class Form4
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
            ServerPortB1 = new TextBox();
            btnB1Listen = new Button();
            label2 = new Label();
            messagelist1 = new ListView();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // ServerPortB1
            // 
            ServerPortB1.Location = new Point(89, 34);
            ServerPortB1.Name = "ServerPortB1";
            ServerPortB1.Size = new Size(125, 27);
            ServerPortB1.TabIndex = 1;
            // 
            // btnB1Listen
            // 
            btnB1Listen.Location = new Point(618, 32);
            btnB1Listen.Name = "btnB1Listen";
            btnB1Listen.Size = new Size(94, 29);
            btnB1Listen.TabIndex = 2;
            btnB1Listen.Text = "Listen";
            btnB1Listen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 95);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Received message";
            // 
            // messagelist1
            // 
            messagelist1.Location = new Point(39, 131);
            messagelist1.Name = "messagelist1";
            messagelist1.Size = new Size(673, 230);
            messagelist1.TabIndex = 4;
            messagelist1.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(303, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 461);
            Controls.Add(btnExit);
            Controls.Add(messagelist1);
            Controls.Add(label2);
            Controls.Add(btnB1Listen);
            Controls.Add(ServerPortB1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ServerPortB1;
        private Button btnB1Listen;
        private Label label2;
        private ListView messagelist1;
        private Button btnExit;
    }
}