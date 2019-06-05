using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace Lab05
{
    public partial class SpineGame : Form
    {
        Random rd = new Random(); 
        public SpineGame()
        {
            InitializeComponent();
        }
        int m;
        int a;
        int b;
        int c;

        public object Conversion { get; private set; }

        private void Button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            lblMsg.Text = " ";
        }

      
   

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = null; 
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m = m + 10;
            if (m < 150)
            {

                a = rd.Next(1, 3); 

                b = rd.Next(1, 3);

                c = rd.Next(1, 3);

                switch (a)
                {
                    case 1:
                        PictureBox1.Image = Image.FromFile("apple.jpg");
                        break;
                    case 2:
                        PictureBox1.Image = Image.FromFile("grapes.jpg");
                        break;
                    case 3:
                        PictureBox1.Image = Image.FromFile("strawberry.jpg");
                        break;

                }

                switch (b)
                {
                    case 1:
                        PictureBox2.Image = Image.FromFile("apple.jpg");
                        break;
                    case 2:
                        PictureBox2.Image = Image.FromFile("grapes.jpg");
                        break;
                    case 3:
                        PictureBox2.Image = Image.FromFile("strawberry.jpg");
                        break;


                }
                switch (c)
                {
                    case 1:
                        PictureBox3.Image = Image.FromFile("apple.jpg");
                        break;
                    case 2:
                        PictureBox3.Image = Image.FromFile("grapes.jpg");
                        break;
                    case 3:
                        PictureBox3.Image = Image.FromFile("strawberry.jpg");
                        break;


                }

            }
            else
            {
                timer1.Stop(); 
                m = 0;
                if (a == b && a == c)
                {
                   

                    lblMsg.Text = "You get full point this lab :v ";
                }
                else
                {
                   
                    lblMsg.Text = "No luck, try again";

                }
            }
		
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}