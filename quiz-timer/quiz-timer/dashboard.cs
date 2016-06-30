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






    public partial class dashboard : Form
    {
        
        //Global variables;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


      

        public dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
             
        }

        private void dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }



        private void flatten_button_select(object sender, EventArgs e)
        {

            Button b = (Button)sender;



            System.Drawing.Color OrangeRed = System.Drawing.Color.OrangeRed;
            System.Drawing.Color BlackColor = System.Drawing.Color.Black;


            b0.BackColor = BlackColor;
            b1.BackColor = BlackColor;
            b2.BackColor = BlackColor;
            b3.BackColor = BlackColor;

             
             
            if (b.Text == "Dashboard")
            {
                b0.BackColor = OrangeRed;
            }
            else if (b.Text == "Settings")
            {
                b1.BackColor = OrangeRed;
            }
            else if (b.Text == "Account")
            {
                b2.BackColor = OrangeRed;
            }
            else if (b.Text == "Payment")
            {
                b3.BackColor = OrangeRed;
            }

         

        }
    }
}
