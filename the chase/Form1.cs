using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_chase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int selected_chaser = 0;
        public static double chasermulti = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            yci.Visible = true;
            Random rnd = new Random();
            
            selected_chaser = rnd.Next(1, 6);
            whichtext.Visible = true;
            switch (selected_chaser)
            {
                case 1:
                    whichtext.Text = "THE BEAST";
                    thebeastimage.Visible = true;
                    chasermulti = 1.3;
                    break;
                case 2:
                    whichtext.Text = "THE DARK DESTROYER";
                    thedarkdestroyerimage.Visible = true;
                    chasermulti = 1.1;
                    break;
                case 3:
                    whichtext.Text = "THE GOVERNESS";
                    thegoverness.Visible = true;
                    chasermulti = 1.6;
                    break;
                case 4:
                    whichtext.Text = "THE SINNERMAN";
                    thesinnermanimage.Visible = true;
                    chasermulti = 1.4;
                    break;
                case 5:
                    whichtext.Text = "THE VIXEN";
                    thevixenbutton.Visible = true;
                    chasermulti = 1.5;  
                    break;
                case 6:
                    whichtext.Text = "THE MENACE";
                    themenacebutton.Visible = true;
                    chasermulti = 1.2;
                    break;

            }
            int j = 0;
            button2.Visible = true;
            
            
        }


        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashbuilder chase = new cashbuilder();
            chase.Show();
            this.Hide();
        }
    }
}
