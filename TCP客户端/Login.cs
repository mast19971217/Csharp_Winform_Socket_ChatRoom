using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySharedThings;
using System.Net;
using System.Net.Sockets;
using LitJson;
namespace TCP服务端
{
    public partial class Login : Form
    {
        bool ipok = true;//记录IP地址是否合法
        public Socket tcpClient;//Socket
        public Login()
        {
            InitializeComponent();
            
        }

        private void checkBoxshowpsd_CheckedChanged(object sender, EventArgs e)
        {   if (checkBoxshowpsd.Checked)
                txtPsd.PasswordChar = default(char);//显示密码
            else
                txtPsd.PasswordChar = '*';//隐藏密码
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            Method.NumberOnly_KeyPress(e);
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(!ipok||String.IsNullOrEmpty(txtPort.Text)|| String.IsNullOrEmpty(txtName.Text)
                ||String.IsNullOrEmpty(txtPsd.Text))
            {
                MessageBox.Show("信息填写不完整！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //1.创建Socket
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //2.发起连接请求
                IPAddress iPAddress = IPAddress.Parse(comboboxIpV4.Text);//处理IP地址
                tcpClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000); //设置receive超时时间,超时抛异常                                                    
                EndPoint point = new IPEndPoint(iPAddress, int.Parse(txtPort.Text));////IP地址，端口号
                tcpClient.Connect(point);//连接对应的IP地址和端口号
                MessageBox.Show("连接到服务端成功！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //传输账号名和密码的json字符串
                User user = new User(txtName.Text, txtPsd.Text);
                tcpClient.Send(Encoding.UTF8.GetBytes(JsonMapper.ToJson(user)));
                byte[] temp = new byte[sizeof(bool)];
                tcpClient.Receive(temp, sizeof(bool), SocketFlags.None);
              if (BitConverter.ToBoolean(temp, 0) == true)
                    MessageBox.Show("登陆成功！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("账号或密码错误或该账号已经登录聊天室！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Method.CloseSocket(tcpClient);
                    return;
                }
                this.Hide();
                var frmsendmessage = new SendMessage();
                frmsendmessage.Show(this);//设置sendmessage的父窗口为login，方便窗口间信息传递

            }
            catch (Exception ex)//捕捉运行时出错（这一长段try基本上只可能出Socket方面的错误，关闭Socket）
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Method.CloseSocket(tcpClient);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboboxIpV4.DataSource = Method.GetLocalIpV4s();
        }

        private void comboboxIpV4_Validating(object sender, CancelEventArgs e)
        {
            var t = Method.ValidateIPAddress(comboboxIpV4.Text);
            lblhint.Visible = !t;
            ipok = t;
        }
    }
}
