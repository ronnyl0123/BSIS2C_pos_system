using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_system
{
    public partial class TotalSales : Form
    {
        OleDbDataAdapter adapter;
        DataTable dt;
        public TotalSales()
        {
            InitializeComponent();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DashBoard DashForm = new DashBoard();
            DashForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TotalSales tsForm = new TotalSales();
            tsForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CheckStock csForm = new CheckStock();
            csForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the program?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void TotalSales_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM billtbl";

                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
                {
                    con.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        salesDGV.DataSource = dt;

                        // Calculate total sales amount
                        query = "SELECT SUM(BillAmount) AS TotalSales FROM billtbl";

                        using (OleDbCommand sumCmd = new OleDbCommand(query, con))
                        {
                            int totalSales = 0;

                            using (OleDbDataReader reader = sumCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object totalSalesObj = reader["TotalSales"];
                                    if (totalSalesObj != DBNull.Value)
                                    {
                                        totalSales = Convert.ToInt32(totalSalesObj);
                                    }
                                }
                            }

                            Saleslbl.Text = "Total Sales: P" + totalSales;

                            // Calculate daily sales amount
                            query = "SELECT SUM(BillAmount) AS DailySales FROM billtbl WHERE DateValue(BillDate) = Date()";
                            using (OleDbCommand dailySalesCmd = new OleDbCommand(query, con))
                            {
                                int dailySales = 0;

                                using (OleDbDataReader dailyReader = dailySalesCmd.ExecuteReader())
                                {
                                    if (dailyReader.Read() && !dailyReader.IsDBNull(0))
                                    {
                                        dailySales = Convert.ToInt32(dailyReader["DailySales"]);
                                    }
                                }

                                DailySaleslbl.Text = "Daily Sales: P" + dailySales;
                            }
                            query = "SELECT SUM(BillAmount) AS MonthlySales FROM billtbl WHERE DatePart('m', BillDate) = DatePart('m', Date())";

                            using (OleDbCommand monthlySalesCmd = new OleDbCommand(query, con))
                            {
                                int monthlySales = 0;

                                using (OleDbDataReader monthlyReader = monthlySalesCmd.ExecuteReader())
                                {
                                    if (monthlyReader.Read() && !monthlyReader.IsDBNull(0))
                                    {
                                        monthlySales = Convert.ToInt32(monthlyReader["MonthlySales"]);
                                    }
                                }

                                MonthlySaleslbl.Text = "Monthly Sales: P" + monthlySales;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, you can log the exception or show an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void salesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
