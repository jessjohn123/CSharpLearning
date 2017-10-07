using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyFirstConsoleApp
{
    class ServerManager
    {
        List<Server> servers = new List<Server>
        {
            new Server() { Name = "Server1", RAM=8, Status=true, Location="Asia"},
            new Server() { Name = "Server2", RAM=16, Status=true, Location="Europe"},
            new Server() { Name= "Server3", RAM=32, Status=false, Location="NorthAmerica"},
             new Server() { Name = "Server4", RAM=16, Status=true, Location="Asia"},
              new Server() { Name = "Server5", RAM=32, Status=true, Location="Asia"},
        };

        public void PrintOfflineAsianServerWithLotsOfRam()
        {
            foreach(var server in servers)
            {
                if(server.Location=="Asia" && server.RAM > 8 && server.Status)
                {
                    Console.WriteLine(server);
                }
            }
        }

        public void printOfflineAsianServerWithLotsOfRam()
        {
            var targetServers = from s in servers
                                where s.Location == "Asia" &&
                                    s.RAM > 8 &&
                                    s.Status == true
                                    orderby s.Name descending
                                select s;
            foreach (var server in targetServers)
            {
                Console.WriteLine(server);
            }
        }

        public void printOfflineServerWithLocation()
        {
            var targetServers = from s in servers
                                where s.Status==true
                                orderby s.Location descending
                                select s;
            foreach (var server in targetServers)
            {
                Console.WriteLine(server);
            }

            servers.Add(new Server() { Name = "Server6", Location = "Europe", RAM = 8, Status = true });

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine();

            foreach (var server in targetServers)
            {
                Console.WriteLine(server);
            }

        }

        public void printOfflineServerWithLocationSecon()
        {
            var targetServers = from s in servers
                                where s.Status == true
                                orderby s.Location descending
                                select s;

            Console.WriteLine($"Number of offline servers: {targetServers.Count()}");

            servers.Add(new Server() { Name = "Server6", Location = "Europe", RAM = 8, Status = true });

            Console.WriteLine($"Number of offline servers: {targetServers.Count()}");

        }
    }
}
