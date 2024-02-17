using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class bird1 : Form
    {
        int boruhizi = 10;
        int yercekimi = 5;
        int score = 0;
        public bird1()
        {
            InitializeComponent();
        }
        private void timer1Event(object sender, EventArgs e)
        {
            pictureBox4.Top += yercekimi;
            pictureBox3.Left -= boruhizi;
            pictureBox2.Left -= boruhizi;
            label1.Text = "" + score;
            if (pictureBox3.Left < -170)
            {
                pictureBox3.Left = 400;
            }
            if (pictureBox2.Left < -130)
            {
                pictureBox2.Left = 400;
                score++;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox4.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox4.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                endGame();
            }
            if (score >= 5)
            {
                boruhizi = 13;
            }
            if (score >= 10)
            {
                boruhizi = 15;
            }
            if (score >= 15)
            {
                boruhizi = 17;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekimi = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekimi = 10;
            }
        }
        private void endGame()
        {
            timer1.Stop();
            label1.Text = "Game Over!";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mainMenu main = new mainMenu();
            main.Show();
            this.Hide();
        }
    }
}
