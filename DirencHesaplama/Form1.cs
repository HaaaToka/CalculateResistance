using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirencHesaplama
{
    enum Renkler
    {
        siyah , kahverengi , kırmızı , turuncu , sarı , yeşil , mavi , mor , gri , beyaz
    }
    enum Tolerans
    {
        kahverengi , kırmızı , yeşil , mavi , mor , gri
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string no1 = "", no2 = "", sayı;
            double no3 = 0.0, carpım;
            
            no1 = comboBox1.SelectedIndex.ToString();
            textBox1.Text = no1;
            no2 = comboBox1.SelectedIndex.ToString();
            textBox2.Text = no2;
            no3 = comboBox3.SelectedIndex;
            textBox3.Text = Math.Pow(10, no3).ToString();
            // text1-2-3 readonly  özelliği açıldı sadece okunabiliyor.
            sayı = no1 + no2;
            carpım = (Convert.ToInt32(sayı))*Math.Pow(10,no3);

            label5.Text = carpım.ToString();



        }
        void tolerans()
        {
            switch (comboBox4.Text)
            {
                case "kahverengi": label6.Text = "+ - %1"; break;
                case "kırmızı": label6.Text = "+ - %2"; break;
                case "yeşil": label6.Text = "+ - %5"; break;
                case "mavi": label6.Text = "+ - %0.25"; break;
                case "mor": label6.Text = "+ - %0.10"; break;
                case "gri": label6.Text = "+ - %0.05"; break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string b in Enum.GetNames(typeof(Renkler)))
            {
                comboBox1.Items.Add(b);
                comboBox2.Items.Add(b);
                comboBox3.Items.Add(b);
            }
            foreach( string a in Enum.GetNames(typeof(Tolerans)))
                comboBox4.Items.Add(a);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "siyah": pictureBox2.BackColor = System.Drawing.Color.Black; break;
                case "kahverengi": pictureBox2.BackColor = System.Drawing.Color.Brown; break;
                case "kırmızı": pictureBox2.BackColor = System.Drawing.Color.Red; break;
                case "turuncu": pictureBox2.BackColor = System.Drawing.Color.Orange; break;
                case "sarı": pictureBox2.BackColor = System.Drawing.Color.Yellow; break;
                case "yeşil": pictureBox2.BackColor = System.Drawing.Color.Green; break;
                case "mavi": pictureBox2.BackColor = System.Drawing.Color.Blue; break;
                case "mor": pictureBox2.BackColor = System.Drawing.Color.Purple; break;
                case "gri": pictureBox2.BackColor = System.Drawing.Color.Gray; break;
                case "beyaz": pictureBox2.BackColor = System.Drawing.Color.White; break;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "siyah": pictureBox3.BackColor = System.Drawing.Color.Black; break;
                case "kahverengi": pictureBox3.BackColor = System.Drawing.Color.Brown; break;
                case "kırmızı": pictureBox3.BackColor = System.Drawing.Color.Red; break;
                case "turuncu": pictureBox3.BackColor = System.Drawing.Color.Orange; break;
                case "sarı": pictureBox3.BackColor = System.Drawing.Color.Yellow; break;
                case "yeşil": pictureBox3.BackColor = System.Drawing.Color.Green; break;
                case "mavi": pictureBox3.BackColor = System.Drawing.Color.Blue; break;
                case "mor": pictureBox3.BackColor = System.Drawing.Color.Purple; break;
                case "gri": pictureBox3.BackColor = System.Drawing.Color.Gray; break;
                case "beyaz": pictureBox3.BackColor = System.Drawing.Color.White; break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "siyah": pictureBox4.BackColor = System.Drawing.Color.Black; break;
                case "kahverengi": pictureBox4.BackColor = System.Drawing.Color.Brown; break;
                case "kırmızı": pictureBox4.BackColor = System.Drawing.Color.Red; break;
                case "turuncu": pictureBox4.BackColor = System.Drawing.Color.Orange; break;
                case "sarı": pictureBox4.BackColor = System.Drawing.Color.Yellow; break;
                case "yeşil": pictureBox4.BackColor = System.Drawing.Color.Green; break;
                case "mavi": pictureBox4.BackColor = System.Drawing.Color.Blue; break;
                case "mor": pictureBox4.BackColor = System.Drawing.Color.Purple; break;
                case "gri": pictureBox4.BackColor = System.Drawing.Color.Gray; break;
                case "beyaz": pictureBox4.BackColor = System.Drawing.Color.White; break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {         
            switch (comboBox4.Text)
            {
                case "kahverengi": pictureBox5.BackColor = System.Drawing.Color.Brown; break;
                case "kırmızı": pictureBox5.BackColor = System.Drawing.Color.Red; break;
                case "yeşil": pictureBox5.BackColor = System.Drawing.Color.Green; break;
                case "mavi": pictureBox5.BackColor = System.Drawing.Color.Blue; break;
                case "mor": pictureBox5.BackColor = System.Drawing.Color.Purple; break;
                case "gri": pictureBox5.BackColor = System.Drawing.Color.Gray; break;
            }
            tolerans();
        }
    }
}
