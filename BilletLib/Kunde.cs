using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Kunde
    {
        private string Navn;
        public List<Køretøj> Ture { get; set; }

        public Kunde(String navn)
        {
            this.Navn = navn;
            this.Ture = new List<Køretøj>();
        }

        public void PrintTure()
        {
            foreach (var tu in Ture)
            {
                Console.WriteLine("{0} har passeret broen {1} gange", Navn, tu.GetAntalTureOverBro());
            }
        }
    }
}
