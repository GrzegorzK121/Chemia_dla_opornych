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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.table1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.table2 = new System.Windows.Forms.PictureBox();
            this.table3 = new System.Windows.Forms.PictureBox();
            this.table4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvent);
            // 
            // table1
            // 
            this.table1.Image = global::Chemia_dla_opornych.Properties.Resources.red;
            this.table1.Location = new System.Drawing.Point(69, 394);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(150, 202);
            this.table1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table1.TabIndex = 2;
            this.table1.TabStop = false;
            this.table1.Visible = false;
            this.table1.Click += new System.EventHandler(this.table2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "??";
            // 
            // player
            // 
            this.player.Image = global::Chemia_dla_opornych.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(395, 454);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(150, 81);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // table2
            // 
            this.table2.Image = global::Chemia_dla_opornych.Properties.Resources.red;
            this.table2.Location = new System.Drawing.Point(746, 406);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(150, 202);
            this.table2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table2.TabIndex = 4;
            this.table2.TabStop = false;
            this.table2.Visible = false;
            // 
            // table3
            // 
            this.table3.Image = global::Chemia_dla_opornych.Properties.Resources.red;
            this.table3.Location = new System.Drawing.Point(69, 704);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(150, 202);
            this.table3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table3.TabIndex = 5;
            this.table3.TabStop = false;
            this.table3.Visible = false;
            // 
            // table4
            // 
            this.table4.Image = global::Chemia_dla_opornych.Properties.Resources.red;
            this.table4.Location = new System.Drawing.Point(746, 704);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(150, 202);
            this.table4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.table4.TabIndex = 6;
            this.table4.TabStop = false;
            this.table4.Visible = false;
            this.table4.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(292, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "??";
            // 
            // plansza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.label1);
            this.Name = "plansza";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox table1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox table2;
        private System.Windows.Forms.PictureBox table3;
        private System.Windows.Forms.PictureBox table4;
        private System.Windows.Forms.Label label2;
    }
}

