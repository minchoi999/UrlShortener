using System;
using System.Collections.Generic;
using UrlShortener.Models;

namespace UniqueKey
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>
            {
                "https://www.google.ca/",
                "https://www.naver.com/",
                "https://www.reddit.com/"
            };

            foreach (string url in urls)
            {
                Console.WriteLine(UniqueKey.GenerateIdEx(url));
            }

            Console.ReadLine();
        }
    }
}