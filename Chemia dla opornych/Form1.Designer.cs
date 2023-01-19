namespace Chemia_dla_opornych
{
    partial class plansza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plansza));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelGorny = new System.Windows.Forms.Panel();
            this.labelZebrane = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelMisje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPunkty = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelPozycja = new System.Windows.Forms.Label();
            this.podpis1 = new System.Windows.Forms.Label();
            this.podpis2 = new System.Windows.Forms.Label();
            this.podpis3 = new System.Windows.Forms.Label();
            this.podpis5 = new System.Windows.Forms.Label();
            this.podpis4 = new System.Windows.Forms.Label();
            this.podpis6 = new System.Windows.Forms.Label();
            this.panelMisji = new System.Windows.Forms.Panel();
            this.textboxOpisMisji = new System.Windows.Forms.TextBox();
            this.labelMisja = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table6 = new System.Windows.Forms.PictureBox();
            this.table5 = new System.Windows.Forms.PictureBox();
            this.table4 = new System.Windows.Forms.PictureBox();
            this.table3 = new System.Windows.Forms.PictureBox();
            this.table2 = new System.Windows.Forms.PictureBox();
            this.table1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelGorny.SuspendLayout();
            this.panelMisji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvent);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.textBox1);
            this.panelMenu.Controls.Add(this.label7);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Location = new System.Drawing.Point(256, 408);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(468, 405);
            this.panelMenu.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(16, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(431, 188);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Zbierz potrzebne skladniki\r\ni zanieś je do laboratorium.\r\nZa każdą misję dostanie" +
    "sz punkty.\r\nNajwięcej punktów zdobędziesz\r\njeżeli nie popełnisz błędu.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(19, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 48);
            this.label7.TabIndex = 21;
            this.label7.Text = "Chemia dla opornych";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(142, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelGorny
            // 
            this.panelGorny.BackColor = System.Drawing.Color.Gray;
            this.panelGorny.Controls.Add(this.labelZebrane);
            this.panelGorny.Controls.Add(this.labelSuma);
            this.panelGorny.Controls.Add(this.labelMisje);
            this.panelGorny.Controls.Add(this.button1);
            this.panelGorny.Controls.Add(this.labelPunkty);
            this.panelGorny.Controls.Add(this.labelOpis);
            this.panelGorny.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGorny.Location = new System.Drawing.Point(0, 0);
            this.panelGorny.Name = "panelGorny";
            this.panelGorny.Size = new System.Drawing.Size(984, 133);
            this.panelGorny.TabIndex = 15;
            // 
            // labelZebrane
            // 
            this.labelZebrane.AutoSize = true;
            this.labelZebrane.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZebrane.Location = new System.Drawing.Point(12, 89);
            this.labelZebrane.Name = "labelZebrane";
            this.labelZebrane.Size = new System.Drawing.Size(21, 31);
            this.labelZebrane.TabIndex = 27;
            this.labelZebrane.Text = " ";
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuma.Location = new System.Drawing.Point(587, 49);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(28, 31);
            this.labelSuma.TabIndex = 27;
            this.labelSuma.Text = "  ";
            // 
            // labelMisje
            // 
            this.labelMisje.AutoSize = true;
            this.labelMisje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMisje.Location = new System.Drawing.Point(587, 9);
            this.labelMisje.Name = "labelMisje";
            this.labelMisje.Size = new System.Drawing.Size(28, 31);
            this.labelMisje.TabIndex = 27;
            this.labelMisje.Text = "  ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(931, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 62);
            this.button1.TabIndex = 18;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPunkty
            // 
            this.labelPunkty.AutoSize = true;
            this.labelPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPunkty.Location = new System.Drawing.Point(12, 49);
            this.labelPunkty.Name = "labelPunkty";
            this.labelPunkty.Size = new System.Drawing.Size(21, 31);
            this.labelPunkty.TabIndex = 16;
            this.labelPunkty.Text = " ";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(12, 9);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(21, 31);
            this.labelOpis.TabIndex = 14;
            this.labelOpis.Text = " ";
            // 
            // labelPozycja
            // 
            this.labelPozycja.AutoSize = true;
            this.labelPozycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPozycja.Location = new System.Drawing.Point(12, 213);
            this.labelPozycja.Name = "labelPozycja";
            this.labelPozycja.Size = new System.Drawing.Size(44, 31);
            this.labelPozycja.TabIndex = 12;
            this.labelPozycja.Text = "??";
            this.labelPozycja.Visible = false;
            // 
            // podpis1
            // 
            this.podpis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podpis1.Location = new System.Drawing.Point(14, 538);
            this.podpis1.Name = "podpis1";
            this.podpis1.Size = new System.Drawing.Size(240, 70);
            this.podpis1.TabIndex = 17;
            this.podpis1.Text = "Kwas siarkowodorowy";
            this.podpis1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.podpis1.Visible = false;
            // 
            // podpis2
            // 
            this.podpis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podpis2.Location = new System.Drawing.Point(730, 538);
            this.podpis2.Name = "podpis2";
            this.podpis2.Size = new System.Drawing.Size(240, 70);
            this.podpis2.TabIndex = 18;
            this.podpis2.Text = "Wodorotlenek Sodu";
            this.podpis2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.podpis2.Visible = false;
            // 
            // podpis3
            // 
            this.podpis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podpis3.Location = new System.Drawing.Point(14, 825);
            this.podpis3.Name = "podpis3";
            this.podpis3.Size = new System.Drawing.Size(240, 70);
            this.podpis3.TabIndex = 19;
            this.podpis3.Text = "??";
            this.podpis3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.podpis3.Visible = false;
            // 
            // podpis5
            // 
            this.podpis5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podpis5.Location = new System.Drawing.Point(14, 1110);
            this.podpis5.Name = "podpis5";
            this.podpis5.Size = new System.Drawing.Size(240, 70);
            this.podpis5.TabIndex = 20;
            this.podpis5.Text = "??";
            this.podpis5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.podpis5.Visible = false;
            // 
            // podpis4
            // 
            this.podpis4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podpis4.Location = new System.Drawing.Point(730, 826);
            this.podpis4.Name = "podpis4";
            this.podpis4.Size = new System.Drawing.Size(240, 70);
            this.podpis4.TabIndex = 21;
            this.podpis4.Text = "??";
            this.podpis4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.podpis4.Visible = false;
            // 
            // podpis6
            // 
            this.podpis6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podpis6.Location = new System.Drawing.Point(730, 1110);
            this.podpis6.Name = "podpis6";
            this.podpis6.Size = new System.Drawing.Size(240, 70);
            this.podpis6.TabIndex = 22;
            this.podpis6.Text = "Wodorotlenek Sodu";
            this.podpis6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.podpis6.Visible = false;
            // 
            // panelMisji
            // 
            this.panelMisji.BackColor = System.Drawing.Color.Gray;
            this.panelMisji.Controls.Add(this.textboxOpisMisji);
            this.panelMisji.Controls.Add(this.labelMisja);
            this.panelMisji.Controls.Add(this.button3);
            this.panelMisji.Location = new System.Drawing.Point(256, 408);
            this.panelMisji.Name = "panelMisji";
            this.panelMisji.Size = new System.Drawing.Size(468, 405);
            this.panelMisji.TabIndex = 25;
            this.panelMisji.Visible = false;
            // 
            // textboxOpisMisji
            // 
            this.textboxOpisMisji.BackColor = System.Drawing.Color.Gray;
            this.textboxOpisMisji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxOpisMisji.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textboxOpisMisji.Location = new System.Drawing.Point(16, 83);
            this.textboxOpisMisji.Multiline = true;
            this.textboxOpisMisji.Name = "textboxOpisMisji";
            this.textboxOpisMisji.ReadOnly = true;
            this.textboxOpisMisji.Size = new System.Drawing.Size(431, 188);
            this.textboxOpisMisji.TabIndex = 22;
            this.textboxOpisMisji.Text = "???";
            this.textboxOpisMisji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMisja
            // 
            this.labelMisja.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMisja.Location = new System.Drawing.Point(19, 16);
            this.labelMisja.Name = "labelMisja";
            this.labelMisja.Size = new System.Drawing.Size(428, 48);
            this.labelMisja.TabIndex = 21;
            this.labelMisja.Text = "??";
            this.labelMisja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(142, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 41);
            this.button3.TabIndex = 20;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chemia_dla_opornych.Properties.Resources.lab;
            this.pictureBox1.Location = new System.Drawing.Point(395, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // table6
            // 
            this.table6.Image = ((System.Drawing.Image)(resources.GetObject("table6.Image")));
            this.table6.Location = new System.Drawing.Point(742, 905);
            this.table6.Name = "table6";
            this.table6.Size = new System.Drawing.Size(150, 202);
            this.table6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table6.TabIndex = 13;
            this.table6.TabStop = false;
            this.table6.Visible = false;
            // 
            // table5
            // 
            this.table5.Image = ((System.Drawing.Image)(resources.GetObject("table5.Image")));
            this.table5.Location = new System.Drawing.Point(65, 905);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(150, 202);
            this.table5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table5.TabIndex = 12;
            this.table5.TabStop = false;
            this.table5.Visible = false;
            // 
            // table4
            // 
            this.table4.Image = ((System.Drawing.Image)(resources.GetObject("table4.Image")));
            this.table4.Location = new System.Drawing.Point(742, 621);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(150, 202);
            this.table4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table4.TabIndex = 6;
            this.table4.TabStop = false;
            this.table4.Visible = false;
            // 
            // table3
            // 
            this.table3.Image = ((System.Drawing.Image)(resources.GetObject("table3.Image")));
            this.table3.Location = new System.Drawing.Point(65, 621);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(150, 202);
            this.table3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table3.TabIndex = 5;
            this.table3.TabStop = false;
            this.table3.Visible = false;
            // 
            // table2
            // 
            this.table2.Image = ((System.Drawing.Image)(resources.GetObject("table2.Image")));
            this.table2.Location = new System.Drawing.Point(742, 333);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(150, 202);
            this.table2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table2.TabIndex = 4;
            this.table2.TabStop = false;
            this.table2.Visible = false;
            // 
            // table1
            // 
            this.table1.Image = ((System.Drawing.Image)(resources.GetObject("table1.Image")));
            this.table1.Location = new System.Drawing.Point(65, 333);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(150, 202);
            this.table1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table1.TabIndex = 2;
            this.table1.TabStop = false;
            this.table1.Visible = false;
            // 
            // player
            // 
            this.player.Image = global::Chemia_dla_opornych.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(395, 199);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(150, 150);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 28;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // plansza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 1180);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panelMisji);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPozycja);
            this.Controls.Add(this.podpis6);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.podpis4);
            this.Controls.Add(this.podpis5);
            this.Controls.Add(this.podpis3);
            this.Controls.Add(this.podpis2);
            this.Controls.Add(this.podpis1);
            this.Controls.Add(this.panelGorny);
            this.Controls.Add(this.table6);
            this.Controls.Add(this.table5);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.table1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "plansza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGorny.ResumeLayout(false);
            this.panelGorny.PerformLayout();
            this.panelMisji.ResumeLayout(false);
            this.panelMisji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox table1;
        private System.Windows.Forms.PictureBox table2;
        private System.Windows.Forms.PictureBox table3;
        private System.Windows.Forms.PictureBox table4;
        private System.Windows.Forms.PictureBox table5;
        private System.Windows.Forms.PictureBox table6;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGorny;
        private System.Windows.Forms.Label labelPunkty;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelPozycja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label podpis1;
        private System.Windows.Forms.Label podpis2;
        private System.Windows.Forms.Label podpis3;
        private System.Windows.Forms.Label podpis5;
        private System.Windows.Forms.Label podpis4;
        private System.Windows.Forms.Label podpis6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMisji;
        private System.Windows.Forms.TextBox textboxOpisMisji;
        private System.Windows.Forms.Label labelMisja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.Label labelMisje;
        private System.Windows.Forms.Label labelZebrane;
        private System.Windows.Forms.PictureBox player;
    }
}

