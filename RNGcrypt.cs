using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace RandomNess
{
    class RNGcrypt
    {
        //Assignment 1 benchmark

        public void RandomCtyptoNumber(int times)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                Stopwatch stopwatch = new Stopwatch();
                byte[] data = new byte[4];
                stopwatch.Start();

                for (int i = 0; i < times; i++)
                {
                    rng.GetBytes(data);

                    int value = BitConverter.ToInt32(data, 0);
                    //Console.WriteLine(value);
                }
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                Console.WriteLine(ts);

            }
        }
        
    }
}
