namespace TCP服务端
{
    partial class SendMessage
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
            this.button1 = new System.Windows.Forms.Button();
            this.textboxMessage = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.CleanTextBox = new System.Windows.Forms.Button();
            this.MyMessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(29, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送消息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxMessage
            // 
            this.textboxMessage.Location = new System.Drawing.Point(14, 227);
            this.textboxMessage.Multiline = true;
            this.textboxMessage.Name = "textboxMessage";
            this.textboxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxMessage.Size = new System.Drawing.Size(411, 66);
            this.textboxMessage.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("宋体", 9F);
            this.lbltitle.Location = new System.Drawing.Point(12, 212);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(293, 12);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "请输入要发送的消息（文本大小最多为1024个字节）：";
            // 
            // CleanTextBox
            // 
            this.CleanTextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.CleanTextBox.Location = new System.Drawing.Point(249, 308);
            this.CleanTextBox.Name = "CleanTextBox";
            this.CleanTextBox.Size = new System.Drawing.Size(138, 39);
            this.CleanTextBox.TabIndex = 4;
            this.CleanTextBox.Text = "清空消息框";
            this.CleanTextBox.UseVisualStyleBackColor = true;
            this.CleanTextBox.Click += new System.EventHandler(this.CleanTextBox_Click);
            // 
            // MyMessageBox
            // 
            this.MyMessageBox.BackColor = System.Drawing.Color.White;
            this.MyMessageBox.ForeColor = System.Drawing.Color.Black;
            this.MyMessageBox.Location = new System.Drawing.Point(14, 12);
            this.MyMessageBox.Multiline = true;
            this.MyMessageBox.Name = "MyMessageBox";
            this.MyMessageBox.ReadOnly = true;
            this.MyMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MyMessageBox.Size = new System.Drawing.Size(411, 197);
            this.MyMessageBox.TabIndex = 5;
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 359);
            this.Controls.Add(this.MyMessageBox);
            this.Controls.Add(this.CleanTextBox);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.textboxMessage);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SendMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendMessage_FormClosing);
            this.Load += new System.EventHandler(this.SendMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxMessage;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button CleanTextBox;
        private System.Windows.Forms.TextBox MyMessageBox;
    }
}