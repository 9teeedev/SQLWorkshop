using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp104
{
    public partial class Form2 : Form
    {
        string ConnectionString = "Data Source=ADM403-24\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True; Encrypt=False";
        public Form2()
        {
            InitializeComponent();
        }

        //แสดงข้อมูลลูกค้าทั้งหมด
        void showAllCusomers()
        {
            //สร้าง Object ของการเชื่อมต่อฐานข้อมูล
            SqlConnection conn = new SqlConnection
              (ConnectionString);
            conn.Open();
            //สร้างคำสั่ง SQL
            string sql = "SELECT * FROM Customers";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable(); //สร้างตารางจำลอง
            da.Fill(dt); //นำข้อมูลจากฐานข้อมูลใส่ลงในตารางจำลอง

            dgvResult.DataSource = dt; //แสดงข้อมูลบน DataGridView
            conn.Close();
        }
        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showAllCusomers();
            ShowCustomers();
        }
        void ShowCustomers()
            
        {
                SqlConnection conn = new SqlConnection(ConnectionString);
        conn.Open();

                string sql = "SELECT * FROM Customers WHERE Country = @Country";
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", conn);
        DataTable dt = new DataTable();
        da.Fill(dt);

                cboCountry.DataSource = dt;
                cboCountry.DisplayMember = "Country";
                cboCountry.ValueMember = "Country";
                conn.Close();
            }
}
}
