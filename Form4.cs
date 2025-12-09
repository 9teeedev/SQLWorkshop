using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp104
{
    public partial class Form4 : Form
    {
        BindingSource bs;
        public Form4()
        {
            InitializeComponent();
        }
        void ShowCounty()
        {
            SqlConnection conn = dbconnection.Nortwind_conn();

            string sql = "SELECT Distinct Country FROM Customers Order By Country";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCountry.DataSource = dt;
            cboCountry.DisplayMember = "Country";
            cboCountry.ValueMember = "Country";
            conn.Close();
        }
        void showCustomers(String country)
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            if (country == "")
            {
                cmd.CommandText = "SELECT * FROM Customers";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM Customers WHERE Country=@Country";
                cmd.Parameters.AddWithValue("@Country", country);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            bs = new BindingSource();
            bs.DataSource = dt;
            conn.Close();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bs, "CustomerID");
            txtCompany.DataBindings.Clear();
            txtCompany.DataBindings.Add("Text", bs, "CompanyName");
            txtContact.DataBindings.Clear();
            txtContact.DataBindings.Add("Text", bs, "ContactName");
            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", bs, "ContactTitle");
            ShowPosition();
        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowPosition()
        {
            lbRecord.Text = "รายการที่ : " + (bs.Position + 1).ToString() + " / " + bs.Count.ToString();
            ShowOrder();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            ShowCounty();
            showCustomers("");
            ShowPosition();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showCustomers(cboCountry.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showCustomers("");
        }



        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            ShowPosition();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            ShowPosition();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            ShowPosition();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            ShowPosition();
        }

        void ShowOrder()
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Customer_Order";
            cmd.Parameters.AddWithValue("@cid", SqlDbType.NChar).Value = txtID.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();

            dgvResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResult.Columns[1].DefaultCellStyle.Format = "#,##0.00";
        }
    }
}
