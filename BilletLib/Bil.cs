using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøj
    {
        //public string nummerPlade { get; set; }
        //public DateTime Dato { get; set; }
        public double weekendRabat = 0.20;
        public int weekDay { get; set; }

        public Bil() : base()
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

        public double WeekendRabatBil()
        {
            if(bizz)
            {
                if (weekDay == 6 || weekDay == 7)
                {
                    double nyPris = Pris()-(Pris() * weekendRabat);
                    return nyPris;
                }
                else
                    return BroBizzRabat();
            }
            else
            {
                return Pris();
            }
            
        }
    }
    
}
