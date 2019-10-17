using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemotingService.RemotingService remotingService = new IRemotingService.RemotingService();
            TcpChannel channel = new TcpChannel(8081);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(IRemotingService.RemotingService), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting Service started at {0}",DateTime.Now);
            Console.ReadLine();
        }
    }
}
