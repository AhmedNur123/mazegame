using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace WindowsApplicationWithAhmad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You hit the ball game is over","Sorry");
            
        }       

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You won the game.", "Congratulations");
        }
        
    }
}
