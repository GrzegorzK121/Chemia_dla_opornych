using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chemia_dla_opornych
{
    
    public class Fiolka
    {

        public string substancja;
        public Image naStole, wZasiegu, zabrana;
        public bool jestZabrana, jestwZasiegu;

        public Fiolka(string s, Image n, Image w, Image z)
        {
            substancja = s;
            naStole = n;
            wZasiegu = w;
            zabrana = z;
            jestZabrana = false;
            jestwZasiegu = false;
        }

    }
}
