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
    public partial class Form7 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/DB.mdb");



        public Form7()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            //       OleDbDataAdapter adapReport = new OleDbDataAdapter("select bnum as [Bill Number],phonenum as [Phone Number      ],bdate as [Bill Date],bvat as [VAT in (%)],bamount as [Amount in INR],bqty as [Quantity],status as [Bill Status], iscash as [CASH], iscredit as [CREDIT] from PURCHASE  where PURCHASE.phonenum='" + phonenum + "'", con);
            OleDbDataAdapter adapReport = new OleDbDataAdapter("select waiter_id as [ID Number      ],waiter_name as [NAME],contact_number as [contact number] from waiter" + "'", con);
            adapReport.Fill(ds, "waiter");
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "waiter";


            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {

                dataGridView2.Rows[i].Cells[0].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dataGridView2.Rows[i].Cells[1].Style.Font = new Font("Arial", 9, FontStyle.Bold);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
