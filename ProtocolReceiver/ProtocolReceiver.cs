﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util = CCUtil.CCUtil;

namespace ProtocolReceiver
{
    class ProtocolReceiver
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 1209);
            listener.Start();
            Console.WriteLine("Started listening.");
            TcpClient client = listener.AcceptTcpClient();
            Console.WriteLine("Client Connected. {0} <-- {1}", client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

            Console.ReadLine();
        }
    }
}
