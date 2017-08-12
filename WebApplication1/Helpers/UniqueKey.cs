﻿using System.Security.Cryptography;
using System.Text;

namespace Helpers
{
    class UniqueKey
    {
        public static string GenerateHashCode(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string GenerateId(string url)
        {
            return GenerateHashCode(url).Substring(0, 6);
        }
    }
}
