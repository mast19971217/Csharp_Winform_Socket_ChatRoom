namespace TCP服务端
{
    partial class Login
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
            this.lblIpAdress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.checkBoxshowpsd = new System.Windows.Forms.CheckBox();
            this.lblhint = new System.Windows.Forms.Label();
            this.comboboxIpV4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIpAdress
            // 
            this.lblIpAdress.AutoSize = true;
            this.lblIpAdress.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIpAdress.Location = new System.Drawing.Point(25, 72);
            this.lblIpAdress.Name = "lblIpAdress";
            this.lblIpAdress.Size = new System.Drawing.Size(109, 20);
            this.lblIpAdress.TabIndex = 0;
            this.lblIpAdress.Text = "IpV4地址：";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPort.Location = new System.Drawing.Point(25, 140);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(89, 20);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "端口号：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(25, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "密码：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(64, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "上海大学聊天室";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(141, 139);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "7788";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtPsd
            // 
            this.txtPsd.Location = new System.Drawing.Point(141, 210);
            this.txtPsd.Name = "txtPsd";
            this.txtPsd.PasswordChar = '*';
            this.txtPsd.Size = new System.Drawing.Size(100, 21);
            this.txtPsd.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("宋体", 15F);
            this.btnConnect.Location = new System.Drawing.Point(64, 272);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(149, 39);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "登录";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // checkBoxshowpsd
            // 
            this.checkBoxshowpsd.AutoSize = true;
            this.checkBoxshowpsd.Location = new System.Drawing.Point(141, 237);
            this.checkBoxshowpsd.Name = "checkBoxshowpsd";
            this.checkBoxshowpsd.Size = new System.Drawing.Size(72, 16);
            this.checkBoxshowpsd.TabIndex = 12;
            this.checkBoxshowpsd.Text = "显示密码";
            this.checkBoxshowpsd.UseVisualStyleBackColor = true;
            this.checkBoxshowpsd.CheckedChanged += new System.EventHandler(this.checkBoxshowpsd_CheckedChanged);
            // 
            // lblhint
            // 
            this.lblhint.AutoSize = true;
            this.lblhint.ForeColor = System.Drawing.Color.Red;
            this.lblhint.Location = new System.Drawing.Point(52, 106);
            this.lblhint.Name = "lblhint";
            this.lblhint.Size = new System.Drawing.Size(161, 12);
            this.lblhint.TabIndex = 13;
            this.lblhint.Text = "请输入格式正确的IpV4地址！";
            this.lblhint.Visible = false;
            // 
            // comboboxIpV4
            // 
            this.comboboxIpV4.FormattingEnabled = true;
            this.comboboxIpV4.Location = new System.Drawing.Point(141, 72);
            this.comboboxIpV4.Name = "comboboxIpV4";
            this.comboboxIpV4.Size = new System.Drawing.Size(121, 20);
            this.comboboxIpV4.TabIndex = 14;
            this.comboboxIpV4.Validating += new System.ComponentModel.CancelEventHandler(this.comboboxIpV4_Validating);
            // 
            // Login
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 325);
            this.Controls.Add(this.comboboxIpV4);
            this.Controls.Add(this.lblhint);
            this.Controls.Add(this.checkBoxshowpsd);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPsd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIpAdress);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIpAdress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPsd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox checkBoxshowpsd;
        private System.Windows.Forms.Label lblhint;
        private System.Windows.Forms.ComboBox comboboxIpV4;
    }
}

