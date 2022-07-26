using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        int RandomNumber;
        bool Win = false;
        string s;
        int i;
        string Number;
        int FailedAttemps = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomNumber = R.Next(0, 100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            i = Convert.ToInt32(s);
            label3.Visible = true;
            if (i > RandomNumber)
            {
                label3.Text = "To High! Guess Lower Number";
                FailedAttemps++;
                textBox1.Clear();
            }
            else if (i < RandomNumber)
            {
                label3.Text = "To Low! Guess Higher Number";
                FailedAttemps++;
                textBox1.Clear();
            }
            else if (i == RandomNumber)
            {
                FailedAttemps++;
                label3.Text = "You Guess The Right Number in '" + FailedAttemps + "' Attemps";
            }
        }
    }
}
