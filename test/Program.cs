﻿using System;
using Copernicus.SSURL;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Console.WriteLine(string.Join(",", SSURL.Parse(Console.ReadLine())));
                Console.WriteLine(SSURL.Create("bf-cfb","233","2.33.33.33",2333));
                Console.ReadLine();
            }
        }
    }
}