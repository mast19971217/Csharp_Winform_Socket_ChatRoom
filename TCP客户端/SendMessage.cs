using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using MySharedThings;
using System.Threading;

namespace TCP服务端
{
    public partial class SendMessage : Form
    {
        Login login;
        public Thread t;
        public SendMessage()
        {   
            InitializeComponent();
        }
        public void AddStringToBox(string t)
        //type:0代表UserList，1代表MessageList
        {
            if (this.InvokeRequired)//用于跨线程调用，若调用者来源非this线程（UI主线程)，return true
                this.BeginInvoke((Action<string>)AddStringToBox, t);
            
                else
                {
                    MyMessageBox.Text += t;
                }
            
        }
        void ReceiveMessage()
        {
            login.tcpClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);//无限制等待
            byte[] t = new byte[1024];
            while (true)
            {
               
                    int length = login.tcpClient.Receive(t, 1024, SocketFlags.None);
                    if (length == 0)//客户端断开（或服务器断开？）返回0字节长度byte,不重复close
                    {
                        MessageBox.Show("服务端已关闭！请关闭窗口并尝试重新登录！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string Message = Encoding.UTF8.GetString(t, 0, length);
                    this.BeginInvoke((Action<string>)AddStringToBox, Message);
                
            }
        }


        private void SendMessage_FormClosing(object sender, FormClosingEventArgs e)
        {   //关闭Socket连接
            try
            {
                Method.CloseSocket(login.tcpClient);
                t.Abort();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            login.Show();//窗口关闭时，显示父级窗口
        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            textboxMessage.Focus();//设置焦点为输入框
            login = this.Owner as Login;//获取父窗口相关信息，as：强制转换
            t = new Thread(ReceiveMessage);
            t.IsBackground = true;//设置为后台线程
            t.Start();//启动初始化
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textboxMessage.Text);
                textboxMessage.Text = "";//内容清零
                textboxMessage.Focus();//设置焦点为输入框
                if(bytes.Length==0||bytes.Length>1024)
                {
                    MessageBox.Show("不能为空字符且字符长度不能大于1024个字节", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {   if(login.tcpClient.Poll(10,SelectMode.SelectRead)&&login.tcpClient.Available==0)
                            //防止服务器断开后的第一次send依然显示成功，再次检测，原因详见Send方法
       
                        {         
                                MessageBox.Show("服务端已关闭！请关闭窗口并尝试重新登录！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        login.tcpClient.Send(bytes);
                        MessageBox.Show("发送成功！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();//Closing中带有关闭Socket
                    }
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanTextBox_Click(object sender, EventArgs e)
        {
            MyMessageBox.Text = "";
        }
    }
}
