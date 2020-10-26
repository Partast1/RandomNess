using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNess
{
    public class Encrypter
    {
        public static string Encrypt(string plainText, string key)
        {
            Encoding test = Encoding.UTF8;
            char[] chars = new char[plainText.Length];
            //chars = test.GetBytes(plainText);
            
            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = plainText[i] - 97;
                    chars[i] = key[j];
                }
            }

            return new string(chars);
        }
    }
}
