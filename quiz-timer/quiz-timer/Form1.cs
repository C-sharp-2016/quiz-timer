using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quiz_timer
{
    public partial class form_home1 : Form
    {

        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private int seconds = 0, minutes = 0, hours = 0;
        private string seconds_zero = "", minutes_zero = "", hours_zero = "";
        private Boolean screenShotsCaptured = false;
        private Boolean timer_status = true;
        private int counter = 0;

        
        MySqlConnection conn;
        private string connString;
         
        public form_home1()
        {
            InitializeComponent();

            this.connection();

            this.Hide();

           

        } 

        private void start_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            timer1 = new System.Windows.Forms.Timer();

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Interval = 1000;

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

            if (seconds % 10 == 0)
            {
                Take_Screen_Shots();
            }


            if (seconds > 59)
            {
                minutes++;   
                seconds = 1; 
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

        private void forn_home_Load(object sender, EventArgs e)
        {
           
        }

        private void settings_click(object sender, EventArgs e)
        {
            login_form lf = new login_form();

            lf.Show();

            this.Hide();
        }

        private void Take_Screen_Shots()
        {
            counter++; 
            /*
                SendKeys.Send("{PRTSC}");

                Image img = Clipboard.GetImage();

                img.Save("D:\\testing.jpg"); 
            */ 
            Console.WriteLine(counter + "Take Screen Shots Now.");



            insert();


            //query();


             

        }
        

        private void connection()
        {
            try
            {
                //connString = "SERVER=lifeafterpurchase.com;PORT=3306;DATABASE=twoleos_testing;UID=twoleos_testing;PASSWORD=twoleos_testing;";
                connString = "SERVER=localhost;PORT=3306;DATABASE=csharp_testing1;UID=root;PASSWORD=;";

                conn = new MySqlConnection();

                conn.ConnectionString = connString;

                Console.WriteLine("Successfully Connected To Server");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void query()
        {

            conn.Open();

            string query = "SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Console.Write("| id = " + dataReader["id"]);
                Console.Write("| username = " + dataReader["username"]);
                Console.Write("| password = " + dataReader["password"]);
                Console.Write("| created at = " + dataReader["created_at"]);
                Console.WriteLine("");
            }


            conn.Close();

        }

        private void insert()
        {

            conn.Open();

            string query = "INSERT INTO users (username,password) VALUES ('tom','tompassword')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();


        }
    }
}
