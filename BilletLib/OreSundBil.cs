using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class OreSundBil : Køretøj
    {
        public OreSundBil() : base()
        {
        }
        public override string KøretøjsType()
        {
            return "Øresund Bil";
        }

        public override int Pris()
        {
            return 410;
        }

        public int BizzPris()
        {
            return 161;
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
