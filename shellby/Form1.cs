using System;
using System.Drawing;
using System.Windows.Forms;

namespace shellby
{
    public partial class Form1 : Form
    {
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch21_CheckedChanged(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Risky maybe you get ban");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)//here how to move loader 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)//here how to move loader 
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)//here how to move loader 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//here how to move loader 
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://eclipse.lol/");
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/Riot_Eclipse");
        }
    }
}
