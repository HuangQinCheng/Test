using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        private static string sServerIP = GetLocalIpAddress("InterNetwork")[0];//获取ipv4类型的ip;
        private static int iPort = 50001;
        private static Socket socketListener;
        private static Thread thread;
        static void Main(string[] args)
        {
            thread = new Thread(Process);
            //thread.IsBackground = true;
            thread.Start();
            //Console.ReadLine();
        }

        private static void Process()
        {
            Action<string> showMessageDelegate;
            showMessageDelegate = ShowMessage;
            showMessageDelegate("服务器正在启动监听.....");
            
            socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = IPAddress.Parse(sServerIP);
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, iPort);
            socketListener.Bind(iPEndPoint);
            socketListener.Listen(10);
            showMessageDelegate("服务器启动成功!");
            while (true)
            {
                try
                {
                   
                    Socket socket = socketListener.Accept();
                    int messageLength = -1;
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    messageLength = socket.Receive(buffer);
                    if (messageLength != 0)
                    {
                        string msg = System.Text.Encoding.UTF8.GetString(buffer, 0, messageLength);
                        showMessageDelegate(msg);
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
        }

        private static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// 获取本机所有ip地址
        /// </summary>
        /// <param name="netType">"InterNetwork":ipv4地址，"InterNetworkV6":ipv6地址</param>
        /// <returns>ip地址集合</returns>
        public static List<string> GetLocalIpAddress(string netType)
        {
            string hostName = Dns.GetHostName();                    //获取主机名称  
            IPAddress[] addresses = Dns.GetHostAddresses(hostName); //解析主机IP地址  

            List<string> IPList = new List<string>();
            if (netType == string.Empty)
            {
                for (int i = 0; i < addresses.Length; i++)
                {
                    IPList.Add(addresses[i].ToString());
                }
            }
            else
            {
                //AddressFamily.InterNetwork表示此IP为IPv4,
                //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                for (int i = 0; i < addresses.Length; i++)
                {
                    if (addresses[i].AddressFamily.ToString() == netType)
                    {
                        IPList.Add(addresses[i].ToString());
                    }
                }
            }
            return IPList;
        }
    }
}
