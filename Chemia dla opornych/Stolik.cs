using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chemia_dla_opornych
{
    public class Stolik
    {

        public Fiolka fiolka;
        public PictureBox pictureBox;

        public Stolik(PictureBox p, Fiolka f)
        {
            fiolka = f; 
            pictureBox = p;
        }

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

            return gTop > sTop - 120 && gTop < sTop + sHeight + 120 && gLeft > sLeft - 120 && gLeft < sLeft + sWidth + 120;
        }

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

            return gTop > sTop - 50 && gTop < sTop + sHeight + 50 && gLeft > sLeft - 50 && gLeft < sLeft + sWidth + 50;
        }

        public void pokazStolik()
        {
            pictureBox.Image = fiolka.naStole;
            pictureBox.Visible = true;
        }

        public void resetujStolik()
        {
            pictureBox.Image = fiolka.naStole;
            fiolka.jestZabrana = false;
        }

        public void AktualizujPozycje(PictureBox gracz)
        {
            if (fiolka.jestZabrana)
                return;

            if (!fiolka.jestwZasiegu && czyJestBlisko(gracz))
            {
                fiolka.jestwZasiegu = true;
                pictureBox.Image = fiolka.wZasiegu;
            }
            else if (fiolka.jestwZasiegu && !czyJestBlisko(gracz))
            {
                fiolka.jestwZasiegu = false;
                pictureBox.Image = fiolka.naStole;
            }
        }

    }
}
