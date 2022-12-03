using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemia_dla_opornych
{
    public partial class plansza : Form
    {

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int speed = 10;

        Misja[] misje;

        //Gra
        int numerMisji = 0;
        int punkty = 0;
        Misja obecnaMisja;
        Stolik[] stoliki;

        public plansza()
        {
            InitializeComponent();

            misje = new Misja[] {
                new Misja(
                    "Zbierz składniki do zrobienia wody, wzór H2O",
                    "Brawo, woda zrobiona, dostajesz 100 punktów",
                    100,
                    new Stolik[] {
                    new Stolik(table1, new Fiolka("Węgiel",
                        Properties.Resources.blue, Properties.Resources.green, Properties.Resources.free)),
                    new Stolik(table2, new Fiolka("Tlen",
                        Properties.Resources.green, Properties.Resources.red, Properties.Resources.free)),
                    new Stolik(table3, new Fiolka("Żelazo",
                        Properties.Resources.blue, Properties.Resources.green, Properties.Resources.free)),
                    new Stolik(table4, new Fiolka("Wodór",
                        Properties.Resources.red, Properties.Resources.blue, Properties.Resources.free))
                    },
                    new bool[] { false, true, false, true }
                ),

                new Misja(
                    "Zbierz składniki do zrobienia soli, wzór NaCl",
                    "Brawo, woda zrobiona, dostajesz 100 punktów",
                    100,
                    new Stolik[] {
                    new Stolik(table1, new Fiolka("Sód",
                        Properties.Resources.blue, Properties.Resources.green, Properties.Resources.free)),
                    new Stolik(table2, new Fiolka("Tlen",
                        Properties.Resources.green, Properties.Resources.red, Properties.Resources.free)),
                    new Stolik(table3, new Fiolka("Żelazo",
                        Properties.Resources.blue, Properties.Resources.green, Properties.Resources.free)),
                    new Stolik(table4, new Fiolka("Chlor",
                        Properties.Resources.red, Properties.Resources.blue, Properties.Resources.free))
                    },
                    new bool[] { true, false, false, true }
                )
            };

            obecnaMisja = misje[numerMisji];
            label3.Text = obecnaMisja.opisMisji;
            stoliki = obecnaMisja.stoliki;
            obecnaMisja.zacznijMisje();
            label5.Text = String.Format("Punkty {0}", punkty);
            label6.Text = "";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text != "Dalej...")
                return;

            if (misje.Count() >= numerMisji + 2)
            {
                label6.Text = "";
                numerMisji++;

                obecnaMisja = misje[numerMisji];
                label3.Text = obecnaMisja.opisMisji;
                stoliki = obecnaMisja.stoliki;
                obecnaMisja.zacznijMisje();
                label5.Text = String.Format("Punkty {0}", punkty);
                label6.Text = "";
            }
        }

        private void table2_Click(object sender, EventArgs e)
        {

        }

        private void MainTimeEvent(object sender, EventArgs e)
        {
            int newLeft, newTop;
            newLeft = player.Left;
            newTop = player.Top;


            if (goLeft && player.Left > 0)
            {
                //player.Left -= speed;
                newLeft = player.Left - speed;
            }
            if (goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                //player.Left += speed;
                newLeft = player.Left + speed;
            }
            if (goUp && player.Top > 45)
            {
                //player.Top -= speed;
                newTop = player.Top - speed;
            }
            if (goDown && player.Top + player.Height < this.ClientSize.Height)
            {
                //player.Top += speed;
                newTop = player.Top + speed;
            }


            foreach (Stolik stolik in stoliki)
            {
                stolik.AktualizujPozycje(player);
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

                String opis = "";
                foreach (Stolik stolik in stoliki)
                {
                    if (!stolik.fiolka.jestZabrana && stolik.czyJestBlisko(player))
                    {
                        opis = stolik.fiolka.substancja;
                    }
                }
                label4.Text = opis;

            }

            label1.Text = String.Format("l: {0}, t: {1} {2}", player.Left, player.Top, wlazlNaStolik);

        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.Space)
            {
                // zabranie fiolki
                foreach (Stolik stolik in stoliki)
                {
                    if (!stolik.fiolka.jestZabrana && stolik.czyJestBlisko(player))
                    {
                        stolik.fiolka.jestZabrana = true;
                        stolik.pictureBox.Image = stolik.fiolka.zabrana;
                    }
                    else if (stolik.fiolka.jestZabrana && stolik.czyJestBlisko(player))
                    {
                        stolik.fiolka.jestZabrana = false;
                        stolik.pictureBox.Image = stolik.fiolka.naStole;
                    }

                }

                // ukończenie poziomu
                if (player.Top < 50)
                {
                    bool ok = true;
                    for (int st = 0; st < stoliki.Count(); st++)
                    {
                        if (stoliki[st].fiolka.jestZabrana != obecnaMisja.maZebrac[st])
                            ok = false;
                    }

                    if (ok)
                    {
                        label3.Text = obecnaMisja.napisKońcowy;
                        punkty += obecnaMisja.punkty;
                        label5.Text = String.Format("Punkty {0}", punkty);
                        label6.Text = "Dalej...";
                    }
                    else
                    {
                        label3.Text = "ŹLE! Zacznij od nowa!";
                        foreach (Stolik stolik in stoliki)
                            stolik.resetujStolik();
                    }
                }
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

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
            if (e.KeyCode == Keys.Space)
            {
                //table2.Image = Properties.Resources.red;
            }

            //((PictureBox)x).Image = Properties.Resources.zleft;


        }
    }
}
