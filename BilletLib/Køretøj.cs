using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Køretøj
    {
        #region instance fields
        public string nummerPlade { get; set; }
        //public DateTime Dato { get; set; }
        public bool bizz = false;
        public double bizzrabat = 0.05;
        private int antalTure;
        #endregion

        public Køretøj()
        {
            this.bizz = false;
            this.antalTure = 0;
        }

        public bool GetBizz()
        {
            return bizz;
        }

        public double BroBizzRabat()
        {
            if (bizz)
            {
                double nyPris = Pris() - (Pris() * bizzrabat);
                //nyPris = nyPris * 5;
                return nyPris;
                //return Pris() - nyPris;
                //return Pris() / 100 * 5 - Pris();
            }
            else
            {
                return Pris();
            }
        }


        //public DateTime GetDateNow()
        //{
        //    return DateTime;
        //}
        public abstract int Pris();
        public abstract string KøretøjsType();

        public void PasserBro()
        {
            antalTure = antalTure + 1;
            //return antalTure;
        }

        public int GetAntalTureOverBro()
        {
            return antalTure;
        }

        #region nummerplade
        public int TælINummerplade()
        {
            int countChar = nummerPlade.Count();
            return countChar;
        }

        public void TestNummerplade()
        {
            if (TælINummerplade() > 7)
            {
                throw new ArgumentException("Du har indtastet for mange tal i nummerpladen!");
            }
            else if (TælINummerplade() <= 0)
            {
                throw new ArgumentException("Du har glemt at indtaste en nummerplade!");
            }
        }
        #endregion
    }

}
