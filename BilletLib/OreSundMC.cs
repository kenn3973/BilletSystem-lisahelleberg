using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    class OreSundMC : Køretøj
    {
        public OreSundMC()
        {
        }
        public override string KøretøjsType()
        {
            return "Øresund MC";
        }

        public override int Pris()
        {
            return 210;
        }

        public int BizzPris()
        {
            return 73;
        }
    }
}
