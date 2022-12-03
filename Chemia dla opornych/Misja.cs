using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemia_dla_opornych
{
    internal class Misja
    {
        public String opisMisji;
        public String napisKońcowy;
        public int punkty;
        public Stolik[] stoliki;
        public bool[] maZebrac;

        public Misja(String om, String nk, int p, Stolik[] s, bool[] mz)
        {
            opisMisji = om;
            napisKońcowy = nk;
            punkty = p;
            stoliki = s;    
            maZebrac = mz;
        }

        public void zacznijMisje()
        {
            foreach (Stolik stolik in stoliki)
            {
                stolik.pokazStolik();
            }

        }
    }
}
