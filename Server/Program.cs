﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			int port = 4444;
			string localIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();

			Server server = new Server(localIP, port);
			server.PrintToConsoleAsLogMessage("Server Started on " + localIP + ":" + port);
			server.Start();
			server.Stop();
		}
	}
}
