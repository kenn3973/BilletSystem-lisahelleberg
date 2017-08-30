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
        public DateTime Dato { get; set; }
        public bool bizz = false;
        public double weekendRabat = 0.20;
        #endregion

        public Køretøj(string np)
        {
            this.nummerPlade = np;
            this.bizz = false;
        }

        public abstract int Pris();
        public abstract string KøretøjsType();

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
