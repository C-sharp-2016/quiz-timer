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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            form_home1 fh = new form_home1();
             
            fh.Show();

            this.Hide();
        }
    }
}
