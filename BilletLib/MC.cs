using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC
    {
        public string nummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public MC()
        {

        }

        public int Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
