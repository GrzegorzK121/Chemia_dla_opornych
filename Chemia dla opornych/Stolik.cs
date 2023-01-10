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

        public PictureBox pictureBox;
        public Label podpis;
        public Fiolka fiolka;

        public Stolik(PictureBox p, Label pp, Fiolka f)
        {
            pictureBox = p;
            podpis = pp;
            fiolka = f;
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

            return gTop > sTop - 0 && gTop < sTop + sHeight + 0 && gLeft > sLeft - 150 && gLeft < sLeft + sWidth + 150;
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

            return gTop > sTop - 75 && gTop < sTop + sHeight + 75 && gLeft > sLeft - 75 && gLeft < sLeft + sWidth + 75;
        }

        public void pokazStolik()
        {
            pictureBox.Image = fiolka.naStole;
            pictureBox.Visible = true;
            podpis.Text = fiolka.substancja;
        }

        public void resetujStolik()
        {
            pictureBox.Image = fiolka.naStole;
            fiolka.jestZabrana = false;
            podpis.Text = fiolka.substancja;
        }

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
