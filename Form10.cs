using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");

        public Form10()
        {
           
            InitializeComponent();
            label3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            DataSet ds = new DataSet();
            OleDbDataAdapter aadapReport = new OleDbDataAdapter("select item_name as [Item Name],price as [price in INR] from item" + "'", con);
            aadapReport.Fill(ds, "item");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "item";


            
        }   
           
        

        private void dataGrid2_Navigate(object sender, NavigateEventArgs ne)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridview2(object sender, EventArgs e)
        {
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt16(dataGridView1.CurrentRow.Index);
            string s = Convert.ToString(dataGridView1.Rows[m].Cells[0].Value);
            string x = Convert.ToString(dataGridView1.Rows[m].Cells[1].Value);
            string q = Convert.ToString(textBox1.Text);
           

           
            Decimal mn = Convert.ToDecimal(x);
            Decimal v = Convert.ToDecimal(q);
           Decimal price = ( mn * v);
            dataGridView2.Columns.Add("item", "ITEM");
            dataGridView2.Columns.Add("price", "PRICE");
            dataGridView2.Columns.Add("qty", "QTY");
            dataGridView2.Columns.Add("total", "TOTAL");
            string[] row1 = new string[] { s.ToString(),x.ToString(),q.ToString(),price.ToString() };

            dataGridView1.Rows.Add(row1);




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
