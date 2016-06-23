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
    public partial class Form16 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");
        public Form16()
        {
            InitializeComponent();
            label3.Visible=false;
            textBox1.Visible=false;
            button2.Visible=false;
                
            DataSet ds = new DataSet();
            OleDbDataAdapter aadapReport = new OleDbDataAdapter("select item_name as [Item Name],price as [price in INR] from item" + "'", con);
            aadapReport.Fill(ds, "item");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "item";


            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                dataGridView1.Rows[i].Cells[0].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dataGridView1.Rows[i].Cells[1].Style.Font = new Font("Arial", 9, FontStyle.Bold);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Visible=true;
            textBox1.Visible=true;
            button2.Visible=true;
               
            }

        private void button2_Click(object sender, EventArgs e)
        {
            
         int m = Convert.ToInt16(dataGridView1.CurrentRow.Index);
                string s = Convert.ToString(dataGridView1.Rows[m].Cells[0].Value);
                int x = Convert.ToInt16(dataGridView1.Rows[m].Cells[1].Value);


                try
                {
                    con.Open();




                    OleDbCommand top = new OleDbCommand(
            "INSERT INTO served (" +
                    "table_no,item_name,time_of_serving,qty,w_id" +
                ") VALUES (?,?,?,?,?)", con);
                    top.Parameters.AddWithValue("?", "AC6");
                    top.Parameters.AddWithValue("?", s);
                    top.Parameters.AddWithValue("?", DateTime.Now.ToString());
                    top.Parameters.AddWithValue("?",Convert.ToInt32(textBox1.Text));
                    top.Parameters.AddWithValue("?", 7);
                    top.ExecuteNonQuery();

                    // Form obj = new Form6();
                    //this.Close();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }



                OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");
                con1.Open();
                DataSet dse = new DataSet();
                OleDbDataAdapter adapReport = new OleDbDataAdapter("select item_name as [Item Name],qty as [QTY],w_id as [w_id] from served where table_no ='AC6'", con1);
                adapReport.Fill(dse, "served");
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dse;
                dataGridView2.DataMember = "served";


                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {

                    dataGridView2.Rows[i].Cells[0].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView2.Rows[i].Cells[1].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView2.Rows[i].Cells[2].Style.Font = new Font("Arial", 9, FontStyle.Bold);

                }
                con1.Close();
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


