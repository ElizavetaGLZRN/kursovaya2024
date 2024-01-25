using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая
{
    public partial class Form2 : Form
    {
        public int sleep = 0;
        public readonly object Imagelist1;

        public Form2()
        {
            InitializeComponent();
            
            Game.Image = imageList1.Images[3];
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Button4_Click(object sender, EventArgs e)
        {
            Game.Image = imageList1.Images[3];
            sleep = 0;
            Button1.Enabled = true;
            Button2.Enabled = true;
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            while (ProgressBar3.Value < 100)
            {
                ProgressBar3.Value =+100;
            }
            if (ProgressBar3.Value > 50)
            {
                Game.Image = imageList1.Images[2];
            }
        }

        public void Button2_Click(object sender, EventArgs e)
        {

            if (ProgressBar2.Value > ProgressBar2.Maximum - 10)
            {
                Button2.Enabled = false;
            }
            if (ProgressBar2.Value < ProgressBar2.Maximum - 10)
            {
                ProgressBar2.Value += 10;
                Game.Image = imageList1.Images[1];
            }
            
            
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            Game.Image = imageList1.Images[4];
            sleep = 1;
            Button1.Enabled = false;
            Button2.Enabled = false;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            
            if (ProgressBar2.Value < ProgressBar2.Maximum - 10 && sleep == 0)
            {
                Button2.Enabled = true;
            }
            
            if (ProgressBar2.Value == 1)
            {
                Game.Image = imageList1.Images[5];
                Happy.Enabled = false;
                Button1 .Enabled = false;
                Button2 .Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Soon.Enabled = false;
                
            }
            ProgressBar2.Value--;
        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            if (sleep == 1)
            {
                if (ProgressBar1.Value != 100)
                {
                    ProgressBar1.Value++;
                }

            }
            else
            {
                Game.Image = imageList1.Images[3];
                ProgressBar1.Value--;
            }

            if (ProgressBar3.Value == 1)  
            {
                Game.Image = imageList1.Images[5];
                Happy.Enabled = false;
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Soon.Enabled = false;

            }
            if (ProgressBar1.Value == 1)
            {
                Game.Image = imageList1.Images[5];
                Happy.Enabled = false;
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Soon.Enabled = false;

            }
            ProgressBar3 .Value--;
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        public void ProgressBar3_Click(object sender, EventArgs e)
        {
            //
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
