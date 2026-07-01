using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_chase
{
    public partial class cashbuilder : Form
    {
        public cashbuilder()
        {
            InitializeComponent();
        }
        static public int cash = 0;
        static public int time = 15;
        private void cashbuilder_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guessnum = 0;
            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            Random rnd = new Random();
            guessnum = rnd.Next(1, 6);
            if(guessnum == 1)
            {
                cash = cash + 1000;
                textBox2.Text = $"CASH: {cash}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guessnum = 0;
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            Random rnd = new Random();
            guessnum = rnd.Next(1, 6);
            if (guessnum == 3)
            {
                cash = cash + 1000;
                textBox2.Text = $"CASH: {cash}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int guessnum = 0;
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            Random rnd = new Random();
            guessnum = rnd.Next(1, 6);
            if (guessnum == 6)
            {
                cash = cash + 1000;
                textBox2.Text = $"CASH: {cash}";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            
            if (time <= 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Visible = true;
                textBox4.Visible = false;
            }
            else
            {
                textBox3.Text = $"TIME: {time}";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            the_chase_is_on chase2 = new the_chase_is_on();
            chase2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Visible = false;
        }
    }
}
