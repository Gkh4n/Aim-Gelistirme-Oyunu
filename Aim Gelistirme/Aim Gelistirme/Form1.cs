using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aim_Gelistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Sure = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sure--;
            sureLbl.Text = Sure.ToString();

            if (Sure == 0)
            {
                oyunSonuLbl.Visible = true;
                oyunSonuLbl.Text = "Süre Doldu, Skorunuz : " + Skor.ToString();
                yenidenOynaBtn.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                panel1.Enabled = false;
                timer1.Stop();
            }
        }
        int Skor = 0;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            panel1.Enabled = true;

            Random random = new Random();
            int nokta_X, nokta_Y;
            nokta_X = random.Next(50, 750);
            nokta_Y = random.Next(70, 450);
            pictureBox1.Location = new Point(nokta_X, nokta_Y);

            Skor++;
            skorLbl.Text = Skor.ToString();
        }

        int Can = 3;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Can--;
            canLbl.Text = Can.ToString();

            if (Can == 0 )
            {
                oyunSonuLbl.Visible = true;
                oyunSonuLbl.Text = "Kaybettiniz, Skorunuz : " + Skor.ToString();
                yenidenOynaBtn.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                timer1.Stop();
            }

            if (oyunSonuLbl.Visible)
            {
                canLbl.Text = "0";
            }
        }

        private void yenidenOynaBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Can = 3;
            Sure = 60;
            Skor = 0;
            //Application.Restart(); >> formu kapatıp tekrar başlatır
        }
    }
}