using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet2
{
    internal class Kreds
    {
        //Properties: 

        private string id;
        private string navn;
        private string adresse;
        private int antalDeltagere;


        // Constructor:

        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            Id = id;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;
        }

        //getters and setters

        public string Id { get; set; }
        public string Navn { get; set; }

        public string Adresse { get; set; }
        public int AntalDeltagere { get; set; }


        public override string ToString()
        {
            return  $"Kreds information: {Id}, {Navn}, {Adresse}, {AntalDeltagere}";
        }
    }
}

