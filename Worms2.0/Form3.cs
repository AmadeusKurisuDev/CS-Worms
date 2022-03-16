using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worms2._0
{
    public partial class Form3 : Form
    {
        private Form1 mainForm = null;
        private double gradiC;
        private int forzaC;
        public int num;
        public int red = 0;
        public int green = 255;
        public int blue = 0;

        public Form3(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            gradiC = 0;
            forzaC = 0;
            num = 0;
            Bitmap cannone = new Bitmap(@"cannoneGradi.png");
            immagineCannone.Image = RotImage(cannone, 30);
            panel1.Width = 5;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private Bitmap RotImage(Bitmap rotateMe, float angle)
        {
            //First, re-center the image in a larger image that has a margin/frame
            //to compensate for the rotated image's increased size

            var bmp = new Bitmap(rotateMe.Width + (rotateMe.Width / 2), rotateMe.Height + (rotateMe.Height / 2));

            using (Graphics g = Graphics.FromImage(bmp))
                g.DrawImageUnscaled(rotateMe, (rotateMe.Width / 4), (rotateMe.Height / 4), bmp.Width, bmp.Height);

            bmp.Save("moved.png");
            rotateMe = bmp;

            //Now, actually rotate the image
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);   //set the rotation point as the center into the matrix
                g.RotateTransform(angle);                                        //rotate
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2); //restore rotation point into the matrix
                g.DrawImage(rotateMe, new Point(0, 0));                          //draw the image on the new bitmap
            }

            rotatedImage.Save("rotated.png");
            return rotatedImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainForm.TestoAlpha = gradiC;
            this.mainForm.TestoForza = forzaC;

            this.Hide();
        }

        /*ChangeColor(int num)
        {
            // num being between 0 and 4095, get a value between 0 and 255
            int red = ((num + 1) / 16) - 1;
            rappresentaForza.BackColor(new Color(red, 0, 0));
        }*/

        private void gradi_ValueChanged(object sender, EventArgs e)
        {
            gradiC = ((double)(gradi.Value)*Math.PI/180);
            Bitmap cannone = new Bitmap(@"cannoneGradi.png");
            immagineCannone.Image = RotImage(cannone,(-(float)gradi.Value)+30);
            /*if (gradiC <= 0)
            {
                gradiC -= 360;
            }else if (gradiC>=0)
            {
                gradiC
            }*/
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void potenza_ValueChanged(object sender, EventArgs e)
        {
            if (potenza.Value >= 45)
            {
                potenza.Value = 0;

            }
            num = (int)potenza.Value;
            panel1.Width = (int)(num*1.8);
            forzaC = (int)potenza.Value;


            /*if (num >= 100)
            {
                green += (int)(num * 0.5);
                if (green >= 256)
                {
                    green = 255;
                }
            }
            else
            {
                red -= (int)(num * 0.5);
                if(red <= 0)
                {
                    red = 0;
                }
            }
            
            if (num <= 50)
            {
                red += (int)(num*0.5);
                if (red >= 256)
                {
                    red = 255;
                }
                panel1.BackColor = Color.FromArgb(red, green, 0);
            }
            else
            {
                green -= (int)(num*0.5);
                if (green <= 0)
                {
                    green = 0;
                }
                panel1.BackColor = Color.FromArgb(red, green, 0);
            }
            panel1.BackColor = Color.FromArgb(red, green, 0);*/
        }



        /*
        int N = 4;
        float M = 1.5f;
        float healthCalc = (float)(((float)HitPoints / (float)TotalHitPoints)) * 100f;
        float N_root = (float)Mathf.Pow((healthCalc / 100f), (1f / M));
        float N_power = (float)Mathf.Pow((healthCalc / 100f), N);
 
 
         if (healthCalc< 50)
         {
             healthBar.BarColor = Color.Lerp(Color.red, Color.yellow, (float) N_root);
         }
         else if (healthCalc >= 50)
         {
             healthBar.BarColor = Color.Lerp(Color.yellow, Color.green, (float) N_power);
         }*/
    }
}
