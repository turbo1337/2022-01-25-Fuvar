using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_25_Fuvar
{
    class Fuvar
    {
        public int TaxiID { get; set; }
        public String Indulas { get; set; }
        public int Idotartam { get; set; }
        public double Tavolsag { get; set; }
        public double Viteldij { get; set; }
        public double Borravalo { get; set; }
        public string Fizetesmod { get; set; }

        public Fuvar(string sor)    
        {
            string[] t = sor.Split(';');
            TaxiID = int.Parse(t[0]);
            Indulas = t[1];
            Idotartam = int.Parse(t[2]);
            Tavolsag = double.Parse(t[3]);
            Viteldij = double.Parse(t[4]);
            Borravalo = double.Parse(t[5]);
            Fizetesmod = t[6];
        }
    }
}
