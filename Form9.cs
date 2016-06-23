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
    public partial class Form9 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");
           
       
        public Form9()
        {
           
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

                con.Open();
                //OleDbCommand top = new OleDbCommand(
       // "UPDATE item SET price = '" + textBox2.Text +"' WHERE item_name = " + textBox1.Text +con);
                //"UPDATE TABLE item set price ='+'int32.parse(TextBox2.Txt) '+' WHERE item_name ='" + textBox1.Text +","+con);
                //top.ExecuteNonQuery();

                string str2 = "UPDATE item set price ='" + Int32.Parse(textBox2.Text) + "' where item_name  ='" + textBox1.Text + "'";
                System.Data.OleDb.OleDbCommand cmd2 = new System.Data.OleDb.OleDbCommand(str2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
