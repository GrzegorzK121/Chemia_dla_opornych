using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chemia_dla_opornych
{
    /// <summary>
    /// Stolik z substancją chemiczną, którą gracz może zabrać
    /// </summary>
    public class Stolik
    {

        /// <summary>
        /// Obiekt klasy PictureBox, który wyświetla stolik w oknie gry
        /// </summary>
        public PictureBox pictureBox;

        /// <summary>
        /// Etykieta (obiekt klasy Label), która jest umieszczona poniżej stolika. 
        /// Wyświetla nazwę substacji chemicznej, która jest umieszczona na stoliku
        /// </summary>
        public Label podpis;

        /// <summary>
        /// Obiekt klasy Fiolka, zawierający informacje o substancji chemicznej
        /// znajdującej się na stoliku, takie jak nazwa i obrazki 
        /// </summary>
        public Fiolka fiolka;


        /// <summary>
        /// Trorzy obiekt stolika
        /// </summary>
        /// <param name="p">Obiekt klasy PictureBox, który wyświetla stolik w oknie gry</param>
        /// <param name="pp">Etykieta, która wyświetla nazwę substacji chemicznej</param>
        /// <param name="f">Obiekt klasy Fiolka, zawierający informacje o substancji chemicznej</param>
        public Stolik(PictureBox p, Label pp, Fiolka f)
        {
            pictureBox = p;
            podpis = pp;
            fiolka = f;
        }

        /// <summary>
        /// Funckja sprawdza, czy gracz jest dość blisko stolika, żeby mógł zabrać
        /// fiolkę znajdującą się na stoliku albo ją odłożyć
        /// </summary>
        /// <param name="gracz">Obiekt klasy PictureBox, który wyświetla gracza w oknie gry</param>
        /// <returns>Zwraca true, jeżeli gracz jest w pobliżu stolika, false w przciwnym przypadku </returns>
        public bool czyJestBlisko(PictureBox gracz)
        {
            int sTop, sLeft, sWidth, sHeight;
            int gTop, gLeft;

            sTop = pictureBox.Top;
            sLeft = pictureBox.Left;
            sWidth = pictureBox.Width;
            sHeight = pictureBox.Height;

            gTop = gracz.Top + gracz.Height / 2;
            gLeft = gracz.Left + gracz.Width / 2;

            return gTop > sTop - 0 && gTop < sTop + sHeight + 0 && gLeft > sLeft - 150 && gLeft < sLeft + sWidth + 150;
        }

        /// <summary>
        /// Funkcja sprawdza, czy wykonująj ruch gracz nie podejdzie zbyt blisko stolika. 
        /// Jeżeli tak, to ruch nie zostanie wykonany
        /// </summary>
        /// <param name="gracz">Obiekt klasy PictureBox, który wyświetla gracza w oknie gry</param>
        /// <param name="newLeft">Współrzędna x gracza</param>
        /// <param name="newTop">Współrzędna y gracza</param>
        /// <returns>Zwraca true, jeżeli gracz wchodzi na stolik, false w przeciwnym przypadku</returns>
        public bool czyWlazlNaStolik(PictureBox gracz, int newLeft, int newTop)
        {
            int sTop, sLeft, sWidth, sHeight;
            int gTop, gLeft;

            sTop = pictureBox.Top;
            sLeft = pictureBox.Left;
            sWidth = pictureBox.Width;
            sHeight = pictureBox.Height;

            gTop = newTop + gracz.Height / 2;
            gLeft = newLeft + gracz.Width / 2;

            return gTop > sTop - 75 && gTop < sTop + sHeight + 75 && gLeft > sLeft - 75 && gLeft < sLeft + sWidth + 75;
        }

        /// <summary>
        /// Wyswietla stolik w polu gry
        /// </summary>
        public void pokazStolik()
        {
            pictureBox.Image = fiolka.naStole;
            pictureBox.Visible = true;
            podpis.Text = fiolka.substancja;
        }

        /// <summary>
        /// Resetuje stolik, czyli ustawia stan stolika jak na początku misji
        /// </summary>
        public void resetujStolik()
        {
            pictureBox.Image = fiolka.naStole;
            fiolka.jestZabrana = false;
            podpis.Text = fiolka.substancja;
        }

        /// <summary>
        /// Wyświetla albo ukrywa nazwę substancji, która jest na stoliku.
        /// Jeżeli gracz jest blisko stolika, nazwa zostanie wyświetlona,
        /// a kiedy gracz jest daleko od stolika, nazwa zostanie ukryta
        /// </summary>
        /// <param name="gracz"></param>
        public void coJestNaStoliku(PictureBox gracz)
        {
            if (fiolka.jestZabrana)
            {
                return;
            }

            if (!fiolka.jestwZasiegu && czyJestBlisko(gracz))
            {
                fiolka.jestwZasiegu = true;
                pictureBox.Image = fiolka.wZasiegu;
                podpis.Visible = true;
            }
            else if (fiolka.jestwZasiegu && !czyJestBlisko(gracz))
            {
                fiolka.jestwZasiegu = false;
                pictureBox.Image = fiolka.naStole;
                podpis.Visible = false;
            }
        }

    }
}
