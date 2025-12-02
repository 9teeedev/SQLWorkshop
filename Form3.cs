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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cboCategory.SelectedValue);
            if (cid == 0) ShowProducts();
            else ShowProducts(cid);
        }
        // show category in Combobox
        void showCategory()
        {
            SqlConnection conn = dbconnection.Nortwind_conn();

            string sql = "SELECT CategoryID, CategoryName From Categories Order By CategoryName ASC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
            conn.Close();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "All Categorys";
            dt.Rows.Add(row);

            cboCategory.SelectedIndex = cboCategory.Items.Count - 1;
            ShowProducts();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        void ShowProducts(int cid)
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            string sql = "SELECT * FROM Products WHERE CategoryID = @categoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryID", cid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCategory.DataSource = dt;
            conn.Close();
        }
        void ShowProducts()
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            string sql = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCategory.DataSource = dt;
            conn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            showCategory();
        }
    }
}
