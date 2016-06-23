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
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:DB.mdb");

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean b = Convert.ToBoolean(textBox3.Text);
     
                con.Open();
                OleDbCommand top = new OleDbCommand(
        "INSERT INTO item (" +
                "item_name,price,veg" +
            ") VALUES (?,?,?)", con);
                top.Parameters.AddWithValue("?",itext.Text);
                top.Parameters.AddWithValue("?",ptext.Text);
                top.Parameters.AddWithValue("?",b);
               

                top.ExecuteNonQuery();

               // Form obj = new Form6();
               this.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form obj = new Form6();
            this.Close();
        }
    }
}
