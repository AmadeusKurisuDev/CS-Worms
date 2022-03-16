namespace Worms2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerPlayer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.timerPlayer2 = new System.Windows.Forms.Timer(this.components);
            this.baule = new System.Windows.Forms.PictureBox();
            this.timerAnimazioni = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.arma1label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ammunition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vita1 = new System.Windows.Forms.Panel();
            this.alpha1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arma2label = new System.Windows.Forms.Label();
            this.ammunition2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vita2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alpha2 = new System.Windows.Forms.Label();
            this.Nave1 = new System.Windows.Forms.PictureBox();
            this.ballPlacement = new System.Windows.Forms.Panel();
            this.Nave2 = new System.Windows.Forms.PictureBox();
            this.baulePlacement = new System.Windows.Forms.Panel();
            this.boom = new System.Windows.Forms.PictureBox();
            this.nuvola = new System.Windows.Forms.PictureBox();
            this.nuvolePlacement = new System.Windows.Forms.Panel();
            this.nuvola2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Nave1Placement = new System.Windows.Forms.Panel();
            this.Nave2Placement = new System.Windows.Forms.Panel();
            this.kraken = new System.Windows.Forms.PictureBox();
            this.KrakenPlacement = new System.Windows.Forms.Panel();
            this.turnoV1 = new System.Windows.Forms.Panel();
            this.turnoV2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baule)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nave1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvola2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraken)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPlayer1
            // 
            this.timerPlayer1.Interval = 1;
            this.timerPlayer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(12, 535);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            this.ball.Visible = false;
            // 
            // timerPlayer2
            // 
            this.timerPlayer2.Interval = 1;
            this.timerPlayer2.Tick += new System.EventHandler(this.timerPlayer2_Tick);
            // 
            // baule
            // 
            this.baule.BackColor = System.Drawing.Color.Transparent;
            this.baule.Image = ((System.Drawing.Image)(resources.GetObject("baule.Image")));
            this.baule.Location = new System.Drawing.Point(578, 427);
            this.baule.Name = "baule";
            this.baule.Size = new System.Drawing.Size(140, 99);
            this.baule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baule.TabIndex = 9;
            this.baule.TabStop = false;
            // 
            // timerAnimazioni
            // 
            this.timerAnimazioni.Interval = 1;
            this.timerAnimazioni.Tick += new System.EventHandler(this.timerAnimazioni_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.turnoV1);
            this.panel1.Controls.Add(this.arma1label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ammunition);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.vita1);
            this.panel1.Controls.Add(this.alpha1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 63);
            this.panel1.TabIndex = 10;
            // 
            // arma1label
            // 
            this.arma1label.AutoSize = true;
            this.arma1label.BackColor = System.Drawing.Color.Transparent;
            this.arma1label.ForeColor = System.Drawing.Color.White;
            this.arma1label.Location = new System.Drawing.Point(246, 39);
            this.arma1label.Name = "arma1label";
            this.arma1label.Size = new System.Drawing.Size(49, 13);
            this.arma1label.TabIndex = 20;
            this.arma1label.Text = "cannone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "arma:";
            // 
            // ammunition
            // 
            this.ammunition.AutoSize = true;
            this.ammunition.ForeColor = System.Drawing.Color.White;
            this.ammunition.Location = new System.Drawing.Point(188, 39);
            this.ammunition.Name = "ammunition";
            this.ammunition.Size = new System.Drawing.Size(13, 13);
            this.ammunition.TabIndex = 15;
            this.ammunition.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(137, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "munizioni:";
            // 
            // vita1
            // 
            this.vita1.BackColor = System.Drawing.Color.Green;
            this.vita1.Location = new System.Drawing.Point(95, 13);
            this.vita1.Name = "vita1";
            this.vita1.Size = new System.Drawing.Size(266, 23);
            this.vita1.TabIndex = 13;
            // 
            // alpha1
            // 
            this.alpha1.AutoSize = true;
            this.alpha1.ForeColor = System.Drawing.Color.White;
            this.alpha1.Location = new System.Drawing.Point(92, 39);
            this.alpha1.Name = "alpha1";
            this.alpha1.Size = new System.Drawing.Size(39, 13);
            this.alpha1.TabIndex = 4;
            this.alpha1.Text = "alpha1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inclinazione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.turnoV2);
            this.panel2.Controls.Add(this.arma2label);
            this.panel2.Controls.Add(this.ammunition2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.vita2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.alpha2);
            this.panel2.Location = new System.Drawing.Point(809, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 63);
            this.panel2.TabIndex = 11;
            // 
            // arma2label
            // 
            this.arma2label.AutoSize = true;
            this.arma2label.BackColor = System.Drawing.Color.Transparent;
            this.arma2label.ForeColor = System.Drawing.Color.White;
            this.arma2label.Location = new System.Drawing.Point(204, 39);
            this.arma2label.Name = "arma2label";
            this.arma2label.Size = new System.Drawing.Size(49, 13);
            this.arma2label.TabIndex = 22;
            this.arma2label.Text = "cannone";
            // 
            // ammunition2
            // 
            this.ammunition2.AutoSize = true;
            this.ammunition2.ForeColor = System.Drawing.Color.White;
            this.ammunition2.Location = new System.Drawing.Point(311, 39);
            this.ammunition2.Name = "ammunition2";
            this.ammunition2.Size = new System.Drawing.Size(13, 13);
            this.ammunition2.TabIndex = 17;
            this.ammunition2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(165, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "arma:";
            // 
            // vita2
            // 
            this.vita2.BackColor = System.Drawing.Color.Green;
            this.vita2.Location = new System.Drawing.Point(116, 13);
            this.vita2.Name = "vita2";
            this.vita2.Size = new System.Drawing.Size(266, 23);
            this.vita2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(260, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "munizioni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(350, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inclinazione:";
            // 
            // alpha2
            // 
            this.alpha2.AutoSize = true;
            this.alpha2.ForeColor = System.Drawing.Color.White;
            this.alpha2.Location = new System.Drawing.Point(422, 39);
            this.alpha2.Name = "alpha2";
            this.alpha2.Size = new System.Drawing.Size(39, 13);
            this.alpha2.TabIndex = 5;
            this.alpha2.Text = "alpha2";
            // 
            // Nave1
            // 
            this.Nave1.BackColor = System.Drawing.Color.Transparent;
            this.Nave1.Image = ((System.Drawing.Image)(resources.GetObject("Nave1.Image")));
            this.Nave1.Location = new System.Drawing.Point(12, 274);
            this.Nave1.Name = "Nave1";
            this.Nave1.Size = new System.Drawing.Size(259, 176);
            this.Nave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nave1.TabIndex = 12;
            this.Nave1.TabStop = false;
            // 
            // ballPlacement
            // 
            this.ballPlacement.Location = new System.Drawing.Point(74, 538);
            this.ballPlacement.Name = "ballPlacement";
            this.ballPlacement.Size = new System.Drawing.Size(24, 23);
            this.ballPlacement.TabIndex = 13;
            this.ballPlacement.Visible = false;
            // 
            // Nave2
            // 
            this.Nave2.BackColor = System.Drawing.Color.Transparent;
            this.Nave2.Image = ((System.Drawing.Image)(resources.GetObject("Nave2.Image")));
            this.Nave2.Location = new System.Drawing.Point(1033, 274);
            this.Nave2.Name = "Nave2";
            this.Nave2.Size = new System.Drawing.Size(259, 176);
            this.Nave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nave2.TabIndex = 14;
            this.Nave2.TabStop = false;
            // 
            // baulePlacement
            // 
            this.baulePlacement.Location = new System.Drawing.Point(578, 407);
            this.baulePlacement.Name = "baulePlacement";
            this.baulePlacement.Size = new System.Drawing.Size(24, 23);
            this.baulePlacement.TabIndex = 14;
            this.baulePlacement.Visible = false;
            // 
            // boom
            // 
            this.boom.BackColor = System.Drawing.Color.Transparent;
            this.boom.Image = ((System.Drawing.Image)(resources.GetObject("boom.Image")));
            this.boom.Location = new System.Drawing.Point(12, 81);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(93, 64);
            this.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boom.TabIndex = 15;
            this.boom.TabStop = false;
            this.boom.Visible = false;
            // 
            // nuvola
            // 
            this.nuvola.BackColor = System.Drawing.Color.Transparent;
            this.nuvola.Image = ((System.Drawing.Image)(resources.GetObject("nuvola.Image")));
            this.nuvola.Location = new System.Drawing.Point(1255, 96);
            this.nuvola.Name = "nuvola";
            this.nuvola.Size = new System.Drawing.Size(194, 94);
            this.nuvola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuvola.TabIndex = 16;
            this.nuvola.TabStop = false;
            // 
            // nuvolePlacement
            // 
            this.nuvolePlacement.Location = new System.Drawing.Point(1255, 165);
            this.nuvolePlacement.Name = "nuvolePlacement";
            this.nuvolePlacement.Size = new System.Drawing.Size(27, 25);
            this.nuvolePlacement.TabIndex = 17;
            this.nuvolePlacement.Visible = false;
            // 
            // nuvola2
            // 
            this.nuvola2.BackColor = System.Drawing.Color.Transparent;
            this.nuvola2.Image = ((System.Drawing.Image)(resources.GetObject("nuvola2.Image")));
            this.nuvola2.Location = new System.Drawing.Point(1255, 127);
            this.nuvola2.Name = "nuvola2";
            this.nuvola2.Size = new System.Drawing.Size(151, 63);
            this.nuvola2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuvola2.TabIndex = 18;
            this.nuvola2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nave1Placement
            // 
            this.Nave1Placement.Location = new System.Drawing.Point(12, 250);
            this.Nave1Placement.Name = "Nave1Placement";
            this.Nave1Placement.Size = new System.Drawing.Size(21, 25);
            this.Nave1Placement.TabIndex = 20;
            this.Nave1Placement.Visible = false;
            // 
            // Nave2Placement
            // 
            this.Nave2Placement.Location = new System.Drawing.Point(1033, 250);
            this.Nave2Placement.Name = "Nave2Placement";
            this.Nave2Placement.Size = new System.Drawing.Size(21, 25);
            this.Nave2Placement.TabIndex = 21;
            this.Nave2Placement.Visible = false;
            // 
            // kraken
            // 
            this.kraken.BackColor = System.Drawing.Color.Transparent;
            this.kraken.Image = ((System.Drawing.Image)(resources.GetObject("kraken.Image")));
            this.kraken.Location = new System.Drawing.Point(516, 538);
            this.kraken.Name = "kraken";
            this.kraken.Size = new System.Drawing.Size(266, 382);
            this.kraken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kraken.TabIndex = 22;
            this.kraken.TabStop = false;
            // 
            // KrakenPlacement
            // 
            this.KrakenPlacement.Location = new System.Drawing.Point(516, 538);
            this.KrakenPlacement.Name = "KrakenPlacement";
            this.KrakenPlacement.Size = new System.Drawing.Size(28, 23);
            this.KrakenPlacement.TabIndex = 23;
            this.KrakenPlacement.Visible = false;
            // 
            // turnoV1
            // 
            this.turnoV1.BackColor = System.Drawing.Color.LawnGreen;
            this.turnoV1.Location = new System.Drawing.Point(420, 9);
            this.turnoV1.Name = "turnoV1";
            this.turnoV1.Size = new System.Drawing.Size(49, 47);
            this.turnoV1.TabIndex = 24;
            // 
            // turnoV2
            // 
            this.turnoV2.BackColor = System.Drawing.Color.LawnGreen;
            this.turnoV2.Location = new System.Drawing.Point(16, 9);
            this.turnoV2.Name = "turnoV2";
            this.turnoV2.Size = new System.Drawing.Size(49, 47);
            this.turnoV2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 573);
            this.Controls.Add(this.KrakenPlacement);
            this.Controls.Add(this.kraken);
            this.Controls.Add(this.Nave2Placement);
            this.Controls.Add(this.Nave1Placement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nuvola2);
            this.Controls.Add(this.nuvolePlacement);
            this.Controls.Add(this.nuvola);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.baulePlacement);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Nave2);
            this.Controls.Add(this.ballPlacement);
            this.Controls.Add(this.Nave1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Battaglia Pirata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nave1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvola2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerPlayer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timerPlayer2;
        private System.Windows.Forms.PictureBox baule;
        private System.Windows.Forms.Timer timerAnimazioni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Nave1;
        private System.Windows.Forms.Label alpha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alpha2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel vita1;
        private System.Windows.Forms.Panel vita2;
        private System.Windows.Forms.Panel ballPlacement;
        private System.Windows.Forms.PictureBox Nave2;
        private System.Windows.Forms.Label ammunition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ammunition2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel baulePlacement;
        private System.Windows.Forms.PictureBox boom;
        private System.Windows.Forms.PictureBox nuvola;
        private System.Windows.Forms.Panel nuvolePlacement;
        private System.Windows.Forms.PictureBox nuvola2;
        private System.Windows.Forms.Label arma1label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label arma2label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Nave1Placement;
        private System.Windows.Forms.Panel Nave2Placement;
        private System.Windows.Forms.PictureBox kraken;
        private System.Windows.Forms.Panel KrakenPlacement;
        private System.Windows.Forms.Panel turnoV1;
        private System.Windows.Forms.Panel turnoV2;
    }
}

