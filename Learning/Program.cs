using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computing Data...");
            Download();
            Console.ReadLine();
        }

        //using an built-in async function from .NET library
        
        //static async void Download()
        //{
        //    HttpClient client = new HttpClient();
        //    var data = await client.GetStringAsync("http://rouxacademy.com");
        //    Console.WriteLine("Data assimilated..." + data);
        //}
        //for next segment anonymous fuctions, callbacks and action to manage
        //program flow

        //Imaginary external network library

         static void Download()
        {
            Network.Download(OnDownloaded);
        }

        static void OnDownloaded()
        {
            Console.WriteLine("Data assimilated...");
        }

        class Network
        {
            static public void Download(Action callback)
            {
                Task.Run(() => {
                Thread.Sleep(3000);
                    callback();
            });
        }
    }
}
