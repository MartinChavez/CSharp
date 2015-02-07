using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Threads
{
    [TestClass]
    public class Threads
    {
        [TestMethod]
        public void SyncronousExecution()
        {
            DownloadSynchronously();
            Debug.WriteLine("Waiting to finish on thread {0} ...", Thread.CurrentThread.ManagedThreadId); //At all time, the ThreadId is the same during execution.
        }

        private static void DownloadSynchronously()
        {
            string[] urls =
            {
                "https://www.google.com/",
                "https://www.apple.com/",
                "http://www.microsoft.com/"

            };

            foreach (var url in urls)
            {
                var client = new WebClient();
                var html = client.DownloadString(url);
                Debug.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url,Thread.CurrentThread.ManagedThreadId);
            }

        }

        [TestMethod]
        public void AsyncronousSystemExecution()
        {
            DownloadSystemAynchronously();
            Debug.WriteLine("Waiting to finish on thread {0} ...", Thread.CurrentThread.ManagedThreadId);
        }

        private static void DownloadSystemAynchronously()
        {
            string[] urls =
            {
                "https://www.google.com/",
                "https://www.apple.com/",
                "http://www.microsoft.com/"

            };

            foreach (var url in urls)
            {
                var thread = new Thread(Download); //Old way of doing threads, user has to Start/Stop, not a great level of abstraction
                thread.Start(url);
            }

        }


        private static void Download(object url)
        {
            var client = new WebClient();
            var html = client.DownloadString((url.ToString()));
            Debug.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url, Thread.CurrentThread.ManagedThreadId);
        }

        [TestMethod]
        public void AsyncronousSystemEventsExecution()
        {
            DownloadSystemEventsAynchronously(); //When using events for threading, you lose readability
            Debug.WriteLine("Waiting to finish on thread {0} ...", Thread.CurrentThread.ManagedThreadId);
        }

        private static void DownloadSystemEventsAynchronously()
        {
            string[] urls =
            {
                "https://www.google.com/",
                "https://www.apple.com/",
                "http://www.microsoft.com/"

            };

            foreach (var url in urls)
            {
                DownloadEvent(url);
            }

        }


        private static void DownloadEvent(string url)
        {
            var client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri(url), url); //Most .net I/O methods provide an async method
   
        }

        static void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var html = e.Result;
            var url = e.UserState as string;
            Debug.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url, Thread.CurrentThread.ManagedThreadId);
        }

        [TestMethod]
        public void AsyncronousTaskExecution()
        {
            DownloadTaskAsynchronously();
            Debug.WriteLine("Waiting to finish on thread {0} ...", Thread.CurrentThread.ManagedThreadId);
        }

        private static void DownloadTaskAsynchronously()
        {
            string[] urls =
            {
                "https://www.google.com/",
                "https://www.apple.com/",
                "http://www.microsoft.com/"

            };
            //Prefered way to do threading since it is easier to read and makes efficient use of the thread pools
            Parallel.ForEach(urls, url =>
            {
                var client = new WebClient();
                var html = client.DownloadString(url);
                Debug.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url, Thread.CurrentThread.ManagedThreadId);
            });

        }

    }
}
