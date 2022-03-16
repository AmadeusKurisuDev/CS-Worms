using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Imaging;
using System.IO;

namespace Worms2._0
{
    public partial class Form1 : Form
    {
        public bool colpisci;
        public int VelocitaIniziale;
        public int Ay;
        public int Vx;
        public int Vy;
        public double alpha;
        public int vento_Vx;
        public int turno;
        public int punti1;
        public int punti2;
        public bool messaggio;
        public int munizioni1;
        public int munizioni2;
        public int contaMosse;
        public int randomBaule;
        public int mossePerBaule;
        public int naveCheHaPerso;
        public int i;
        public bool maltempo;
        public string nemico;
        public int rmal;
        public int rotazioneNave;
        public string arma1;
        public string arma2;
        public int turnoMomentaneo;
        public int visualAlpha;
        public int turnoMaltempo;
        public bool possibilitaSparo;



        public Form1()
        {
            InitializeComponent();
            VelocitaIniziale = 40;
            Ay = -1;
            vento_Vx = 0;
            alpha = 5;
            visualAlpha = 0;
            turno = 0;
            i = 100;
            possibilitaSparo = true;
            nuvola.Visible = false;
            contaMosse = 0;
            randomBaule = 0;
            mossePerBaule = 0;
            arma1 = "cannone";
            arma2 = "cannone";
            colpisci = false;
            messaggio = false;
            //maltempo = false;
            rotazioneNave = 0;
            munizioni1 = 5;
            munizioni2 = 5;
            naveCheHaPerso = 0;
            ammunition.Text = munizioni1.ToString();
            ammunition2.Text = munizioni2.ToString();
            alpha1.Text = alpha.ToString();
            alpha2.Text = alpha.ToString();
            //nemico = "null";
            //timerPlayer2.Start();
            punti1 = 260;
            punti2 = 260;
            turnoMaltempo = 0;
            vita1.Width = punti1;
            vita2.Width = punti2;
            button1.Visible = false;
            button1.Enabled = false;
            turnoV1.Visible = false;
            turnoV2.Visible = false;

        }
        Random rnd = new Random();
        SoundPlayer esplosione = new SoundPlayer(@"explosion.wav");
        SoundPlayer soldi = new SoundPlayer(@"money.wav");
        //-------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------



        public string TestoArma1
        {
            get { return arma1; }
            set { arma1 = value; }
        }

        public string TestoArma2
        {
            get { return arma2; }
            set { arma2 = value; }
        }

        public int TestoTurno
        {
            get { return turno; }
            set { turnoMomentaneo = value; }
        }

        public int TestoPunti1
        {
            get { return punti1; }
            set { punti1 = value; }
        }

        public int TestoPunti2
        {
            get { return punti2; }
            set { punti2 = value; }
        }

        public double TestoAlpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public int TestoForza
        {
            get { return VelocitaIniziale; }
            set { VelocitaIniziale = value; }
        }

        public int TestoMunizioniUno
        {
            get { return munizioni1; }
            set { munizioni1 = value; }
        }

        public int TestoMunizioniDue
        {
            get { return munizioni2; }
            set { munizioni2 = value; }
        }


        //-------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            timerPlayer2.Start();
            mossePerBaule = rnd.Next(1, 5);
            turno = rnd.Next(0, 2);
            if(turno == 0)
            {
                turnoV1.Visible = true;
                turnoV2.Visible = false;
            }
            else
            {
                turnoV1.Visible = false;
                turnoV2.Visible = true;
            }
            rmal=rnd.Next(0, 2);
            if (rmal == 0)
            {
                maltempo = false;
                nemico = "null";
                nuvola.Visible = false;
                Eventi();
            }
            else if(rmal == 1)
            {
                maltempo = true;
                nemico = "kraken";
                nuvola.Visible = true;
                Eventi();
            }
            else
            {
                maltempo = true;
                nemico = "null";
                nuvola.Visible = false;
                timerPlayer2.Stop();
            }
            if (nemico == "kraken")
            {
                baule.Visible = false;
                baule.Enabled = false;
            }
            else
            {
                baule.Visible = true;
                baule.Enabled = true;
            }

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (messaggio == false)
            {
                if (punti1 <= 0 || munizioni1 == 0)
                {
                    possibilitaSparo = false;
                    punti1 = 260;
                    punti2 = 260;
                    messaggio = true;
                    colpisci = true;
                    naveCheHaPerso = 1;
                    timerAnimazioni.Start();
                    MessageBox.Show("Ha vinto Player2", "Vittoria!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(punti2 <= 0 || munizioni2 == 0)
                {
                    possibilitaSparo = false;
                    punti1 = 260;
                    punti2 = 260;
                    messaggio = true;
                    colpisci = true;
                    naveCheHaPerso = 0;
                    timerAnimazioni.Start();
                    MessageBox.Show("Ha vinto Player1", "Vittoria!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if(!(ball.Location.X >= 1320 || ball.Location.X<=0))
            {
                ball.Enabled = true;
                Vx += (vento_Vx * 10);
                //Vy = Ay*Vy;
                Vy += Ay;
                if (turno == 0)
                {
                    ball.Visible = true;
                    ball.Location = new Point(ball.Location.X + Vx, ball.Location.Y - Vy);
                    boom.Location = new Point(Nave1.Location.X + 241, Nave1.Location.Y + 92);
                    if (ball.Bounds.IntersectsWith(kraken.Bounds))
                    {
                        if (arma1 == "bomba")
                        {
                            colpisci = false;
                            vita2.Size = new Size(punti2 -= 50, 23);
                            punti2 -= 50;
                            turno = 0;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y);
                            ball.Visible = false;
                            turno = 1;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        else if (arma1 == "molotov")
                        {
                            colpisci = false;
                            vita2.Size = new Size(punti2 -= 60, 23);
                            punti2 -= 60;
                            turno = 0;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y);
                            ball.Visible = false;
                            turno = 1;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        else
                        {
                            colpisci = false;
                            vita2.Size = new Size(punti2 -= 30, 23);
                            punti2 -= 30;
                            turno = 0;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y);
                            ball.Visible = false;
                            turno = 1;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }

                    }

                }
                else if (turno == 1)
                {
                    ball.Visible = true;
                    ball.Location = new Point(ball.Location.X - Vx, ball.Location.Y - Vy);
                    boom.Location = new Point(Nave2.Location.X - 60, Nave2.Location.Y + 92);
                    if (ball.Bounds.IntersectsWith(kraken.Bounds))
                    {
                        if (arma2 == "bomba")
                        {
                            colpisci = false;
                            vita1.Size = new Size(punti1 -= 50, 23);
                            punti1 -= 50;
                            turno = 1;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y + 200);
                            ball.Visible = false;
                            turno = 0;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        else if (arma2 == "molotov")
                        {
                            colpisci = false;
                            vita1.Size = new Size(punti1 -= 60, 23);
                            punti1 -= 60;
                            turno = 1;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y + 200);
                            ball.Visible = false;
                            turno = 0;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        else
                        {
                            colpisci = false;
                            vita1.Size = new Size(punti1 -= 30, 23);
                            punti1 -= 30;
                            turno = 1;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y + 200);
                            ball.Visible = false;
                            turno = 0;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }


                    }

                }
                if (turno == 0)
                {
                    ball.Visible = true;
                    ball.Location = new Point(ball.Location.X + Vx, ball.Location.Y - Vy);
                    boom.Location = new Point(Nave1.Location.X + 241, Nave1.Location.Y + 92);
                    if (ball.Bounds.IntersectsWith(Nave2.Bounds))
                    {
                        if (arma1 == "bomba")
                        {
                            colpisci = false;
                            vita2.Size = new Size(punti2 -= 50, 23);
                            punti2 -= 50;
                            turno = 0;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y);
                            ball.Visible = false;
                            turno = 1;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }else if (arma1 == "molotov")
                        {
                            colpisci = false;
                            vita2.Size = new Size(punti2 -= 60, 23);
                            punti2 -= 60;
                            turno = 0;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y);
                            ball.Visible = false;
                            turno = 1;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        else
                        {
                            colpisci = false;
                            vita2.Size = new Size(punti2 -= 30, 23);
                            punti2 -= 30;
                            turno = 0;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y);
                            ball.Visible = false;
                            turno = 1;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        
                    }

                }
                else if (turno == 1)
                {
                    ball.Visible = true;
                    ball.Location = new Point(ball.Location.X - Vx, ball.Location.Y - Vy);
                    boom.Location = new Point(Nave2.Location.X-60, Nave2.Location.Y + 92);
                    if (ball.Bounds.IntersectsWith(Nave1.Bounds))
                    {
                        possibilitaSparo = true;
                        if (arma2 == "bomba")
                        {
                            colpisci = false;
                            vita1.Size = new Size(punti1 -= 50, 23);
                            punti1 -= 50;
                            turno = 1;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y + 200);
                            ball.Visible = false;
                            turno = 0;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }else if (arma2 == "molotov")
                        {
                            colpisci = false;
                            vita1.Size = new Size(punti1 -= 60, 23);
                            punti1 -= 60;
                            turno = 1;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y + 200);
                            ball.Visible = false;
                            turno = 0;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        else
                        {
                            colpisci = false;
                            vita1.Size = new Size(punti1 -= 30, 23);
                            punti1 -= 30;
                            turno = 1;
                            ball.Enabled = false;
                            ball.Location = new Point(ballPlacement.Location.X, ballPlacement.Location.Y + 200);
                            ball.Visible = false;
                            turno = 0;
                            timerPlayer1.Stop();
                            boom.Visible = false;
                        }
                        

                    }

                }
            }
            else
            {
                if (turno == 0)
                {
                    timerPlayer1.Stop();
                    vita1.Size = new Size(punti1 -= 30, 23);
                    turno = 1;
                    colpisci = false;
                    boom.Visible = false;
                }
                else
                {
                    timerPlayer1.Stop();
                    vita2.Size = new Size(punti2 -= 30, 23);
                    turno = 0;
                    colpisci = false;
                    boom.Visible = false;
                }
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (turno == 0)
            {
                turnoV1.Visible = true;
                turnoV2.Visible = false;
            }
            else
            {
                turnoV1.Visible = false;
                turnoV2.Visible = true;
            }

            alpha = TestoAlpha;
            VelocitaIniziale = TestoForza;
            arma1label.Text = arma1;
            arma2label.Text = arma2;
            alpha1.Text = alpha.ToString();
            alpha2.Text = alpha.ToString();
            munizioni1 = TestoMunizioniUno;
            munizioni2 = TestoMunizioniDue;
            ammunition.Text = munizioni1.ToString();
            ammunition2.Text = munizioni2.ToString();


            if (nemico == "kraken")
            {
                baule.Visible = false;
                baule.Enabled = false;
            }
            else
            {
                baule.Visible = true;
                baule.Enabled = true;
            }

            if (mossePerBaule == contaMosse)
            {
                mossePerBaule = 0;
                randomBaule = rnd.Next(-200, 200);
                baule.Location = new Point(baule.Location.X, baulePlacement.Location.Y);
                baule.Location = new Point(baule.Location.X - randomBaule, baule.Location.Y);
                baule.Enabled = true;
                baule.Visible = true;

            }
            if (Nave1.Bounds.IntersectsWith(baule.Bounds))
            {
                /*maltempo = true;
                nemico = "null";
                nuvola.Visible = true;
                //timerPlayer2.Start();*/
                soldi.Play();
                munizioni1 += 5;
                ammunition.Text = munizioni1.ToString();
                baule.Enabled = false;
                baule.Visible = false;
                baule.Location = new Point(baule.Location.X, baule.Location.Y + 500);
                if (turno == 0)
                {
                    turno = 1;

                }
                else
                {
                    turno = 0;

                }
            }
            else if (Nave2.Bounds.IntersectsWith(baule.Bounds))
            {
                soldi.Play();
                munizioni2 += 5;
                if (munizioni2 > 6)
                {
                    turnoMaltempo = 0;
                }
                ammunition2.Text = munizioni2.ToString();
                baule.Enabled = false;
                baule.Visible = false;
                baule.Location = new Point(baule.Location.X, baule.Location.Y + 500);
                if (turno == 0)
                {
                    turno = 1;
                }
                else
                {
                    turno = 0;
                }
            }
            if (colpisci == false)
            {
                if (possibilitaSparo == true)
                {

                    if (e.KeyCode == Keys.Space)
                    {

                        esplosione.Play();
                        colpisci = true;
                        ball.Visible = true;
                        ball.Enabled = true;
                        contaMosse++;

                        if (turno == 0)
                        {
                            ball.Location = new Point(Nave1.Location.X, Nave1.Location.Y);
                            munizioni1--;
                            ammunition.Text = munizioni1.ToString();
                            boom.Visible = true;
                            boom.Location = new Point(Nave1.Location.X + 241, Nave1.Location.Y + 92);
                            if (arma1 == "bomba")
                            {
                                ball.Image = Image.FromFile(@"bomb2.png");
                                ball.Width += 10;
                                ball.Height += 10;

                            }
                            else if (arma1 == "molotov")
                            {
                                ball.Image = Image.FromFile(@"molotov.png");
                                ball.Width += 10;
                                ball.Height += 10;
                            }
                            else
                            {
                                ball.Image = Image.FromFile(@"ball.png");
                                ball.Width = 30;
                                ball.Height = 30;
                            }
                        }
                        else
                        {
                            ball.Location = new Point(Nave2.Location.X, Nave2.Location.Y);
                            munizioni2--;
                            ammunition2.Text = munizioni2.ToString();
                            boom.Visible = true;
                            boom.Location = new Point(Nave2.Location.X - 241, Nave2.Location.Y + 92);
                            if (arma2 == "bomba")
                            {
                                ball.Image = Image.FromFile(@"bomb2.png");
                                ball.Width += 10;
                                ball.Height += 10;

                            }
                            else if (arma2 == "molotov")
                            {
                                ball.Image = Image.FromFile(@"molotov.png");
                                ball.Width += 10;
                                ball.Height += 10;
                            }
                            else
                            {
                                ball.Image = Image.FromFile(@"ball.png");
                                ball.Width = 30;
                                ball.Height = 30;
                            }
                        }
                        Vx = (int)(VelocitaIniziale * (Math.Sin(alpha)));
                        Vy = (int)(VelocitaIniziale * (Math.Cos(alpha - 1.57)));
                        timerPlayer1.Start();
                    }


                }

                
                if (e.KeyCode == Keys.N)
                {
                    if (turno == 0)
                    {
                        Form2 frm = new Form2(this);
                        frm.Show();
                    }
                    else
                    {
                        Form2 frm = new Form2(this);
                        frm.Show();
                    }
                }
                if (e.KeyCode == Keys.W)
                {
                    if (turno == 0)
                    {
                        if (250 < Nave1.Location.Y || 400 > Nave1.Location.Y)
                        {
                            Nave1.Location = new Point(Nave1.Location.X, Nave1.Location.Y - 7);
                        }
                        if (Nave1.Location.Y <= 250)
                        {
                            Nave1.Location = new Point(Nave1.Location.X, Nave1.Location.Y + 20);
                        }


                    }
                    else if (turno == 1)
                    {
                        if (250 < Nave2.Location.Y || 400 > Nave2.Location.Y)
                        {
                            Nave2.Location = new Point(Nave2.Location.X, Nave2.Location.Y - 7);
                        }
                        if (Nave2.Location.Y <= 250)
                        {
                            Nave2.Location = new Point(Nave2.Location.X, Nave2.Location.Y + 20);
                        }

                    }
                }
                if (e.KeyCode == Keys.S)
                {
                    if (turno == 0)
                    {
                        if (250 < Nave1.Location.Y || 400 > Nave1.Location.Y)
                        {
                            Nave1.Location = new Point(Nave1.Location.X, Nave1.Location.Y + 7);
                        }
                        if (Nave1.Location.Y >= 400)
                        {
                            Nave1.Location = new Point(Nave1.Location.X, Nave1.Location.Y - 20);
                        }

                    }
                    else if (turno == 1)
                    {
                        if (250 < Nave2.Location.Y || 400 > Nave2.Location.Y)
                        {
                            Nave2.Location = new Point(Nave2.Location.X, Nave2.Location.Y + 7);
                        }
                        if (Nave2.Location.Y >= 400)
                        {
                            Nave2.Location = new Point(Nave2.Location.X, Nave2.Location.Y - 20);
                        }

                    }
                }
                if (e.KeyCode == Keys.A)
                {
                    if (turno == 0)
                    {
                        if (Nave1.Location.X >= 12 || Nave1.Location.X <= 313)
                        {
                            Nave1.Location = new Point(Nave1.Location.X - 10, Nave1.Location.Y);
                        }
                        if (Nave1.Location.X <= 12)
                        {
                            Nave1.Location = new Point(Nave1.Location.X + 7, Nave1.Location.Y);
                        }


                    }
                    else if (turno == 1)
                    {
                        if (Nave2.Location.X <= 1033 || Nave2.Location.X >= 724)
                        {
                            Nave2.Location = new Point(Nave2.Location.X - 10, Nave2.Location.Y);
                        }
                        if (Nave2.Location.X <= 724)
                        {
                            Nave2.Location = new Point(Nave2.Location.X + 7, Nave2.Location.Y);
                        }

                    }
                }
                if (e.KeyCode == Keys.D)
                {
                    if (turno == 0)
                    {
                        if (Nave1.Location.X >= 12 || Nave1.Location.X <= 313)
                        {
                            Nave1.Location = new Point(Nave1.Location.X + 10, Nave1.Location.Y);
                        }
                        if (Nave1.Location.X >= 313)
                        {
                            Nave1.Location = new Point(Nave1.Location.X - 7, Nave1.Location.Y);
                        }
                    }
                    else if (turno == 1)
                    {
                        if (Nave2.Location.X <= 980 || Nave2.Location.X >= 724)
                        {
                            Nave2.Location = new Point(Nave2.Location.X + 10, Nave2.Location.Y);
                        }
                        if (Nave2.Location.X >= 980)
                        {
                            Nave2.Location = new Point(Nave2.Location.X - 7, Nave2.Location.Y);
                        }

                    }
                }
            }
            
            /*
            if (e.KeyCode == Keys.Up)
            {
                alpha++;
                visualAlpha++;
                alpha1.Text = visualAlpha.ToString();
                alpha2.Text = visualAlpha.ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                alpha--;
                visualAlpha--;
                alpha1.Text = visualAlpha.ToString();
                alpha2.Text = visualAlpha.ToString();
            }*/
            if (e.KeyCode == Keys.C)
            {

                Form3 f3 = new Form3(this);
                f3.Show();

            }
            if (e.KeyCode == Keys.H)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            

        }


        private void timerAnimazioni_Tick(object sender, EventArgs e)
        {
            if(naveCheHaPerso == 1)
            {
                if (Nave1.Location.Y < 427)
                {
                    if (rotazioneNave == 0)
                    {
                        Image img = Nave1.Image;
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        Nave1.Width = 176;
                        Nave1.Height = 259;
                        rotazioneNave += 1;
                    }
                    Nave1.Location = new Point(Nave1.Location.X, Nave1.Location.Y + 2);
                }
                else
                {
                    timerAnimazioni.Stop();
                    rotazioneNave = 0;
                    Image img = Nave1.Image;
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    Nave1.Width = 259;
                    Nave1.Height = 176;
                    button1.Visible = true;
                    button1.Enabled = true;
                }

            }
            else if(naveCheHaPerso==0)
            {
                if (Nave2.Location.Y < 427)
                {
                    if (rotazioneNave == 0)
                    {
                        Image img = Nave2.Image;
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        Nave2.Width = 176;
                        Nave2.Height = 259;
                        rotazioneNave += 1;
                    }
                    Nave2.Location = new Point(Nave2.Location.X, Nave2.Location.Y + 2);
                }
                else
                {
                    timerAnimazioni.Stop();
                    rotazioneNave = 0;
                    Image img = Nave2.Image;
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    Nave2.Width = 259;
                    Nave2.Height = 176;
                    button1.Visible = true;
                    button1.Enabled = true;
                }
            }
        }

        private void Eventi()
        {
            if (nemico == "kraken")
            {
                timerPlayer2.Stop();
                kraken.Visible = true;
                kraken.Enabled = true;
                for (int i = 0; i < 30; i++)
                {
                    kraken.Location = new Point(kraken.Location.X, kraken.Location.Y - 10);
                }
            }
            else
            {
                kraken.Location = new Point(KrakenPlacement.Location.X, KrakenPlacement.Location.Y);
                kraken.Visible=false;
                kraken.Enabled=false;
            }
            
        }
        
        private void timerPlayer2_Tick(object sender, EventArgs e)
        {
            if (nemico == "null")
            {
                if (nuvola2.Location.X > -480 && nuvola2.Location.X > -800)
                {
                    nuvola.Left -= 4;
                    nuvola2.Left -= 6;
                    if (turno == 0)
                    {
                        int g = (int)alpha;
                        alpha = rnd.Next(g, 360) * Math.PI / 180;
                        VelocitaIniziale = rnd.Next(20, VelocitaIniziale);
                    }
                    else if (turno == 1)
                    {
                        int g = (int)alpha;
                        alpha = rnd.Next(g, 360) * Math.PI / 180;
                        VelocitaIniziale = rnd.Next(20, VelocitaIniziale);
                    }

                }
                else
                {
                    nuvola.Location = new Point(nuvolePlacement.Location.X, nuvola.Location.Y);
                    nuvola2.Location = new Point(nuvolePlacement.Location.X, nuvola2.Location.Y);
                }
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerAnimazioni.Stop();
            button1.Visible = false;
            button1.Enabled = false;
            Nave1.Location = new Point(Nave1Placement.Location.X, Nave1Placement.Location.Y);
            Nave2.Location = new Point(Nave2Placement.Location.X, Nave2Placement.Location.Y);
            VelocitaIniziale = 40;
            //timerPlayer2.Stop();
            timerPlayer1.Start();
            Ay = -1;
            vento_Vx = 0;
            alpha = 5;
            visualAlpha = 0;
            turno = 0;
            i = 100;
            contaMosse = 0;
            randomBaule = 0;
            mossePerBaule = 0;
            arma1 = "cannone";
            arma2 = "cannone";
            colpisci = false;
            messaggio = false;
            //maltempo = false;
            possibilitaSparo = true;
            rotazioneNave = 0;
            munizioni1 = 5;
            munizioni2 = 5;
            naveCheHaPerso = 0;
            ammunition.Text = munizioni1.ToString();
            ammunition2.Text = munizioni2.ToString();
            alpha1.Text = alpha.ToString();
            alpha2.Text = alpha.ToString();
            nemico = "null";
            punti1 = 260;
            punti2 = 260;
            vita1.Width = punti1;
            vita2.Width = punti2;
            mossePerBaule = rnd.Next(1, 5);
            turno = rnd.Next(0, 2);
            rmal = rnd.Next(0, 2);
            if (rmal == 0)
            {
                maltempo = false;
                nemico = "null";
                nuvola.Visible = false;
                Eventi();
            }
            else if (rmal == 1)
            {
                maltempo = true;
                nemico = "kraken";
                nuvola.Visible = true;
                Eventi();
            }
            else
            {
                maltempo = true;
                nemico = "null";
                nuvola.Visible = false;
                timerPlayer2.Stop();
            }
            if (nemico == "kraken")
            {
                baule.Visible = false;
                baule.Enabled = false;
            }
            else
            {
                baule.Visible = true;
                baule.Enabled = true;
            }
        }
    }
    
}
