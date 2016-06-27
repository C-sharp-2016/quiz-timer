using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace quiz_timer
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private int seconds = 0, minutes = 0, hours = 0;
        private string seconds_zero = "", minutes_zero = "", hours_zero = "";
        private Boolean screenShotsCaptured = false;
        private Boolean timer_status = true;
        private int counter = 0;




        public Form1()
        {
            InitializeComponent();
        } 

        private void start_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            timer1 = new System.Windows.Forms.Timer();

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Interval = 10;

            b.Enabled = false;

            stop.Enabled = true;

            timer1.Start();
        }

        private void stop_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            start.Enabled = true;

            b.Enabled = false;

            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            seconds++; 
            
            if (seconds > 59)
            {
                minutes++;   
                seconds = 1;

                if (minutes % 10 == 0)
                {
                    Take_Screen_Shots();
                } 

            } 
            if (minutes > 59)
            { 
                hours++;
                minutes = 1; 
            }
               
            if (seconds.ToString().Length == 1)
            {
                seconds_zero = "0"; 
            }
            else
            {
                seconds_zero = "";
            } 

            if (minutes.ToString().Length == 1)
            {
                minutes_zero = "0";
            }
            else
            {
                minutes_zero = "";
            }
             
            if (hours.ToString().Length == 1)
            {
                hours_zero = "0";
            }
            else
            {
                hours_zero = "";
            } 

            secs.Text = seconds_zero + seconds.ToString();
            mins.Text = minutes_zero + minutes.ToString();
            hrs.Text  = hours_zero + hours.ToString(); 
        }
         
        private void Take_Screen_Shots()
        {

            counter++;
             
            SendKeys.Send("{PRTSC}");

            Image img = Clipboard.GetImage();

            img.Save("D:\\imagetest/"+ counter  + "captured_name.jpg");
             
            Console.WriteLine("Take Screen Shots Now.");
        }

    }
}
