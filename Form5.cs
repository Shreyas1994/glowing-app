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
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");

        public Form5()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            OleDbDataAdapter adapReport = new OleDbDataAdapter("select item_name as [Item Name],price as [price in INR] from item" + "'", con);
            adapReport.Fill(ds, "item");
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

            
        }
    }
}
