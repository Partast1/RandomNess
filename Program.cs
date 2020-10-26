using System;
using System.Security.Cryptography;


namespace RandomNess
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1 benchmark
            //RNGcrypt rbgc = new RNGcrypt();
            //RNGNormal rNG = new RNGNormal();
            //rbgc.RandomCtyptoNumber(10000);
            //rNG.RandomNumber(10000);


            //Assignment 2 cipher
            string key = "jfkgotmyvhspcandxlrwebquizæøå";
            string plainText = "the quick brown fox jumps over the lazy dog";
            
            var encrypted = Encrypter.Encrypt(plainText,key);
            Console.WriteLine(encrypted);
            var decrypted = Decrypter.Decrypt(encrypted, key);
            Console.WriteLine(decrypted);

        }

    }
}
