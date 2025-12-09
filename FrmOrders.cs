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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }
        void ShowYear()
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            string sql = "SELECT DISTINCT YEAR(OrderDate) AS OrderYear FROM Orders Order By OrderYear DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "OrderYear";
            cboYear.ValueMember = "OrderYear";
            conn.Close();
        }
        void ShowOrderByYear(int year)
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            string sql = "SELECT OrderID, OrderDate, CustomerID, ShipCountry, EmployeeID FROM Orders WHERE YEAR(OrderDate) = @orderYear";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderYear", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrders.DataSource = dt;
            conn.Close();

        }
        private void FrmOrders_Load(object sender, EventArgs e)
        {
            ShowYear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(cboYear.SelectedValue);
            ShowOrderByYear(year);
        }

        // Show Order Detail
        void ShowOrderDetail(int OrderID)
        {
            SqlConnection conn = dbconnection.Nortwind_conn();
            //string sql = "SELECT OrderID, OD.ProductID, ProductName, CategoryName, OD.UnitPrice, OD.Quantity, (OD.UnitPrice * OD.Quantity) AS TotalPrice, (OD.UnitPrice * OD.Quantity * (1 - OD.Discount)) AS PriceAfterDiscount FROM [Order Details] OD INNER JOIN Products P ON OD.ProductID = P.ProductID INNER JOIN Categories C ON P.CategoryID = C.CategoryID WHERE OrderID = @OrderID;";
            SqlCommand cmd = new SqlCommand("sp_OrderDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderID", OrderID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrderDetail.DataSource = dt;
            conn.Close();

        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrders.Rows[rowIndex].Cells["OrderID"].Value);
            ShowOrderDetail(orderID);
        }
    }
}
