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
    /// <summary>
    /// Klasa reprezentująca okno programu
    /// </summary>
    public partial class plansza : Form
    {
        bool goLeft, goRight, goUp, goDown;

        /// <summary>
        /// Szybkość poruszania się gracza, dobrana eksperymentalnie:
        /// 7 pikseli co 10 ms
        /// </summary>
        int speed = 7;

        /// <summary>
        /// Licznik czasu, używany do odejmowania punktów za misję
        /// </summary>
        int czas = 0;

        /// <summary>
        /// Tablica zawierająca dane misji, które ma wykonać gracz
        /// </summary>
        Misja[] misje;

        /// <summary>
        /// Decyduje o tym czy gracz może poruszać się w polu gry
        /// </summary>
        bool moznaChodzic = false;

        /// <summary>
        /// Numer aktualnie wykonywanej misji
        /// </summary>
        int numerMisji = 0;

        /// <summary>
        /// Liczba punktów zdobytych przez gracza
        /// </summary>
        int punkty = 0;

        /// <summary>
        /// Liczba misji do wykonania
        /// </summary>
        int liczbaMisji;

        /// <summary>
        /// Numer aktualnie wykonywanej misji
        /// </summary>
        Misja obecnaMisja;

        /// <summary>
        /// Tablica obiektów klasy Stolik, reprezentujących stoliki 
        /// z substancjami chemicznymi, które zbiera gracz
        /// </summary>
        Stolik[] stoliki;

        /// <summary>
        /// Konstruktor tworzy tablicę misji oraz nadaje wartość początkową 
        /// potrzebnych zmiennych, jak liczba misji i numer misji.
        /// Na koniec wyświetla panel menu
        /// </summary>
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
                ),

                new Misja(
                    "Zbierz składniki do zrobienia kwasu siarkowego, wzór H2SO4",
                    "Kwas siarkowy, H2SO4",
                    150,
                    new Stolik[] {
                    new Stolik(table1, podpis1, new Fiolka("Siarka",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Wodór",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Fosfor",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table5, podpis5, new Fiolka("Węgiel",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free)),
                    new Stolik(table4, podpis4, new Fiolka("Tlen",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table6, podpis6, new Fiolka("Bar",
                        Properties.Resources.elipseBlue, Properties.Resources.elipseBlueChoose, Properties.Resources.free))
                    },
                    new bool[] { true, true, false, false, true, false }
                ),

                new Misja(
                    "Zbierz składniki do zrobienia propanu, wzór C3H8",
                    "Propan, C3H8",
                    100,
                    new Stolik[] {
                    new Stolik(table6, podpis6, new Fiolka("Bar",
                        Properties.Resources.elipseBlue, Properties.Resources.elipseBlueChoose, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Fosfor",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table5, podpis5, new Fiolka("Arsen",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free)),
                    new Stolik(table4, podpis4, new Fiolka("Tlen",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table1, podpis1, new Fiolka("Węgiel",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Wodór",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    },
                    new bool[] { false, false, false, false, true, true }
                ),


                new Misja(
                    "Zbierz składniki do zrobienia kolejnej siarczku sodu, wzór Na2S",
                    "Siarczek sodu, Na2S",
                    100,
                    new Stolik[] {
                    new Stolik(table1, podpis1, new Fiolka("Potas",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Sód",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Fosfor",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table4, podpis4, new Fiolka("Tlen",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table5, podpis5, new Fiolka("Siarka",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free)),
                    new Stolik(table6, podpis6, new Fiolka("Bar",
                        Properties.Resources.elipseBlue, Properties.Resources.elipseBlueChoose, Properties.Resources.free))
                    },
                    new bool[] { false, true, false, false, true, false }
                ),

                new Misja(
                    "Zbierz składniki do zrobienia kolejnej nadmanganianu potasu, wzór KMnO4",
                    "Nadmanganian potasu, KMnO4",
                    150,
                    new Stolik[] {
                    new Stolik(table4, podpis4, new Fiolka("Tlen",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table5, podpis5, new Fiolka("Siarka",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free)),
                    new Stolik(table6, podpis6, new Fiolka("Mangan",
                        Properties.Resources.elipseBlue, Properties.Resources.elipseBlueChoose, Properties.Resources.free)),
                    new Stolik(table1, podpis1, new Fiolka("Krzem",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Sód",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Potas",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    },
                    new bool[] { true, false, true, false, false, true }
                ),

                new Misja(
                    "Zbierz składniki do zrobienia kefeiny, wzór C8H10N4O2",
                    "Kofeina, C8H10N4O2",
                    200,
                    new Stolik[] {
                    new Stolik(table5, podpis5, new Fiolka("Węgiel",
                        Properties.Resources.empty, Properties.Resources.empty, Properties.Resources.free)),
                    new Stolik(table3, podpis3, new Fiolka("Fosfor",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table4, podpis4, new Fiolka("Tlen",
                        Properties.Resources.red, Properties.Resources.redChoose, Properties.Resources.free)),
                    new Stolik(table1, podpis1, new Fiolka("Arsen",
                        Properties.Resources.blue, Properties.Resources.blueChoose, Properties.Resources.free)),
                    new Stolik(table6, podpis6, new Fiolka("Azot",
                        Properties.Resources.elipseBlue, Properties.Resources.elipseBlueChoose, Properties.Resources.free)),
                    new Stolik(table2, podpis2, new Fiolka("Wodór",
                        Properties.Resources.elipseGreen, Properties.Resources.elipseGreenChoose, Properties.Resources.free)),
                    },
                    new bool[] { true, false, true, false, true, true }
                ),

            };
            liczbaMisji = misje.Count();

            obecnaMisja = misje[0];
            stoliki = obecnaMisja.stoliki;
            obecnaMisja.zacznijMisje();

            panelMenu.Visible = true;

        }

        /// <summary>
        /// Odtwarza dźwięk na podstawie jego nazwy.
        /// Wykorzystuje klasę SoundPlayer
        /// </summary>
        /// <param name="co">Nazwa dźwięku, który ma być odtworzony</param>
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

        /// <summary>
        /// Sprawdza, co gracz zebrał ze stolików i decyduje o zakończeniu misji.
        /// Jeżeli gracz nic nie zebrał, to tylko odtwarza dźwięk "cooo".
        /// Jeżeli gracz zebrał niewłaściwe substancje, to odtwarza dźwięk "cooo",
        /// odbiera 10 punktów, resetuje stoliki, wstrzymuje ruch gracza i wyświetla 
        /// komunikat o błędzie. Kiedy gracz kliknie "OK", zaczyna misję od nowa.
        /// Jeżeli gracz zebrał właściwe substancje, dodaje punkty za misję,
        /// wyświetla informacje o liczbie zdobytych punktów i liczbie skończonych misji.
        /// Następnie wczytuje nową misję, wyświetla liczbę punktów do zdobycia
        /// oraz opis misji i wstrzymuje ruch gracza. 
        /// Jeżeli ukończona misja jest ostatnią misją, to wyświetla napis "Koniec gry"
        /// </summary>
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
                button3.Focus();

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
                button3.Focus();
            }

        }

        /// <summary>
        /// Funkcja obsługi zdarzenia - kliknięcia w przycisk "X". 
        /// Zamyka program.
        /// </summary>
        /// <param name="sender">Parametr dodany przez Visual Studio</param>
        /// <param name="e">Parametr dodany przez Visual Studio</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Funkcja obsługi zdarzenia - kliknięcia w przycisk "Start" panelu powitalnego. 
        /// Wczytuje i wyświetla dane pierwszej misji, wyświetla stoliki przy pomocy funkcji zacznijMisje(),
        /// następnie wyświetla panel opisu misji
        /// </summary>
        /// <param name="sender">Parametr dodany przez Visual Studio</param>
        /// <param name="e">Parametr dodany przez Visual Studio</param>
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
            button3.Focus();
        }

        /// <summary>
        /// Funkcja obsługi zdarzenia - kliknięcia w przycisk "Start" panelu opisu misji. 
        /// Ukrywa panel opisu misji, wyświetla gracza i włącza ruch gracza
        /// </summary>
        /// <param name="sender">Parametr dodany przez Visual Studio</param>
        /// <param name="e">Parametr dodany przez Visual Studio</param>
        private void button3_Click(object sender, EventArgs e)
        {
            panelMisji.Visible = false;
            moznaChodzic = true;
            player.Visible = true;
        }

        /// <summary>
        /// Funkcja obsługi zdarzenia Tick timera gry, wykonywana co 10 ms.
        /// Jeżeli ruch gracza jest wyłączony zmienną moznaChodzic, to nic nie robi
        /// Co 100 zdarzeń, czyli co 1 sekundę, odbiera 1 punkt do zdobycia za misję.
        /// Następnie oblicza nową pozycję gracza, co wynika z tego czy wciśnięte są
        /// klawisze strzałek. Dla każdego stolika wyświetla lub ukrywa informację 
        /// o tym co jest na stoliku za pomocą funkcji coJestNaStoliku().
        /// Następnie sprawdza dla każdego stolika, czy gracz nie wchodzi na stolik
        /// przy pomocy funkcji czyWlazlNaStolik() i jeżeli nie, to przesuwa gracza 
        /// na planszy
        /// </summary>
        /// <param name="sender">Parametr dodany przez Visual Studio</param>
        /// <param name="e">Parametr dodany przez Visual Studio</param>
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

        /// <summary>
        /// Funkcja obsługi zdarzenia wciśnięcia klawisza.
        /// Jeżeli ruch gracza jest wyłączony zmienną moznaChodzic, to nic nie robi.
        /// Jeżeli zostanie naciśnięty klawisz strzałki, to zapisuje to w zmiennej 
        /// i wtedy podczas zdarzenia Tick timera gracz się porusza.
        /// Jeżeli wciśnięta jest spacja, to wykonuje kilka czynności.
        /// Najpierw sprawdza dla każdego stolika czy fiolka ze stolika jest zabrana
        /// i czy gracz jest w pobliżu, funkcją czyJestBlisko. Jeżeli tak, 
        /// to gracz zabiera albo odkłada fiolkę. Dodatkowo jest odtwarzany dźwięk.
        /// Jeżeli fiolka na stoliku jest pusta, to jest odtwarzany inny dźwięk.
        /// Następnie wyświetla informaję o tym jakie substancje gracz zebrał.
        /// Jeżeli gracz jest u góry planszy, to wywołuje funkcję sprawdzCoPrzynioslem()        
        /// </summary>
        /// <param name="sender">Parametr dodany przez Visual Studio</param>
        /// <param name="e">Parametr dodany przez Visual Studio</param>
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
                e.Handled = true;
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

        /// <summary>
        /// Funkcja obsługi zdarzenia zwolnienia klawisza.
        /// Jeżeli ruch gracza jest wyłączony zmienną moznaChodzic, to nic nie robi.
        /// Jeżeli zostanie zwolniony klawisz strzałki, to zapisuje to w zmiennej 
        /// i wtedy podczas zdarzenia Tick timera gracz się nie porusza.
        /// </summary>
        /// <param name="sender">Parametr dodany przez Visual Studio</param>
        /// <param name="e">Parametr dodany przez Visual Studio</param>
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
