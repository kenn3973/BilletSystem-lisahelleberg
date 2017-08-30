using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Køretøj
    {
        public string nummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public Køretøj()
        {

        }

        public abstract int Pris();
        public abstract string KøretøjsType();

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
    }
}
