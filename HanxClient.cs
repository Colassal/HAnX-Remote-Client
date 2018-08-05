using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAnX_RemoteConnect
{
    class HanxClient
    {
        static void HanxTCP(string switchIpAddress, int switchPort) {
            TcpClient HanxCli;
            byte[] switchStreamData = new byte[20480];
            string userInput, stringData;

            try {
                HanxCli = new TcpClient(switchIpAddress, switchPort);
                Console.WriteLine("Connected to server. Enter commands or type EXIT to quit at any time.");
            } catch(SocketException) {
                Console.WriteLine("Unable to connect to server, please check your info and try again");
                Console.ReadKey();
                return;
            }

            NetworkStream HanxStream = HanxCli.GetStream();
        }
    }
}