namespace Worms2._0
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.immagineCannone = new System.Windows.Forms.PictureBox();
            this.gradi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.potenza = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.immagineCannone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potenza)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // immagineCannone
            // 
            this.immagineCannone.BackColor = System.Drawing.Color.Transparent;
            this.immagineCannone.Image = ((System.Drawing.Image)(resources.GetObject("immagineCannone.Image")));
            this.immagineCannone.Location = new System.Drawing.Point(0, 0);
            this.immagineCannone.Name = "immagineCannone";
            this.immagineCannone.Size = new System.Drawing.Size(269, 256);
            this.immagineCannone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.immagineCannone.TabIndex = 0;
            this.immagineCannone.TabStop = false;
            // 
            // gradi
            // 
            this.gradi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gradi.Location = new System.Drawing.Point(437, 91);
            this.gradi.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.gradi.Name = "gradi";
            this.gradi.Size = new System.Drawing.Size(55, 20);
            this.gradi.TabIndex = 1;
            this.gradi.ValueChanged += new System.EventHandler(this.gradi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gradi di Inclinazione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Potenza:";
            // 
            // potenza
            // 
            this.potenza.Location = new System.Drawing.Point(437, 137);
            this.potenza.Name = "potenza";
            this.potenza.Size = new System.Drawing.Size(55, 20);
            this.potenza.TabIndex = 3;
            this.potenza.ValueChanged += new System.EventHandler(this.potenza_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 95);
            this.button1.TabIndex = 5;
            this.button1.Text = "Conferma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(316, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 10);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.immagineCannone);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 256);
            this.panel2.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.potenza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Imposta Colpo";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.immagineCannone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potenza)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox immagineCannone;
        private System.Windows.Forms.NumericUpDown gradi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown potenza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}