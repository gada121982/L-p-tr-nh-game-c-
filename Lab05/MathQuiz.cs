
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class MathQuiz : Form
    {
        public MathQuiz()
        {
            InitializeComponent();
        }
        int timeleft;
        int calleft1, calright1; 
        int calleft2, calright2;
        int calleft3, calright3;
        int calleft4, calright4;
        int tong, hieu, tich, thuong;


        private void StartQuizbtn_Click(object sender, EventArgs e)
        {


            Random rd = new Random();

            calleft1 = rd.Next(1, 50);
            cal1leftlabel.Text = calleft1.ToString();
            calright1 = rd.Next(1, 50);
            cal1rightlabel.Text = calright1.ToString();

            calleft2 = rd.Next(10, 50);
            cal2leftlabel.Text = calleft2.ToString();
            calright2 = rd.Next(1, 50);
            cal2rightlabel.Text = calright2.ToString();


            calleft3 = rd.Next(1, 10);
            cal3leftlabel.Text = calleft3.ToString();
            calright3 = rd.Next(1, 15);
            cal3rightlabel.Text = calright3.ToString();



            calright4 = rd.Next(1, 20);
            int flag = calright4;
            cal4rightlabel.Text = calright4.ToString();

            calleft4 = rd.Next(1, 15) * flag;
            cal4leftlabel.Text = calleft4.ToString();




            timeleft = 30;
            timecountlabel.Text = timeleft.ToString();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (CheckCaculator())
            {
                timer1.Stop();
                MessageBox.Show("You Win");
                return; 

            }
            if (timeleft == 0 )
            {
                timer1.Stop();
                MessageBox.Show("you lose");
                return; 
            }



             timeleft--;
             timecountlabel.Text = timeleft + "second";
        }
        private bool CheckCaculator()
        {
            if(( calleft1 + calright1 == result1.Value) && (calleft2 - calright2 == result2.Value)
                    && (calleft3 * calright3 == result3.Value) && (calleft4 / calright4 == result4.Value))
            {


                return true;
            }
            else
                return false; 



        }
    }

}

   