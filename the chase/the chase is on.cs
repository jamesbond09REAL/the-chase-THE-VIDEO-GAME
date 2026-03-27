using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_chase
{
    public partial class the_chase_is_on : Form
    {
        public the_chase_is_on()
        {
            InitializeComponent();
        }
        static public double ourchasermulti = Form1.chasermulti;
        public void endgameW()
        {
            timer1.Enabled = false;
            MessageBox.Show("win");
            Application.Exit();
        }
        public void endgameL()
        {
            timer1.Enabled = false;
            MessageBox.Show("Lost");
            Application.Exit();
        }
        static public double five = 5;
        static public double ten = 10;
        static public int round5 = 0;
        static public int round10 = 0;
        public void chasermove()
        {
            Random rnd3 = new Random();
            switch (Form1.selected_chaser)
            {
                case 1:

                    thebeastimage.Location = new Point((thebeastimage.Location.X + rnd3.Next(round5,round10)),138);
                    if(thebeastimage.Location.X >= bradleywalshplayer.Location.X)
                    {
                        endgameL();
                    }
                    break;
                case 2:
                    thedarkdestroyerimage.Location = new Point(thedarkdestroyerimage.Location.X + rnd3.Next(round5, round10), 138);
                    if (thedarkdestroyerimage.Location.X >= bradleywalshplayer.Location.X)
                    {
                        endgameL();
                    }
                    break;
                case 3:
                    thegoverness.Location = new Point(thegoverness.Location.X + rnd3.Next(round5, round10), 138);
                    if (thegoverness.Location.X >= bradleywalshplayer.Location.X)
                    {
                        endgameL();
                    }
                    break;
                case 4:
                    thesinnermanimage.Location = new Point(thesinnermanimage.Location.X + rnd3.Next(round5, round10), 138);
                    if (thesinnermanimage.Location.X >= bradleywalshplayer.Location.X)
                    {
                        endgameL();
                    }
                    break;
                case 5:
                    thevixenbutton.Location = new Point(thevixenbutton.Location.X + rnd3.Next(round5, round10), 138);
                    if (thevixenbutton.Location.X >= bradleywalshplayer.Location.X)
                    {
                        endgameL();
                    }
                    break;
                case 6:
                    themenacebutton.Location = new Point(themenacebutton.Location.X + rnd3.Next(round5, round10), 138);
                    if (themenacebutton.Location.X >= bradleywalshplayer.Location.X)
                    {
                        endgameL();
                    }
                    break;

            }
        }
        private void the_chase_is_on_Load(object sender, EventArgs e)
        {
            
            int highoffer = 0;
            int normaloffer = 0;
            int lowoffer = 0;
            Random rnd = new Random();
            highoffer = rnd.Next(cashbuilder.cash + 1000, cashbuilder.cash + 10000);
            normaloffer = cashbuilder.cash;
            lowoffer = rnd.Next(cashbuilder.cash - 10000, cashbuilder.cash - 1000);
            button1.Text = $"{highoffer}";
            button2.Text = $"{normaloffer}";
            button3.Text = $"{lowoffer}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            ourchasermulti = ourchasermulti * 1.25;
            round5 = Convert.ToInt32(Math.Ceiling(five * ourchasermulti));
            round10 = Convert.ToInt32(Math.Ceiling(ten * ourchasermulti));
            

            bradleywalshplayer.Visible = true;
            switch (Form1.selected_chaser)
            {
                case 1:

                    thebeastimage.Visible = true;
                    break;
                case 2:
                    thedarkdestroyerimage.Visible = true;
                    break;
                case 3:
                    thegoverness.Visible = true;
                    break;
                case 4:
                    thesinnermanimage.Visible = true;
                    break;
                case 5:
                    thevixenbutton.Visible = true;
                    break;
                case 6:
                    themenacebutton.Visible = true;
                    break;

            }
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ourchasermulti = ourchasermulti;
            round5 = Convert.ToInt32(Math.Ceiling(five * ourchasermulti));
            round10 = Convert.ToInt32(Math.Ceiling(ten * ourchasermulti));
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            
            bradleywalshplayer.Visible = true;
            switch (Form1.selected_chaser)
            {
                case 1:

                    thebeastimage.Visible = true;
                    break;
                case 2:
                    thedarkdestroyerimage.Visible = true;
                    break;
                case 3:
                    thegoverness.Visible = true;
                    break;
                case 4:
                    thesinnermanimage.Visible = true;
                    break;
                case 5:
                    thevixenbutton.Visible = true;
                    break;
                case 6:
                    themenacebutton.Visible = true;
                    break;

            }
            timer1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ourchasermulti = ourchasermulti * 0.75;
            round5 = Convert.ToInt32(Math.Ceiling(five * ourchasermulti));
            round10 = Convert.ToInt32(Math.Ceiling(ten * ourchasermulti));
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            
            bradleywalshplayer.Visible = true;
            switch (Form1.selected_chaser)
            {
                case 1:

                    thebeastimage.Visible = true;
                    break;
                case 2:
                    thedarkdestroyerimage.Visible = true;
                    break;
                case 3:
                    thegoverness.Visible = true;
                    break;
                case 4:
                    thesinnermanimage.Visible = true;
                    break;
                case 5:
                    thevixenbutton.Visible = true;
                    break;
                case 6:
                    themenacebutton.Visible = true;
                    break;

            }
            timer1.Enabled = true;

        }

        private void bradleywalshplayer_Click(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            bradleywalshplayer.Location = new Point((bradleywalshplayer.Location.X + rnd2.Next(2, 7)), 140);
            if (bradleywalshplayer.Location.X >= 608)
            {
                endgameW();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chasermove();
            
        }
    }
}
