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
using System.Net;
using System.IO;
using System.Management;
using System.Diagnostics;

namespace TimerAppWinForms
{
    public partial class Form1 : Form
    {
        
        private const string Caption = "Running on database";
        private static readonly Timer Timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            Timer.Tick += TimerEventProcessor;
            Timer.Interval = 5000;
            Timer.Start();
        }
        
        //FOR SHUT DOWN PC
        private void Form1_Load(object sender, EventArgs e)
        {
            //var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            //psi.CreateNoWindow = true;
            //psi.UseShellExecute = false;
            //Process.Start(psi);

            
            
        }

        //FOR COPY FILE FROM ONE DESTINATION AND PEST ANOTHER
        public void readfiles()
        {
            Timer.Stop();
            Timer.Start();
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "Your servername";
            string database = "Your database";
            string uid = "Your uid";
            string password = "Your password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SSL Mode=None ";
            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select MAX(id) from tbl_filepath";
            cmd.Connection = connection;
            int i = 0;
            i = Convert.ToInt32(cmd.ExecuteScalar());
            MySqlDataAdapter da = new MySqlDataAdapter("Select FilePath from tbl_filepath where Id = '" + i + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string path = null;
            if (dt.Rows.Count > 0)
            {
                path = dt.Rows[0][0].ToString();
            }

            string sourceFile = path;
            string destinationFile= "c:\\filepest\\"; 
            try
            {
                File.Copy(sourceFile, destinationFile + Path.GetFileName(sourceFile));
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);

            }
        }


        //TO MOVE FILE FROM ONE PLACE TO ANOTHER
        public void movefiles()
        {
            Timer.Stop();
            Timer.Start();
            MySql.Data.MySqlClient.MySqlConnection connection;
             string server = "Your servername";
            string database = "Your database";
            string uid = "Your uid";
            string password = "Your password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SSL Mode=None ";
            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select MAX(id) from tbl_filepath";
            cmd.Connection = connection;
            int i = 0;
            i = Convert.ToInt32(cmd.ExecuteScalar());

            MySqlDataAdapter da = new MySqlDataAdapter("Select FilePath from tbl_filepath where Id = '" + i + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string path = null;
            if (dt.Rows.Count > 0)
            {
                path = dt.Rows[0][0].ToString();

                
            }

            string sourceFile = path;
            string destinationFile = "E:\\filemove\\";
            int i1 = Convert.ToInt32(i);
            try
            {

                File.Move(sourceFile, destinationFile + Path.GetFileName(sourceFile));
                

            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);

            }
        }



        private static void TimerEventProcessor(object myObject, EventArgs myEventArgs)
        {

            Timer.Stop();

            Timer.Start();
            MySql.Data.MySqlClient.MySqlConnection connection;
             string server = "Your servername";
            string database = "Your database";
            string uid = "Your uid";
            string password = "Your password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SSL Mode=None ";
            connection = new MySqlConnection(connectionString);
            connection.Open();

        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "Select MAX(id) from tbl_filepath";
            cmd.Connection = connection;
            int i = 0;
        i = Convert.ToInt32(cmd.ExecuteScalar());

            MySqlDataAdapter da = new MySqlDataAdapter("Select FilePath from tbl_filepath where Id = '" + i + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
           string path = null;
            if (dt.Rows.Count > 0)
            {
               path = dt.Rows[0][0].ToString();
            }
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select Status from tbl_filepath where Id = '" + i + "'", connection);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            string status = null;
            if (dt1.Rows.Count > 0)
            {
                status = dt1.Rows[0][0].ToString();
            }
            if (status == "fileopen")
            {
                System.Diagnostics.Process p = System.Diagnostics.Process.Start(path);
                p.WaitForInputIdle();
              
                WebClient client = new WebClient();
                String countrycode = "91";
                String Number = "Your Number";
                String number = countrycode + Number;
                String Sms = "Your file is open at path :- " + path;

                string fullUrl = "http://whatsapi.smsinsta.com/api/send-text?number=" + number + "&msg=" + Sms + "&apikey=c6f1c8f502d550f2bda5f2a2c5e8ee5e8fe8d45877aef24c83a4195572c885f7&instance=173b63947dafdfb4edc95c23fe39c389091be2f342bb8941731b82eaf2a89f10";

                Stream data = client.OpenRead(fullUrl);
                StreamReader reader = new StreamReader(data);
                string ResponseID = reader.ReadToEnd();

                Form1 obj = new Form1();
                obj.readfiles();

                Form1 obj1 = new Form1();
                obj1.movefiles();
            }
            else
            {
                //System.Diagnostics.Process p = System.Diagnostics.Process.Start(path);
                //p.WaitForInputIdle();
                //File.Delete(path);
                WebClient client = new WebClient();
                String countrycode = "91";
                String Number = "9370459867";
                String number = countrycode + Number;
                String Sms = "Your file is delete from path :- " + path;

                string fullUrl = "Your Whatsapp API Here";


                Stream data = client.OpenRead(fullUrl);


                StreamReader reader = new StreamReader(data);
                string ResponseID = reader.ReadToEnd();

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "Delete from tbl_filepath where Id = '" + i + "'";
                cmd1.Connection = connection;
                cmd1.ExecuteNonQuery();
                File.Delete(path);      
            }
        }      
    }
}

