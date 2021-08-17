using System;
using System.Collections.Generic;
using System.Net;//用于获取IP地址
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;//正则表达式
using System.Linq;
namespace MySharedThings
{
 
    public static class Method//静态类，只含有静态成员，无法实例化
    {
           
        public static void NumberOnly_KeyPress(System.Windows.Forms.KeyPressEventArgs e)
            //只允许输入数字
        {   
            if(e.KeyChar!='\b')//允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                    e.Handled = true;//事件已处理，即不接收非0-9的其他按键
            }
        }
        public static bool ValidateIPAddress(string ipAddress)//判断IP地址是否合法
        {
            Regex validipregex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            return (ipAddress != "" && validipregex.IsMatch(ipAddress.Trim())) ? true : false;
        }
        public static List<string> GetLocalIpV4s()
        {
            List<string> iplist = new List<string>{ "127.0.0.1"};

            try//可能获取不到IPV4地址，不处理即可，这样下拉框中只有一个127.0.0.1
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        iplist.Add(IpEntry.AddressList[i].ToString());
                    }
                }
            }
            catch { }
            return iplist;
        }
        public static void  CloseSocket(Socket s,bool ShutDown=true)
        {
            if (s == null) return;//不重复closeSocket
            try//有时会有玄学异常抛出，不处理即可
            {   if(ShutDown)
                s.Shutdown(SocketShutdown.Both);
            }
            catch { }
            s.Close();
            s = null;
        }
    }
}
