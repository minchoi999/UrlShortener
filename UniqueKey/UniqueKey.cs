using System;
using System.Security.Cryptography;
using System.Text;

namespace UniqueKey
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

        public static string GenerateIdEx(string url)
        {
            return GenerateHashCode(url).Substring(0, 6);
        }

        /* Returns 000000 if url id is empty or null, or else increments by 1 then returns the new id string*/
        public static string GenerateID(string id, string url)
        {
            char[] idChar = id.ToCharArray();
            int idInt = 0;
            for (int i = 0; i < 6; i++)
            {
                if (idChar[i] == '0')
                {
                    idInt += (0 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '1')
                {
                    idInt += (1 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '2')
                {
                    idInt += (2 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '3')
                {
                    idInt += (3 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '4')
                {
                    idInt += (4 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '5')
                {
                    idInt += (5 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '6')
                {
                    idInt += (6 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '7')
                {
                    idInt += (7 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '8')
                {
                    idInt += (8 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == '9')
                {
                    idInt += (9 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'a')
                {
                    idInt += (10 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'b')
                {
                    idInt += (11 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'c')
                {
                    idInt += (12 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'd')
                {
                    idInt += (13 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'e')
                {
                    idInt += (14 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'f')
                {
                    idInt += (15 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'g')
                {
                    idInt += (16 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'h')
                {
                    idInt += (17 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'i')
                {
                    idInt += (18 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'j')
                {
                    idInt += (19 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'k')
                {
                    idInt += (20 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'l')
                {
                    idInt += (21 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'm')
                {
                    idInt += (22 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'n')
                {
                    idInt += (23 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'o')
                {
                    idInt += (24 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'p')
                {
                    idInt += (25 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'q')
                {
                    idInt += (26 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'r')
                {
                    idInt += (27 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 's')
                {
                    idInt += (28 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 't')
                {
                    idInt += (29 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'u')
                {
                    idInt += (30 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'v')
                {
                    idInt += (31 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'w')
                {
                    idInt += (32 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'x')
                {
                    idInt += (33 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'y')
                {
                    idInt += (34 * (int)Math.Pow(35, 5 - i));
                }
                else if (idChar[i] == 'z')
                {
                    idInt += (35 * (int)Math.Pow(35, 5 - i));
                }
            }
            string idString = "";
            idInt = idInt + 1;
            int remainder;
            for (int j = 0; j < 6; j++)
            {
                remainder = idInt % 35;
                if (remainder == 0)
                    idString = "0" + idString;
                else if (remainder == 1)
                    idString = "1" + idString;
                else if (remainder == 2)
                    idString = "2" + idString;
                else if (remainder == 3)
                    idString = "3" + idString;
                else if (remainder == 4)
                    idString = "4" + idString;
                else if (remainder == 5)
                    idString = "5" + idString;
                else if (remainder == 6)
                    idString = "6" + idString;
                else if (remainder == 7)
                    idString = "7" + idString;
                else if (remainder == 8)
                    idString = "8" + idString;
                else if (remainder == 9)
                    idString = "9" + idString;
                else if (remainder == 10)
                    idString = "a" + idString;
                else if (remainder == 11)
                    idString = "b" + idString;
                else if (remainder == 12)
                    idString = "c" + idString;
                else if (remainder == 13)
                    idString = "d" + idString;
                else if (remainder == 14)
                    idString = "e" + idString;
                else if (remainder == 15)
                    idString = "f" + idString;
                else if (remainder == 16)
                    idString = "g" + idString;
                else if (remainder == 17)
                    idString = "h" + idString;
                else if (remainder == 18)
                    idString = "i" + idString;
                else if (remainder == 19)
                    idString = "j" + idString;
                else if (remainder == 20)
                    idString = "k" + idString;
                else if (remainder == 21)
                    idString = "l" + idString;
                else if (remainder == 22)
                    idString = "m" + idString;
                else if (remainder == 23)
                    idString = "n" + idString;
                else if (remainder == 24)
                    idString = "o" + idString;
                else if (remainder == 25)
                    idString = "p" + idString;
                else if (remainder == 26)
                    idString = "r" + idString;
                else if (remainder == 27)
                    idString = "s" + idString;
                else if (remainder == 28)
                    idString = "t" + idString;
                else if (remainder == 29)
                    idString = "u" + idString;
                else if (remainder == 30)
                    idString = "v" + idString;
                else if (remainder == 31)
                    idString = "w" + idString;
                else if (remainder == 32)
                    idString = "x" + idString;
                else if (remainder == 33)
                    idString = "y" + idString;
                else if (remainder == 34)
                    idString = "z" + idString;
                idInt = idInt / 35;
            }

            return idString;
        }
    }
}
