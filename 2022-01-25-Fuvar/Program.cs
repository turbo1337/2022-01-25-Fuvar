﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_25_Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();
            foreach (var sor in File.ReadAllLines("Fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            Console.WriteLine($"3.feladat: {fuvarok.Count} fuvar");

            Console.ReadKey();

        }
    }
}
