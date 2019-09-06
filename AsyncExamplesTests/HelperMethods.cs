using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AsyncExamplesTests
{
    partial class SaladTests
    {
        public SaladTests()
        {
            File.Delete("salad.txt");
        }

        private string ReadSaladFile()
        {
            Thread.Sleep(50);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!File.Exists("salad.txt"))
            {
                if (stopwatch.ElapsedMilliseconds > 3000) throw new TimeoutException();
            }
            return File.ReadAllText("salad.txt");
        }
    }
}
