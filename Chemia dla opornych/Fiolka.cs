using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chemia_dla_opornych
{
    /// <summary>
    /// Przechowuje informacje o substancji chemicznej umieszczonej na stoliku w laboratorium
    /// </summary>
    public class Fiolka
    {
        /// <summary>
        /// Nazwa substancji
        /// </summary>
        public string substancja;

        /// <summary>
        /// Obrazek wyświetlany, kiedy fiolka jest na stoliku, a gracz jest daleko
        /// </summary>
        public Image naStole;

        /// <summary>
        /// Obrazek wyświetlany, kiedy fiolka jest na stoliku, a gracz jest w pobliżu i może zabrać fiolkę
        /// </summary>
        public Image wZasiegu;

        /// <summary>
        /// Obrazek wyświetlany, kiedy fiolki nie ma na stoliku
        /// </summary>
        public Image zabrana;

        /// <summary>
        /// True, jeżeli fiolka została już zabrana 
        /// </summary>
        public bool jestZabrana;

        /// <summary>
        /// True, jeżeli gracz jest dość blisko, żeby zabrać fiolkę
        /// </summary>
        public bool jestwZasiegu;

        /// <summary>
        /// Konstruktor klasy Fiolka
        /// </summary>
        /// <param name="s">Nazwa substancji</param>
        /// <param name="n">Obrazek wyświetlany, kiedy fiolka jest na stoliku, a gracz jest daleko</param>
        /// <param name="w">Obrazek wyświetlany, kiedy fiolka jest na stoliku, a gracz jest w pobliżu i może zabrać fiolkę</param>
        /// <param name="z">Obrazek wyświetlany, kiedy fiolki nie ma na stoliku</param>
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
