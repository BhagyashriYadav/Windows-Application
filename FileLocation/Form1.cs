using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace File_Location
{
    public partial class Form1 : Form
    {
        Process file = new Process();
       
       

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = Process.Start(OpenFileDialog.FileName);
                textBox1.Text = OpenFileDialog.FileName;
            }


            //show only txt file
            // OpenFileDialog OpenFileDialog = new OpenFileDialog();
            //if(OpenFileDialog.ShowDialog()==DialogResult.OK)
            // {
            //   String text = File.ReadAllText(OpenFileDialog.FileName);
            //   richTextBox1.Text = text;
            //  textBox1.Text = OpenFileDialog.FileName;

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {

                textBox1.Text = fbd.FileName;
            }
        }
        
        
        private void status_Click(object sender, EventArgs e)
        {
           

            string filepath = textBox1.Text;
           
            try
            {
                using (Stream stream = new FileStream(textBox1.Text, FileMode.Open))
                {

                    MessageBox.Show("file is open");
                }
            }
            catch
            {
                MessageBox.Show("file not open");
            }


            
            //string filepath = textBox1.Text;
            //if(File.Exists(filepath))
            //{
            //    MessageBox.Show("file exist");
            //}
            //else
            //{
            //    MessageBox.Show("not exist");
            //}
        }

       

        private void delete_Click(object sender, EventArgs e)
        {

           
            string filepath = textBox1.Text;
            if(File.Exists(filepath))
            {
                File.Delete(filepath);
                MessageBox.Show("file deleted");
            }
            else
            {
               
            }
            textBox1.Clear();
        }
    }
    
}
