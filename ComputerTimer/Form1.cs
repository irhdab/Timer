using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerTimer
{
    public partial class Form1 : Form
    {
        int hour;
        int min;
        int sec;

        string hourstring;
        string minstring;
        string secstring;
        string time = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;

            if(sec == 59)
            {
                sec = 0;
                min++;
            }
            if(min == 59)
            {
                min = 0;
                hour++;
            }

            secstring = sec.ToString();
            minstring = min.ToString();
            hourstring = hour.ToString();

            if (sec < 10)
            {
                if(min < 10)
                {
                    if(hour > 10)
                    {
                        time = "0" + hourstring + ":0" + minstring + ":0" + secstring;
                    }
                    time = hourstring + ":0" + minstring + ":0" + secstring;
                }
                time = hourstring + ":" + minstring + ":0" + secstring;
            }
            if (min < 10)
            {
                if (hour > 10)
                {
                    time = "0" + hourstring + ":0" + minstring + ":0" + secstring;
                }
                time = hourstring + ":0" + minstring + ":0" + secstring;
            }
            if (hour > 10)
            {
                time = "0" + hourstring + ":0" + minstring + ":0" + secstring;
            }


            time = hourstring + ":" + minstring + ":" + secstring;


            label1.Text = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
