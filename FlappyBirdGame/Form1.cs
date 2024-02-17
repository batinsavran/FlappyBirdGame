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
    public partial class Form1 : Form
    {
        int boruhizi = 10;
        int yercekimi = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += yercekimi;
            block2.Left-=boruhizi;
            block1.Left-=boruhizi;
            scoreText.Text = "" + score;                                 
            if ( block2.Left < -170)
            {
                block2.Left = 400;
            }
            if( block1.Left < -130 )
            {
                block1.Left = 400;  
                score++;
            }
            if (bird.Bounds.IntersectsWith(block2.Bounds) || bird.Bounds.IntersectsWith(block1.Bounds) || bird.Bounds.IntersectsWith(floor.Bounds))
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
            if(e.KeyCode==Keys.Space)
            {
                yercekimi= -10;
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
            gameTimer.Stop();
            scoreText.Text = "Game Over!";
        }

        private void bird_Click(object sender, EventArgs e)
        {
            mainMenu main = new mainMenu();
            main.Show();
            this.Hide();
        }
    }
}
