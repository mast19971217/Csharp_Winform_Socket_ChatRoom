using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySharedThings;
using System.Windows.Forms;
using System.Net;
using System.Drawing;

namespace TCP服务端
{
    public class Client
    {
        public User user;//存储账号信息
        public Socket clientSocket;
        public IPEndPoint iPEndPoint;
        MainWindow MainWindowInstance;//获取MainWindow的this单例
        public Thread t;
        public Client(Socket s,MainWindow mainWindowInstance,User u)
        {
            user = u;
            MainWindowInstance = mainWindowInstance;
            clientSocket = s;
            iPEndPoint = clientSocket.RemoteEndPoint as IPEndPoint;
            MainWindowInstance.BeginInvoke((Action<int, string, Color>)MainWindowInstance.AddStringToListBox, 0,//初始化时就是登陆服务端，显示登陆信息
                        string.Format("[Time<{0}>-From<{1}>-User<{3}>]\r\n{2}\r\n", DateTime.Now.ToLocalTime(), iPEndPoint.ToString(), "登入", user.Name)
                        , Color.Green );
            MainWindowInstance.BeginInvoke((Action<int>)MainWindowInstance.ChangeUserNumberLabel, 1);//连接数+1
            t = new Thread(RecieveText);
            t.IsBackground = true;//设置为后台线程
            t.Start();//启动初始化
        }
        public void CloseClientSocket()
        {
            Method.CloseSocket(clientSocket);

        }
        public void RecieveText()
        {
            MainWindowInstance.SendMessage("欢迎" + user.Name + "进入上海大学聊天室!\r\n");
            clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 0);//无限制等待
            byte[] t = new byte[1024];
            while (true)
            {
                 try
                {
                    int length = clientSocket.Receive(t, 1024, SocketFlags.None);
                    if(length==0)//客户端断开（或服务器断开？）返回0字节长度byte,不重复close
                    {   
                        Method.CloseSocket(clientSocket);//TODO
                        MainWindowInstance.Erase(this);
                        MainWindowInstance.SendMessage("恭送" + user.Name + "离开上海大学聊天室!\r\n");
                        return;
                    }
                    string Message = Encoding.UTF8.GetString(t, 0, length);
                    //跨线程修改Winform控件
                    //获取远端终点EndPoint的相关Ip信息（强转为IPEndPoint）
                    string temp = string.Format("[Time<{0}>-From<{1}>-User<{3}>]\r\n{2}\r\n", DateTime.Now.ToLocalTime(), iPEndPoint.ToString(), Message, user.Name);
                    MainWindowInstance.BeginInvoke((Action<int, string,Color>)MainWindowInstance.AddStringToListBox, 1, 
                       temp
                        ,default(Color)
                        );
                    
                    MainWindowInstance.SendMessage(temp);
                }
                catch//防止异常断开
                {
                    Method.CloseSocket(clientSocket);
                   MainWindowInstance.Erase(this);
                    MainWindowInstance.SendMessage("恭送" + user.Name + "离开上海大学聊天室!\r\n");
                }
            }
        }
    }
}
