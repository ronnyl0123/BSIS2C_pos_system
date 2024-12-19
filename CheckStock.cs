using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pos_system
{
    public partial class CheckStock : Form
    {
        private OleDbConnection con;
        public CheckStock()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        public class op
        {
            public static DataSet populate(string query)
            {
                DataSet ds = new DataSet();
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            con.Open();
                            da.Fill(ds);
                        }
                    }
                }
                return ds;
            }
        }

        private void LoadData()
        {
            string myquery = "SELECT * FROM producttbl";
            try
            {
                var ds = op.populate(myquery);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DGVprod.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No data found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InitializeDataGridView()
        {
            DGVprod.AutoGenerateColumns = false; // Disable auto generation of columns

            // Define columns manually
            DGVprod.Columns.Clear(); // Clear existing columns if any

            DGVprod.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdName",
                HeaderText = "Product Name",
                DataPropertyName = "ProdName", // Bind to the data source
                Width = 150
            });

            DGVprod.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdQty",
                HeaderText = "Quantity",
                DataPropertyName = "ProdQty",
                Width = 100
            });

            DGVprod.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdCat",
                HeaderText = "Category",
                DataPropertyName = "ProdCat",
                Width = 100
            });

            DGVprod.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdPrice",
                HeaderText = "Price",
                DataPropertyName = "ProdPrice",
                Width = 100
            });
            DGVprod.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Supplier",
                HeaderText = "Supplier",
                DataPropertyName = "Supplier",
                Width = 100
            });
        }

        private void DGVprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed
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

        private void CheckStock_Load(object sender, EventArgs e)
        {
            string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
            con = new OleDbConnection(conString);
            try
            {
                con.Open();
                LoadData(); // Load data into DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Ensure the connection is closed
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
