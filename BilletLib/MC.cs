using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Køretøj
    {
        //public string nummerPlade { get; set; }
        //public DateTime Dato { get; set; }

        public MC()
        {

        }

        public override int Pris()
        {
            return 125;
        }

        public override string KøretøjsType()
        {
            return "MC";
        }
    }
}
