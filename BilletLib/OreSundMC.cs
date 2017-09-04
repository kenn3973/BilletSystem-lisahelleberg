using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class OreSundMC : Køretøj
    {
        public OreSundMC() : base()
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

        public int BroBizzRabatOresund()
        {
            if (bizz)
                return BizzPris();
            else
                return Pris();
        }
    }
}
