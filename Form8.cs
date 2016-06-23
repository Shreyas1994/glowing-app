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
    public partial class Form8 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                con.Open();
                 string str2 = "DELETE FROM item  where item_name  ='" + textBox1.Text + "'";
                System.Data.OleDb.OleDbCommand cmd2 = new System.Data.OleDb.OleDbCommand(str2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                this.Close();
                
              con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
