using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAnX_RemoteConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverIpAddr;
            int serverPort;
            string uMenuInput;

            byte[] streamData = new byte[102400];
            string userInput, stringData;
            TcpClient haxServer;

            while(true)
            {
                consoleHeader();
                Console.WriteLine("\n\n\nSelect Option: 1 = Start 2 = Exit");
                uMenuInput = Console.ReadLine();

                if(uMenuInput == "1")
                {
                    while(true)
                    {
                        consoleHeader();
                        uMenuInput = "";
                        serverIpAddr = getServerIp();
                        serverPort = getServerPort();
                        if (serverIpAddr.Length > 0 && serverPort > 0)
                            break; 
                    }

                    consoleHeader();
                    Console.WriteLine("Loading...");

                    try
                    {
                        haxServer = new TcpClient(serverIpAddr, serverPort);
                        Console.WriteLine("Server Connected! Enter Commands, Or type EXIT to return to main menu.");
                    } catch(SocketException)
                    {
                        Console.WriteLine("Unable to connect to server. Please check connections and try again. \n Press Any Key To Exit");
                        Console.ReadKey();
                        return;
                    }
                    NetworkStream hackNs = haxServer.GetStream();

                    int recv = hackNs.Read(streamData, 0, streamData.Length);
                    stringData = Encoding.ASCII.GetString(streamData, 0, recv);
                    Console.WriteLine(stringData);
                    bool uInCheck = false;

                    while(true)
                    {
                        System.Threading.Thread.Sleep(100);

                        streamData = new byte[102400];
                        recv = hackNs.Read(streamData, 0, streamData.Length);
                        stringData = Encoding.ASCII.GetString(streamData, 0, recv);
                        Console.WriteLine(stringData);
                       


                        System.Threading.Thread.Sleep(100);

                        if(!hackNs.DataAvailable)
                        {
                            while(true)
                            {
                                Console.WriteLine(">> ");
                                System.Threading.Thread.Sleep(16);
                                if (!hackNs.DataAvailable)
                                {
                                    userInput = Console.ReadLine();
                                    if (userInput.Length > 0)
                                    {
                                        uInCheck = true;
                                        break;
                                    }
                                        
                                } else
                                {
                                    userInput = "";
                                    uInCheck = false;
                                    break;
                                }
                                
                            }

                            if(uInCheck)
                            {
                                if (userInput.ToUpper() == "EXIT")
                                    break;
                                hackNs.Write(Encoding.ASCII.GetBytes(userInput), 0, userInput.Length);
                                hackNs.Flush();
                            }
                        }
                        /*
                        streamData = new byte[102400];
                        recv = hackNs.Read(streamData, 0, streamData.Length);
                        stringData = Encoding.ASCII.GetString(streamData, 0, recv);
                        Console.WriteLine(stringData);
                        */
                    }
                    Console.WriteLine("Disconnecting From Server...");
                    hackNs.Flush();
                    hackNs.Close();
                    haxServer.Close();


                }
                else if(uMenuInput == "2")
                {
                    consoleHeader();
                    Console.WriteLine("Press Any Key To Close");
                    Console.ReadKey();
                    break;
                }
            }
        }

        public static void consoleHeader()
        {
            Console.Clear();
            Console.WriteLine("----------Net Cheat Windows Remote Client----------");
            Console.WriteLine("-----Version 1.0 By Colassal -- Rev. 7/31/2018-----\n\n");
        }

        public static string getServerIp()
        {
            string ipAddr;
            string usrConf;

            while (true)
            {
                Console.WriteLine("Enter your switch's IP address:");
                ipAddr = Console.ReadLine();
                Console.WriteLine("Confirm The IP address is " + ipAddr + " Y/N.");
                usrConf = Console.ReadLine().ToUpper();

                if (usrConf == "Y" || usrConf == "YES")
                {
                    return ipAddr;
                }
                else if (usrConf == "N" || usrConf == "NO")
                {
                    consoleHeader();
                }
            }
        }

        public static string Right(string sValue, int iMaxLength)
        {
            //Check if the value is valid
            if (string.IsNullOrEmpty(sValue))
            {
                //Set valid empty string as string could be null
                sValue = string.Empty;
            }
            else if (sValue.Length > iMaxLength)
            {
                //Make the string no longer than the max length
                sValue = sValue.Substring(sValue.Length - iMaxLength, iMaxLength);
            }

            //Return the string
            return sValue;
        }

        public static int getServerPort()
        {
            int svcPort;
            string usrConf;

            while (true)
            {
                Console.WriteLine("Enter your switch's port (5555 default):");
                svcPort = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Confirm the port is " + svcPort + " Y/N.");
                usrConf = Console.ReadLine().ToUpper();

                if (usrConf == "Y" || usrConf == "YES")
                {
                    return svcPort;
                }
                else if (usrConf == "N" || usrConf == "NO")
                {
                    consoleHeader();
                }
            }
        }


    }

}
