﻿using System;
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

        //Imaginary external network library

        //Network.Download action callback from class Network
        static void Download()
        {
            Network.Download((message) => Console.WriteLine("Data Assmilated..." + message));
        }

        //static void OnDownloaded()
        //{
        //    Console.WriteLine("Data assimilated...");
        //}

        //Action keyword activates callback
        //Encapsulates Task.Run methods etc b/c they have 0 params

        class Network
        {
            static public void Download(Action<String> callback)
            {
                Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    callback("completed!");
                });
            }
        }
    }
}
