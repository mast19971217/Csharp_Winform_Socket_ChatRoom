using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySharedThings;
using LitJson;//JsonMapper处理json数据
using System.IO;//读取文件
using System.Net.Sockets;//Socket
using System.Net;//IPEndPoint

namespace TCP服务端
{
    public partial class MainWindow : Form//事实上为单例
    {
        List<User> users;//存储所有用户的账号名和密码
        bool ipok = true;//记录IP是否合法
        Socket tcpServer=null;//服务端socket，用于Listen监听
        Thread t=null;//开多线程用于Accept（阻塞）
         List<Client> clients = new List<Client>();
        int UserNumber = 0;//记录服务器当前连接数
           public MainWindow()
        {
            InitializeComponent();
        }
        //修改控件等操作全交给UI主控件做，不考虑lock等问题
        //Winform多线程学习文档：https://www.cnblogs.com/jianglai11/articles/1708330.html
        public void AddStringToListBox(int type, string t, Color color)
        //type:0代表UserList，1代表MessageList
        {
            if (this.InvokeRequired)//用于跨线程调用，若调用者来源非this线程（UI主线程)，return true
                this.BeginInvoke((Action<int, string, Color>)AddStringToListBox, type, t, color);
            //委托与方法组：https://blog.csdn.net/lijing_hi/article/details/11888487
            else
            {
                if (type == 0)
                {
                    tbxUserInfo.SelectionColor = color;//设置插入的富文本的颜色
                    tbxUserInfo.AppendText(t);//插入文本
                }
                else
                {
                    tbxMessage.Text += t;
                }
            }
        }
        public void ChangeUserNumberLabel(int n)//用于跨线程修改UI主线程控件
        {
            if (this.InvokeRequired)
                this.BeginInvoke((Action<int>)ChangeUserNumberLabel, n);
            else
                lblUserNumber.Text = (int.Parse(lblUserNumber.Text) + n).ToString();
            //先转成int再转回string
            
        }
        public  void Erase(Client t)
        {
              if(clients.Remove(t))//返回移除是否成功
            {   //client对象从列表中移除时，代表用户登出，显示登出信息
                this.BeginInvoke((Action<int, string, Color>)this.AddStringToListBox, 0,
                        string.Format("[Time<{0}>-From<{1}>-User<{3}>]\r\n{2}\r\n", DateTime.Now.ToLocalTime(), t.iPEndPoint.ToString(), "登出",t.user.Name)
                        , Color.Red);
                this.BeginInvoke((Action<int>)ChangeUserNumberLabel, -1);//连接数-1
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {   try
            {
                users= JsonMapper.ToObject<List<User>>(File.ReadAllText("UserList.json"));
              
             }
            catch(Exception ex)//JsonMapper解析json失败，会抛出异常
            {
                
                MessageBox.Show("解析exe所在目录下的UserList.json时发生错误，错误信息：\n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();//彻底退出程序
            }
            comboboxIpV4.DataSource = Method.GetLocalIpV4s();
            
        }

        private void comboboxIpV4_Validating(object sender, CancelEventArgs e)
        {
            var t = Method.ValidateIPAddress(comboboxIpV4.Text);
            lblhint.Visible = !t;
            ipok = t;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            Method.NumberOnly_KeyPress(e);
        }
        public void SendMessage(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            try
            {
                foreach (var item in clients)
                {
                    item.clientSocket.Send(bytes);
                }
            }
            catch { }

        }
        void StartListen()
        {
            
            clients = new List<Client>();
            byte[] bytes = new byte[1024];
            while (true)//接受多个客户端连接
            {   
                Socket clientSocket = tcpServer.Accept();//获取客户端socket，阻塞
                clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout,3000);
                //设置Receive超时时间为3s（send无所谓），超时时抛出异常   
                int length;
                string jsonString="";
                try
                {
                    length =clientSocket.Receive(bytes, 1024, SocketFlags.None);//接收登陆的json信息,最长1024信息
                    jsonString = Encoding.UTF8.GetString(bytes, 0, length);//从0开始，解析length长的byte
                    if (length == 0)//客户方正常断线
                    { Method.CloseSocket(clientSocket);
                        continue;//不进行Json解析，直接侦听下一个客户端
                    }
                }
                catch//客户方非正常断线或Recievie超时
                {   
                    Method.CloseSocket(clientSocket);
                    continue;//不进行Json解析，直接侦听下一个客户端
                }
              
                try
                {
                    User user = JsonMapper.ToObject<User>(jsonString);
                    if (users.Contains(user) && !clients.Any((n)=>n.user.Name==user.Name)) 
                    { clientSocket.Send(BitConverter.GetBytes(true));
                        Client client = new Client(clientSocket,this,user);
                        clients.Add(client);
                    }//TODO:登陆成功
                    else { clientSocket.Send(BitConverter.GetBytes(false));
                        Method.CloseSocket(clientSocket);
                    }//TODO：登陆失败
                }
                catch//防止json解析失败
                {             
                        try
                        {
                            clientSocket.Send(BitConverter.GetBytes(false));//登陆失败
                        }
                        catch { }//不处理，即使Send失败也是断开Socket
                        Method.CloseSocket(clientSocket);               
                }

            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            
            if(!ipok||String.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("信息填写不完整！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpServer.Bind(new IPEndPoint(IPAddress.Parse(comboboxIpV4.Text), int.Parse(txtPort.Text)));
                tcpServer.Listen(10);//最多接收10台主机的连接，开始监听
                MessageBox.Show("开始监听！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t = new Thread(StartListen);
                t.IsBackground = true;//设置为后台进程
                t.Start();
                btnListen.Enabled = false;
                btnStop.Enabled = true;
                lblState.Text = "服务端状态：开启";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                foreach (var item in clients)
                {
                    item.CloseClientSocket();//关闭socket
                    item.t.Abort();//关闭线程,注意会有个异常抛出，让线程进catch          
                }
                Method.CloseSocket(tcpServer, false);////该socket用于监听客户端，所以不用shutdown（无连接）
                if(t!=null&&t.IsAlive) t.Abort();//关闭监听线程

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;//作用：再向外层抛出异常
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                lblState.Text = "服务端状态：关闭";
                btnListen.Enabled = true;//无论成功与否，这里按键的State理应都要改变
                btnStop.Enabled = false;
                MainWindow_FormClosing(null, null);//若出现异常，这里会弹出提示窗，并抛出异常，不继续执行
                MessageBox.Show("关闭服务端！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            { }//不作处理，直接跳过try即可

            }

        private void btncCearInfo_Click(object sender, EventArgs e)
        {
            tbxUserInfo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxMessage.Text = "";
        }
        
    }
}
