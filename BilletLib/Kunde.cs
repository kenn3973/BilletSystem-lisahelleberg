using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    class Kunde
    {
        private string navn;
        public List<Køretøj> Ture { get; set; }

        public Kunde()
        {
            this.Ture = new List<Køretøj>();
        }

    }
}
