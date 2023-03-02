using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using Common; // Library with necessary logic.

namespace Server
{
    /// <summary>
    /// Represents entry point to the server.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method of the server.
        /// </summary>
        /// <param name="args">Arguments passed to the server.</param>
        static void Main(string[] args)
        {
            // The name of server endpoint.
            const string endpointName = "TextFunctions.soap";

            // Creating channel between server and client.
            // 5000 - port number
            HttpChannel ch = new HttpChannel(5000);

            // Registering channel ch with the help of RegisterChannel method.
            // false - disabling security
            ChannelServices.RegisterChannel(ch, false);

            // Registering the serveice as Well-known object.
            // Singleton = every incoming message is serviced by the same object instance.
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(TaskHelper),
                endpointName,
                WellKnownObjectMode.Singleton);

            // Notyfing about successful service start.
            Console.WriteLine("TextFunctions service is ready...");

            // Running the service until <Enter> key clicked.
            Console.ReadLine();
        }
    }
}
