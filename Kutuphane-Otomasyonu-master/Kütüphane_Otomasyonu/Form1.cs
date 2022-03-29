﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = textBox1.Text;
            int Sifre = Convert.ToInt16(textBox2.Text);

            bool sonuc = B10.Admin(KullaniciAdi, Sifre);

            if (sonuc == false)
            {
                MessageBox.Show("Kullanıcı adı yada şifre yanlış!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                Form1 kapat = new Form1();
                kapat.Close();
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
        }
    }
}
