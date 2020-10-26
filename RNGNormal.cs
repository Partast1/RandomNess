using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RandomNess
{
    //Assignment 1 benchmark

    class RNGNormal
    {
        public void RandomNumber(int times)
        {
            Stopwatch stopwatch = new Stopwatch();

            Random rnd = new Random(250);
            stopwatch.Start();

            for (int i = 0; i < times; i++)
            {
               var tal =  rnd.Next();
                //Console.WriteLine(tal);
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine(ts);

        }
    }
}
