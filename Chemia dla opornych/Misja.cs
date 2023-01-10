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
        public String opisSkrocony;
        public int punkty;
        public Stolik[] stoliki;
        public bool[] maZebrac;
        public bool koniec = false;
        public int minPunkty;

        public Misja(String om, String os, int p, Stolik[] s, bool[] mz)
        {
            opisMisji = om;
            opisSkrocony = os;
            punkty = p;
            stoliki = s;    
            maZebrac = mz;
            minPunkty = p/2;
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
