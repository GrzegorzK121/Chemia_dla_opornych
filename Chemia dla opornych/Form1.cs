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

        Stolik[] stoliki = new Stolik[4];

        public plansza()
        {
            InitializeComponent();

            stoliki[0] = new Stolik(table1, new Fiolka("Węgiel",
                Properties.Resources.blue, Properties.Resources.green, Properties.Resources.free));
            stoliki[1] = new Stolik(table2, new Fiolka("Tlen",
                Properties.Resources.green, Properties.Resources.red, Properties.Resources.free));
            stoliki[2] = new Stolik(table3, new Fiolka("Żelazo",
                Properties.Resources.blue, Properties.Resources.green, Properties.Resources.free));
            stoliki[3] = new Stolik(table4, new Fiolka("Argon",
                Properties.Resources.red, Properties.Resources.blue, Properties.Resources.free));

            foreach(Stolik stolik in stoliki)
            {
                stolik.pokazStolik();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void table2_Click(object sender, EventArgs e)
        {
       
        }

        private void MainTimeEvent(object sender, EventArgs e)
        {
            int newLeft, newTop;
            newLeft = player.Left;
            newTop = player.Top;
            

            if (goLeft && player.Left > 0 )
            {
                //player.Left -= speed;
                newLeft = player.Left - speed;
            }
            if (goRight && player.Left + player.Width < this.ClientSize.Width )
            {
                //player.Left += speed;
                newLeft = player.Left + speed;
            }
            if (goUp && player.Top > 45 )
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
                if (player.Top<50)
                {
                    if (stoliki[0].fiolka.jestZabrana && !stoliki[1].fiolka.jestZabrana &&
                        !stoliki[2].fiolka.jestZabrana && stoliki[3].fiolka.jestZabrana)
                    {
                        label2.Text = "!!!!";
                    }
                    else
                    {
                        label2.Text = "------";
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
