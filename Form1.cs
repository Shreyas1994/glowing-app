using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "user")
            {
                if (textBox1.Text == "pass")
                {

                    
                    Form obj = new form3();
                    obj.Show();

                }

           
                 

               

                
                else
                    MessageBox.Show("Invalid Password");

            }
            if (textBox2.Text != "user")
            {
                MessageBox.Show("INVALID USER NAME ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox1(object sender, KeyEventArgs e)
        {

        }
    }
}