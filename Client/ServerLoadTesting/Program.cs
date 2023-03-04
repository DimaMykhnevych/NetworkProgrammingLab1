using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace ServerLoadTesting
{
    internal class Program
    {
        /// <summary>
        /// The server URL to send requests.
        /// </summary>
        private const string serverUrl = "http://192.168.0.204:5286/ReverseText";

        static void Main(string[] args)
        {
            // Client to send HTTP requests.
            HttpClient httpClient = new HttpClient();

            // List of threads.
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 100_00; i++)
            {
                // HTTP POST request message to the serverUrl.
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, serverUrl)
                {
                    // String content in UTF-8 encoding.
                    // Will be send with content-type application/json.
                    Content = new StringContent("{\"text\":\"test\"}", System.Text.Encoding.UTF8, "application/json"),
                };

                // Creating thread that will send requests.
                Thread thread = new Thread(() =>
                {
                    httpClient.SendAsync(message).GetAwaiter().GetResult();
                });

                // Staring thread.
                thread.Start();
                threads.Add(thread);
            }

            Console.WriteLine("Joining threads");

            // Waiting for all threads to finish.
            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
