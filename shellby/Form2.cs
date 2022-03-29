using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace shellby
{
    public partial class Form2 : Form
    {
        private Point lastPoint;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Shown (object sender, EventArgs e)
        {

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Injector");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuLabel1.Text = DateTime.Now.ToLongDateString();
            bunifuLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {


        }

        private void bunifuIconButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://eclipse.lol/");
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/Riot_Eclipse");
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
