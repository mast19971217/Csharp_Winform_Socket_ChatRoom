namespace TCP服务端
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboboxIpV4 = new System.Windows.Forms.ComboBox();
            this.lblIpAdress = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblhint = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncCearInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxUserInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboboxIpV4
            // 
            this.comboboxIpV4.FormattingEnabled = true;
            this.comboboxIpV4.Location = new System.Drawing.Point(154, 75);
            this.comboboxIpV4.Name = "comboboxIpV4";
            this.comboboxIpV4.Size = new System.Drawing.Size(121, 20);
            this.comboboxIpV4.TabIndex = 17;
            this.comboboxIpV4.Validating += new System.ComponentModel.CancelEventHandler(this.comboboxIpV4_Validating);
            // 
            // lblIpAdress
            // 
            this.lblIpAdress.AutoSize = true;
            this.lblIpAdress.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIpAdress.Location = new System.Drawing.Point(50, 75);
            this.lblIpAdress.Name = "lblIpAdress";
            this.lblIpAdress.Size = new System.Drawing.Size(109, 20);
            this.lblIpAdress.TabIndex = 16;
            this.lblIpAdress.Text = "IpV4地址：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(113, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "服务端设定";
            // 
            // lblhint
            // 
            this.lblhint.AutoSize = true;
            this.lblhint.ForeColor = System.Drawing.Color.Red;
            this.lblhint.Location = new System.Drawing.Point(104, 98);
            this.lblhint.Name = "lblhint";
            this.lblhint.Size = new System.Drawing.Size(161, 12);
            this.lblhint.TabIndex = 19;
            this.lblhint.Text = "请输入格式正确的IpV4地址！";
            this.lblhint.Visible = false;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(165, 134);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 21;
            this.txtPort.Text = "7788";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPort.Location = new System.Drawing.Point(49, 134);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(89, 20);
            this.lblPort.TabIndex = 20;
            this.lblPort.Text = "端口号：";
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("宋体", 15F);
            this.btnListen.Location = new System.Drawing.Point(40, 161);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(119, 43);
            this.btnListen.TabIndex = 22;
            this.btnListen.Text = "开启监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("宋体", 15F);
            this.btnStop.Location = new System.Drawing.Point(197, 161);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 43);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "关闭服务端";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(151, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "用户登录信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(455, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "接收到的消息";
            // 
            // btncCearInfo
            // 
            this.btncCearInfo.Location = new System.Drawing.Point(141, 417);
            this.btncCearInfo.Name = "btncCearInfo";
            this.btncCearInfo.Size = new System.Drawing.Size(75, 23);
            this.btncCearInfo.TabIndex = 31;
            this.btncCearInfo.Text = "清空";
            this.btncCearInfo.UseVisualStyleBackColor = true;
            this.btncCearInfo.Click += new System.EventHandler(this.btncCearInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxUserInfo
            // 
            this.tbxUserInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUserInfo.Location = new System.Drawing.Point(12, 257);
            this.tbxUserInfo.Name = "tbxUserInfo";
            this.tbxUserInfo.ReadOnly = true;
            this.tbxUserInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbxUserInfo.Size = new System.Drawing.Size(385, 154);
            this.tbxUserInfo.TabIndex = 34;
            this.tbxUserInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "当前用户连接数：";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Location = new System.Drawing.Point(245, 239);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(11, 12);
            this.lblUserNumber.TabIndex = 36;
            this.lblUserNumber.Text = "0";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("宋体", 10F);
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(103, 55);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(119, 14);
            this.lblState.TabIndex = 37;
            this.lblState.Text = "服务端状态：关闭";
            // 
            // tbxMessage
            // 
            this.tbxMessage.BackColor = System.Drawing.Color.White;
            this.tbxMessage.Location = new System.Drawing.Point(413, 78);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(248, 362);
            this.tbxMessage.TabIndex = 38;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnListen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 452);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblUserNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUserInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncCearInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblhint);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboboxIpV4);
            this.Controls.Add(this.lblIpAdress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxIpV4;
        private System.Windows.Forms.Label lblIpAdress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblhint;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncCearInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbxUserInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbxMessage;
    }
}

