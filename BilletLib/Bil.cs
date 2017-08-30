using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil
    {
        public string nummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public Bil()
        {

        }
        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
    
}
