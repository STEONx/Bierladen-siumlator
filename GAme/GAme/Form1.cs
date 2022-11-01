using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void left_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X < 338 && 314 < pictureBox2.Location.X)
            {
                explosion();
                if (pictureBox1.Location.Y > 200 && 360 > pictureBox1.Location.Y)
                {
                    score++;
                    

                }
                else
                {
                    endGame(score);

                }
            }
            if (pictureBox2.Location.X > 0)
            {
                
                newX = pictureBox2.Location.X - dX;
                pictureBox2.Location = new Point(newX, pictureBox2.Location.Y);


            }
            else 
            {
                pictureBox2.Location = new Point(1110, 194);


            }
            
            


        }
        int newY = 0;
        int newX = 0;
        int dY = 43;
        int dYd = 10;
        int dX = 20;
        int score = 0;
        private void allahuakbar()
        {
            SoundPlayer jump = new SoundPlayer("jump.wav");
            jump.Play();




        }


        private async void explosion()
        {
            SoundPlayer allah = new SoundPlayer("cannon.wav");
            allah.Play();
        }
        private async void end()
        {
            SoundPlayer allahh = new SoundPlayer("alla.wav");
            allahh.Play();
        }

        private async void  up_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Location.X < 338 && 314 < pictureBox3.Location.X)
            {
                explosion();
                if (pictureBox1.Location.Y > 105 && 230 > pictureBox1.Location.Y)
                {
                    score++;
                    

                }
                else
                {
                    endGame(score);

                }

            }
            
            if (pictureBox3.Location.X > 0)
            {
                newX = pictureBox3.Location.X - dX;
                pictureBox3.Location = new Point(newX, pictureBox3.Location.Y);


            }
            else 
            {
                pictureBox3.Location = new Point(1377, 80);


            }
            




        }
        private void endGame(int scoree)
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            end();
            up.Stop();
            left.Stop();
            
            down.Stop(); // stop the main timer
            label4.Text = $"Allah-Score:{scoree.ToString()}";
            label1.Text = $"You have failed Allah!"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
        }

        private void right_Tick(object sender, EventArgs e)
        {

        }
        

        private void down_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < this.Height-110)
            {
                newY = pictureBox1.Location.Y + dYd;
                pictureBox1.Location = new Point(pictureBox1.Location.X, newY);


            }
            else
            {
                endGame(score);

            }
            

        }

        private void entetys_Tick(object sender, EventArgs e)
        {

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            label3.Text = "0";
            pictureBox2.Location = new Point(1110, 194);
            pictureBox3.Location = new Point(1377, 80);


            up.Stop();
            left.Stop();

            down.Stop();
            score = 0;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = score.ToString();
            up.Start();
            left.Start();
            down.Start();
            if (pictureBox1.Location.Y > 0)
            {
                newY = pictureBox1.Location.Y - dY;
                pictureBox1.Location = new Point(pictureBox1.Location.X, newY);


            }
            allahuakbar();

        }
    }
}
