using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNess
{
    public class Decrypter
    {
        public static string Decrypt(string cipherText, string key)
        {
            char[] chars = new char[cipherText.Length];

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = key.IndexOf(cipherText[i]) + 97;
                    chars[i] = (char)j;
                }
            }

            return new string(chars);
        }
    }
}
