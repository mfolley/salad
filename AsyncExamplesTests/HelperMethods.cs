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
            string salad = null;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            while (salad is null)
            {
                if (stopwatch.ElapsedMilliseconds > 3000) throw new TimeoutException();
                try
                {
                    salad = File.ReadAllText("salad.txt");
                }
                catch(IOException e)
                {
                    Trace.WriteLine($"{e.Message}, retrying");
                }
            }
            return salad;
        }
    }
}
