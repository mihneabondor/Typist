using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using WebSocketSharp.Server;
using WebSocketSharp;
using Typist.Websocket_service;
using System.Windows.Forms;

namespace Typist
{
    public static class WebsocketService
    {
        public static string address = "ws://";
        public static string cryptedAddress = "";
        public static string incomingText = "";
        public static string outgoingText = "";

        public static WebSocketServer wssv;
        public static WebSocket ws;

        static WebsocketService()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in nics)
                foreach (UnicastIPAddressInformation x in ni.GetIPProperties().UnicastAddresses)
                    if (x.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && (address == "ws://" || address == "127.0.0.1"))
                        address += x.Address.ToString();

            int port;
            bool good = false;
            for (port = 1000; !good; ++port)
            {
                bool isAvailable = true;

                IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

                foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
                {
                    if (tcpi.LocalEndPoint.Port == port)
                    {
                        isAvailable = false;
                        break;
                    }
                }

                if (isAvailable)
                {
                    try
                    {
                        IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
                        TcpListener tcpListener = new TcpListener(ipAddress, port);
                        tcpListener.Start();
                        tcpListener.Stop();
                    }
                    catch
                    {
                        isAvailable = false;
                    }
                    good = isAvailable;
                }
            }
            cryptedAddress = crypt(address);
            //host();
        }

        private static string crypt(string s)
        {
            string sol = "";
            for (int i = s.LastIndexOf('/') + 1; i < s.Length; i++)
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int aux = s[i] - '0';
                    char c = (char)('A' + aux);
                    sol += c;
                }
                else if (s[i] == '.') sol += '-';
                else sol += '+';
            return sol;
        }

        public static string decrypt(string s)
        {
            string sol = "";
            Console.WriteLine(s);
            foreach (char elem in s)
            {
                if (elem >= 'A' && elem <= 'Z')
                    sol += elem - 'A';
                else if (elem == '-')
                    sol += '.';
                else sol += ':';
            }

            return sol;
        }

        public static void host()
        {
            wssv = new WebSocketServer(address);
            wssv.AddWebSocketService<OrganizationWSBehavior>("/OrganizationWSBehavior");
            wssv.Start();
        }

        public static bool connect(string code, string username)
        {
            string aux = "ws://" + decrypt(code) + "/OrganizationWSBehavior";
            try
            {
                ws = new WebSocket(aux);
                ws.Connect();
                ws.OnMessage += wsOnMessage;

                ws.Send(username); //anuntam venirea
            }
            catch
            {
                MessageBox.Show("Eroare la conectare!");
                return false;
            }

            return true;
        }

        private static void wsOnMessage(object sender, MessageEventArgs e)
        {
            incomingText = e.Data.ToString().Trim();
        }

        public static void sendFromServer(string text)
        {
            if (wssv != null)
            {
                wssv.WebSocketServices["/OrganizationWSBehavior"].Sessions.Broadcast(text);
            }
        }

        public static void stopServer()
        {
            if(wssv != null)
                wssv.Stop();    
        }

        public static void disconnect()
        {
            if(ws != null)
                ws.Close();
        }

        public static void sendMessage()
        {
            if(ws != null && ws.IsAlive)
            {
                ws.Send(outgoingText);
            }
        }
        

    }
}
