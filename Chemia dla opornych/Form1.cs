using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Chemia_dla_opornych
{
    public partial class plansza : Form
    {

        bool goLeft, goRight, goUp, goDown;
        int speed = 7;
        int czas = 0;

        Misja[] misje;

        bool moznaChodzic = false;
        int numerMisji = 0;
        int punkty = 0;
        int liczbaMisji;
        Misja obecnaMisja;
        Stolik[] stoliki;
        

        public plansza()
        {
            InitializeComponent();

            misje = new Misja[] {
                new Misja(
                    "Zbierz składniki do zrobienia wody, wzór H2O",
                    "Woda, wzór H2O",
                    100,
                    new Stolik[] {
                    new Stolik(table1, podpis1, new Fiolka("Węgiel",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Tlen",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Żelazo",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table4, podpis4, new Fiolka("Wodór",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table5, podpis5, new Fiolka("Siarka",
                        Properties.Resources.elipsePurple, Properties.Resources.elipsePurpleChoose, Properties.Resources.free)),
                    new Stolik(table6, podpis6, new Fiolka("",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free))
                    },
                    new bool[] { false, true, false, true, false, false }
                ),

                new Misja(
                    "Zbierz składniki do zrobienia soli, wzór NaCl",
                    "Sól kuchenna, NaCl",
                    100,
                    new Stolik[] {
                    new Stolik(table1, podpis1, new Fiolka("Sód",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Tlen",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Żelazo",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table4, podpis4, new Fiolka("Chlor",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table5, podpis5, new Fiolka("",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free)),
                    new Stolik(table6, podpis6, new Fiolka("Potas",
                        Properties.Resources.elipseBlue, Properties.Resources.elipseBlueChoose, Properties.Resources.free))
                    },
                    new bool[] { true, false, false, true, false, false }
                )
            };
            liczbaMisji = misje.Count();

            obecnaMisja = misje[0];
            stoliki = obecnaMisja.stoliki;
            obecnaMisja.zacznijMisje();

        }

        private void odtwarzajWav(String co)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.cooo);

            switch (co)
            {
                case "pling":
                    player = new SoundPlayer(Properties.Resources.pling);
                    break;
                case "pung":
                    player = new SoundPlayer(Properties.Resources.pung);
                    break;
                case "puup":
                    player = new SoundPlayer(Properties.Resources.puup);
                    break;
                case "cooo":
                    player = new SoundPlayer(Properties.Resources.cooo);
                    break;
                case "lot":
                    player = new SoundPlayer(Properties.Resources.lot);
                    break;
                case "alleluja":
                    player = new SoundPlayer(Properties.Resources.alleluja);
                    break;
            }

            player.Play();
        }

        private void sprawdzCoPrzynioslem ()
        {

            // nic nie ma?
            bool nic = true;
            for (int st = 0; st < stoliki.Count(); st++)
            {
                if (stoliki[st].fiolka.jestZabrana)
                    nic = false;
            }
            if (nic)
            {
                odtwarzajWav("cooo");
                return;
            }

            bool ok = true;
            for (int st = 0; st < stoliki.Count(); st++)
            {
                if (stoliki[st].fiolka.jestZabrana != obecnaMisja.maZebrac[st])
                    ok = false;
            }

            if (ok)
            {
                obecnaMisja.koniec = true;
                punkty += obecnaMisja.punkty;
                labelMisje.Text = "Misje: " + (numerMisji+1);
                labelSuma.Text = "Punkty: " + punkty;
                odtwarzajWav("alleluja");

                numerMisji++;

                if (numerMisji == liczbaMisji)
                {
                    labelOpis.Text = "KONIEC GRY!";
                    labelPunkty.Text = "";
                    moznaChodzic = false;
                    return;
                }

                obecnaMisja = misje[numerMisji];
                stoliki = obecnaMisja.stoliki;
                obecnaMisja.zacznijMisje();

                labelPunkty.Text = String.Format("Do zdobycia: {0}", obecnaMisja.punkty);
                labelOpis.Text = obecnaMisja.opisSkrocony;
                labelZebrane.Text = "";


                labelMisja.Text = "Misja " + (numerMisji + 1);
                textboxOpisMisji.Text = obecnaMisja.opisMisji;
                moznaChodzic = false;
                panelMisji.Visible = true;

            }
            else
            {
                odtwarzajWav("cooo");
                obecnaMisja.punkty -= 10;
                if (obecnaMisja.punkty < obecnaMisja.minPunkty)
                    obecnaMisja.punkty = obecnaMisja.minPunkty; 
                foreach (Stolik stolik in stoliki)
                    stolik.resetujStolik();

                labelPunkty.Text = String.Format("Do zdobycia: {0}", obecnaMisja.punkty);
                labelOpis.Text = obecnaMisja.opisSkrocony;
                labelZebrane.Text = "";


                labelMisja.Text = "Błąd, zacznij od nowa";
                moznaChodzic = false;
                panelMisji.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;

            numerMisji = 0;
            obecnaMisja = misje[numerMisji];
            
            labelMisja.Text = "Misja " + (numerMisji+1);
            textboxOpisMisji.Text = obecnaMisja.opisMisji;

            stoliki = obecnaMisja.stoliki;
            obecnaMisja.zacznijMisje();

            labelPunkty.Text = String.Format("Do zdobycia: {0}", obecnaMisja.punkty);
            labelOpis.Text = obecnaMisja.opisSkrocony;
            labelMisje.Text = "Misje: 0";
            labelSuma.Text = "Punkty: 0";

            panelMisji.Visible = true;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            panelMisji.Visible = false;
            moznaChodzic = true;
            player.Visible = true;
        }

        private void MainTimeEvent(object sender, EventArgs e)
        {
            if (!moznaChodzic) return;

            czas++;
            if (czas == 100)
            {
                if (obecnaMisja.punkty > obecnaMisja.minPunkty)
                {
                    obecnaMisja.punkty--;
                    labelPunkty.Text = String.Format("Do zdobycia: {0}", obecnaMisja.punkty);
                }

                czas = 0;
            }

            int newLeft, newTop;
            newLeft = player.Left;
            newTop = player.Top;


            if (goLeft && player.Left > 0)
            {
                newLeft = player.Left - speed;
            }
            if (goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                newLeft = player.Left + speed;
            }
            if (goUp && player.Top > 180)
            {
                newTop = player.Top - speed;
            }
            if (goDown && player.Top + player.Height < this.ClientSize.Height)
            {
                newTop = player.Top + speed;
            }

            foreach (Stolik stolik in stoliki)
            {
                stolik.coJestNaStoliku(player);
            }

            bool wlazlNaStolik = false;
            foreach (Stolik stolik in stoliki)
            {
                if (stolik.czyWlazlNaStolik(player, newLeft, newTop))
                    wlazlNaStolik = true;
            }

            if (!wlazlNaStolik)
            {
                player.Left = newLeft;
                player.Top = newTop;
            }

            labelPozycja.Text = String.Format("p:{0}-{1} n:{2}-{3} ?:{4}", player.Left, player.Top, newLeft, newTop, wlazlNaStolik);

        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (!moznaChodzic) return;

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                player.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.Space)
            {
                foreach (Stolik stolik in stoliki)
                {
                    if (stolik.fiolka.substancja=="" && stolik.czyJestBlisko(player))
                    {
                        odtwarzajWav("pling");
                    }
                    else if (!stolik.fiolka.jestZabrana && stolik.czyJestBlisko(player))
                    {
                        stolik.fiolka.jestZabrana = true;
                        stolik.pictureBox.Image = stolik.fiolka.zabrana;
                        stolik.podpis.Visible = false;
                        odtwarzajWav("puup");
                    }
                    else if (stolik.fiolka.jestZabrana && stolik.czyJestBlisko(player))
                    {
                        stolik.fiolka.jestZabrana = false;
                        stolik.pictureBox.Image = stolik.fiolka.naStole;
                        stolik.podpis.Visible = true;
                        odtwarzajWav("pung");
                    }

                }
                String zebrane = "";
                foreach (Stolik stolik in stoliki)
                {
                    if (stolik.fiolka.jestZabrana)
                        zebrane = zebrane + " " + stolik.fiolka.substancja;
                }
                if (zebrane.Length > 0)
                {
                    labelZebrane.Text = "Składniki: " + zebrane;
                }
                else
                {
                    labelZebrane.Text = "";
                }

                if (player.Top < 200 && player.Left + 75 > 300 && player.Left + 75 < 620)
                {
                    sprawdzCoPrzynioslem();
                }
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (!moznaChodzic) return;

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
    }
}
