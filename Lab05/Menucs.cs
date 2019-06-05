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
    public partial class Menucs : Form
    {
        public Menucs()
        {
            InitializeComponent();
        }

        private void spinegameBtn_Click(object sender, EventArgs e)
        {
            SpineGame spn = new SpineGame();
            spn.Show(); 
        }

        private void matchgamebtn_Click(object sender, EventArgs e)
        {
            MatchGame matchg = new MatchGame(); 
            matchg.Show();

        }

        private void quizmathBtn_Click(object sender, EventArgs e)
        {
            MathQuiz mathq = new MathQuiz();
            mathq.Show(); 
        }
    }
}
