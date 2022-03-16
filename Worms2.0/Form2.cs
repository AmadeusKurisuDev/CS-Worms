using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worms2._0
{
    public partial class Form2 : Form
    {
        string arma;
        int punti;
        int stato;
        int munizioniUno=0;
        int munizioniDue=0;

        int prezzo1, prezzo2, prezzo3;
        private Form1 mainForm = null;
        SoundPlayer soldi = new SoundPlayer(@"money.wav");
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            stato = this.mainForm.TestoTurno;
            if (stato == 0)
            {
                arma = this.mainForm.TestoArma1;
                punti = this.mainForm.TestoPunti1;
                munizioniUno = this.mainForm.TestoMunizioniUno;
            }
            else
            {
                arma = this.mainForm.TestoArma2;
                punti = this.mainForm.TestoPunti2;
                munizioniDue = this.mainForm.TestoMunizioniDue;
            }
            prezzo1 = 20;
            prezzo2 = 30;
            prezzo3 = 50;
            puntidisponibili.Text = "";
            prezzotot.Text = "";
            puntidisponibili.Text = punti.ToString();
            prezzo.Text = prezzo1.ToString();
            label7.Text = prezzo2.ToString();
            label8.Text = prezzo3.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prezzo_Click(object sender, EventArgs e)
        {

        }

        private void oggetto1togli_Click(object sender, EventArgs e)
        {
            arma = "";
            punti += prezzo1;
            prezzotot.Text = "0000,00";
            oggetto1.Visible = true;
            oggetto2.Visible = true;
            oggetto3.Visible = true;
            oggetto2togli.Visible = true;
            oggetto3togli.Visible = true;
        }

        private void oggetto2_Click(object sender, EventArgs e)
        {
            prodotto.Image = Image.FromFile(@"molotov.png");
            danni.Text = "60";
            if (punti >= prezzo1)
            {
                arma = "molotov";
                if (stato == 0)
                {
                    munizioniUno++;
                }
                else
                {
                    munizioniDue++;
                }
                punti -= prezzo1;
                prezzotot.Text = prezzo1.ToString();
                oggetto1.Visible = false;
                oggetto2.Visible = false;
                oggetto3.Visible = false;
                oggetto1togli.Visible = false;
                oggetto2togli.Visible = true;
                oggetto3togli.Visible = false;

            }
            else
            {
                oggetto1.Visible = true;
                oggetto1togli.Visible = true;
                oggetto3.Visible = true;
                oggetto3togli.Visible = true;
                MessageBox.Show("Non hai abbastanza punti!", "Ci dispiace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void oggetto3_Click(object sender, EventArgs e)
        {
            if (punti >= prezzo1)
            {
                punti -= prezzo1;
                prezzotot.Text = prezzo1.ToString();
                oggetto1.Visible = false;
                oggetto2.Visible = false;
                oggetto3.Visible = false;
                oggetto1togli.Visible = false;
                oggetto2togli.Visible = false;
                oggetto3togli.Visible = true;
                if (stato == 0)
                {
                    munizioniUno++;
                }
                else
                {
                    munizioniDue++;
                }

            }
            else
            {
                oggetto1.Visible = true;
                oggetto1togli.Visible = true;
                oggetto3.Visible = true;
                oggetto3togli.Visible = true;
                MessageBox.Show("Non hai abbastanza punti!", "Ci dispiace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void oggetto3togli_Click(object sender, EventArgs e)
        {
            arma = "";
            punti += prezzo1;
            prezzotot.Text = "0000,00";
            oggetto1.Visible = true;
            oggetto2.Visible = true;
            oggetto3.Visible = true;
            oggetto2togli.Visible = true;
            oggetto3togli.Visible = true;
            if (stato == 0)
            {
                munizioniUno--;
            }
            else
            {
                munizioniDue--;
            }
        }

        private void acquista_Click(object sender, EventArgs e)
        {
            soldi.Play();
            if (stato == 0)
            {
                this.mainForm.TestoArma1 = arma;
                this.mainForm.TestoPunti1 = punti;
                this.mainForm.TestoTurno = stato;
                this.mainForm.TestoMunizioniUno = munizioniUno;
            }
            else
            {
                this.mainForm.TestoArma2 = arma;
                this.mainForm.TestoPunti2 = punti;
                this.mainForm.TestoTurno = stato;
                this.mainForm.TestoMunizioniDue = munizioniDue;
            }
            this.Hide();
        }

        private void oggetto1_Click(object sender, EventArgs e)
        {
            prodotto.Image = Image.FromFile(@"bomb2.png");
            danni.Text = "50";
            if (punti >= prezzo1)
            {
                arma = "bomba";
                punti -= prezzo1;
                prezzotot.Text = prezzo1.ToString();
                oggetto1.Visible = false;
                oggetto2.Visible = false;
                oggetto3.Visible = false;
                oggetto2togli.Visible = false;
                oggetto3togli.Visible = false;

            }
            else
            {
                oggetto2.Visible = true;
                oggetto3.Visible = true;
                oggetto2togli.Visible = true;
                oggetto3togli.Visible = true;
                MessageBox.Show("Non hai abbastanza punti!", "Ci dispiace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
