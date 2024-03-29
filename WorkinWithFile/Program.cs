﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkinWithFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @" C:\DEMO\mingiTekst.txt";
            //Read file content
            List<string> lines = File.ReadAllLines(path).ToList();

            foreach(string line in lines)
            {
                Console.WriteLine($"{line} is on the list");
            }

            Console.WriteLine("Let's add an item: ");
            string userItem = Console.ReadLine();

            lines.Add(userItem);

            File.WriteAllLines(path, lines);

            List<string> lines1 = File.ReadAllLines(path).ToList();
            foreach (string line in lines1)
            {
                Console.WriteLine($"{line} is on the list");
            }

            Console.ReadLine();
        }
    }
}
