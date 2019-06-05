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
    public partial class MatchGame : Form
    {
       
        Label firstClicked = null;

        Label secondClicked = null;

       
        Random random = new Random();

       
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

      
      
        private void AssignIconsToSquares()
        {
          
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                
                Label iconLabel = control as Label; 
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }


        public MatchGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
            
        }

       
        private void label_Click(object sender, EventArgs e)
        {
           
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
               
                if (clickedLabel.ForeColor == Color.Black)
                  
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

             
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

           
                CheckForWinner();

            
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

             
                timer1.Start();
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

       
        private void CheckForWinner()
        {
           
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

          
            MessageBox.Show("You matched all the icons!", "Congratulations!");
            Close();
        }

    }
}
