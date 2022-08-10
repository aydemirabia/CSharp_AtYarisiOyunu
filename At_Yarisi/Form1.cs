using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1uzaklik, at2uzaklik, at3uzaklik, at4uzaklik, at5uzaklik, at6uzaklik;

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            at1uzaklik = pictureBox1.Left;
            at2uzaklik = pictureBox2.Left;
            at3uzaklik = pictureBox3.Left;
            at4uzaklik = pictureBox4.Left;
            at5uzaklik = pictureBox5.Left;
            at6uzaklik = pictureBox6.Left;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MİLİSANİYE CİNSİNDEN
            int derece = Convert.ToInt32(lblSure.Text);
            derece++;
            lblSure.Text = derece.ToString();

            int at1genislik = pictureBox1.Width;
            int at2genislik = pictureBox2.Width;
            int at3genislik = pictureBox3.Width;
            int at4genislik = pictureBox4.Width;
            int at5genislik = pictureBox5.Width;
            int at6genislik = pictureBox6.Width;

            int bitisCizgisi = lblBitisCizgisi.Left;

            pictureBox1.Left += rnd.Next(5, 15);
            pictureBox2.Left += rnd.Next(5, 15);
            pictureBox3.Left += rnd.Next(5, 15);
            pictureBox4.Left += rnd.Next(5, 15);
            pictureBox5.Left += rnd.Next(5, 15);
            pictureBox6.Left += rnd.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5 &&  pictureBox1.Left > pictureBox4.Left + 5 && pictureBox1.Left > pictureBox5.Left + 5 && pictureBox1.Left > pictureBox6.Left + 5)
            {
                lblCanli.Text = "1 Numaralı At Yarışı Önde Götürüyor...";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5 && pictureBox2.Left > pictureBox5.Left + 5 && pictureBox2.Left > pictureBox6.Left + 5)
            {
                lblCanli.Text = "2 Numaralı At Atak Yaparak Öne Geçti...";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5 && pictureBox3.Left > pictureBox5.Left + 5 && pictureBox3.Left > pictureBox6.Left + 5)
            {
                lblCanli.Text = "3 Numaralı At Mükemmel Bir Hızla Öne Geçti...";
            }
            if (pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5 && pictureBox4.Left > pictureBox5.Left + 5 && pictureBox4.Left > pictureBox5.Left + 5 && pictureBox4.Left > pictureBox1.Left + 5)
            {
                lblCanli.Text = "4 Numaralı At Rakiplerini Geride Bırakıyor...";
            }
            if (pictureBox5.Left > pictureBox2.Left + 5 && pictureBox5.Left > pictureBox3.Left + 5 && pictureBox5.Left > pictureBox4.Left + 5 && pictureBox5.Left > pictureBox1.Left + 5 && pictureBox5.Left > pictureBox6.Left + 5)
            {
                lblCanli.Text = "5 Numaralı At Yarışı Aldı Götürüyor...";
            }
            if (pictureBox6.Left > pictureBox2.Left + 5 && pictureBox6.Left > pictureBox3.Left + 5 && pictureBox6.Left > pictureBox4.Left + 5 && pictureBox6.Left > pictureBox5.Left + 5 && pictureBox6.Left > pictureBox1.Left + 5)
            {
                lblCanli.Text = "6 Numaralı At Parkura Hızlı Bir Giriş Yaptı...";
            }


            if (at1genislik + pictureBox1.Left >= bitisCizgisi)
            {
                timer1.Enabled = false;
                lblCanli.Text = "1 Numaralı At Yarışı Kazandı!";
            }
            if (at2genislik + pictureBox2.Left >= bitisCizgisi)
            {
                timer1.Enabled = false;
                lblCanli.Text = "2 Numaralı At Yarışı Kazandı!";
            }
            if (at3genislik + pictureBox3.Left >= bitisCizgisi)
            {
                timer1.Enabled = false;
                lblCanli.Text = "3 Numaralı At Yarışı Kazandı!";
            }
            if (at4genislik + pictureBox4.Left >= bitisCizgisi)
            {
                timer1.Enabled = false;
                lblCanli.Text = "4 Numaralı At Yarışı Kazandı!";
            }
            if (at5genislik + pictureBox5.Left >= bitisCizgisi)
            {
                timer1.Enabled = false;
                lblCanli.Text = "5 Numaralı At Yarışı Kazandı!";
            }
            if (at6genislik + pictureBox6.Left >= bitisCizgisi)
            {
                timer1.Enabled = false;
                lblCanli.Text = "6 Numaralı At Yarışı Kazandı!";
            }
        }
    }
}
