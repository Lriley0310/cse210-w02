﻿using System;
using System.Collections.Generic;

namespace Myapp //Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("bob");
            names.Add("billz");
            names.Add("Sue");

            names.ForEach(name => Console.Write(name + " "));

            string aString = "a";
            List<string> stuff = new List<string> {aString, "b", "c", "d"};

            char aSingleCharacter = 'a';
            Console.WriteLine($"This is a single character: {aSingleCharacter}");

            int x = 5;
            int y = 7;
            int result = Adder(x,y); //12
            
            int result2 = Adder(10,46); // 56

            Console.WriteLine($"{x} + {y} = {result}");
        }

        static int Adder(int a, int b)
        {
            return a + b;
        }

    }
}