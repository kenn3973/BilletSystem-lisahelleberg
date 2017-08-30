using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøj
    {
        public string nummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public Bil()
        {

        }
        public override int Pris()
        {
            return 240;
        }

        public override string KøretøjsType()
        {
            return "Bil";
        }
    }
    
}
