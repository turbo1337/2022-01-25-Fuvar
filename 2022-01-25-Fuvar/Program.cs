using System;
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

            int db = 0;
            double bevetel = 0;
            foreach (var f in fuvarok)
            {
                if (f.TaxiID==6185)
                {
                    db++;
                    bevetel += f.Viteldij + f.Borravalo;
                }
            }
            Console.WriteLine($"4.feladat: {db} fuvar alatt {bevetel} $");

            Console.WriteLine("5. feladat:");
            int bankkartya = 0;
            int keszpenz = 0;
            foreach (var f in fuvarok)
            {
                if (f.Fizetesmod== "bankkartya")
            }
            adatok.GroupBy(x => x.Fizetesimod).ToList().ForEach(x =>
           Console.WriteLine("\t{0}: {1} fuvar", x.Key, x.Count()));

            Console.WriteLine("6. feladat: {0} km", Math.Round(osszeskm, 2));



            Console.ReadKey();

        }
    }
}
