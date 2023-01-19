using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemia_dla_opornych
{
    /// <summary>
    /// Dane misji, czyli etapu gry.
    /// Przechowuje informacje o tym co znajduje się na stolikach i co ma być zebrane przez gracza
    /// </summary>
    public class Misja
    {
        /// <summary>
        /// Opis misji
        /// </summary>
        public String opisMisji;

        /// <summary>
        /// Opis misji, w skrócie
        /// </summary>
        public String opisSkrocony;

        /// <summary>
        /// Maksymalna liczba punktów za misję
        /// </summary>
        public int punkty;

        /// <summary>
        /// Obiekt Stolik, z fiolką składnika chemicznego
        /// </summary>
        public Stolik[] stoliki;

        /// <summary>
        /// Tablica informująca które składniki są potrzebne
        /// </summary>
        public bool[] maZebrac;

        /// <summary>
        /// Ustawiane na True, kiedy misja zostanie skończona przez gracza
        /// </summary>
        public bool koniec = false;

        /// <summary>
        /// Minimalna liczba punktów
        /// </summary>
        public int minPunkty;

        /// <summary>
        /// Tworzy obiekt misji
        /// </summary>
        /// <param name="om">Opis misji</param>
        /// <param name="os">Opis misji, w skrócie</param>
        /// <param name="p">Liczba punktów za misję</param>
        /// <param name="s">Obiekt Stolik, z fiolką składnika chemicznego</param>
        /// <param name="mz">Tablica informująca które składniki są potrzebne</param>
        public Misja(String om, String os, int p, Stolik[] s, bool[] mz)
        {
            opisMisji = om;
            opisSkrocony = os;
            punkty = p;
            stoliki = s;    
            maZebrac = mz;
            minPunkty = p/2;
        }

        /// <summary>
        /// Funkcja powoduje pojawienie się stolików, powinna być wywołana na początku misji
        /// </summary>
        public void zacznijMisje()
        {
            foreach (Stolik stolik in stoliki)
            {
                stolik.pokazStolik();
            }

        }
    }
}
