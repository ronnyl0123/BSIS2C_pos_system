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
    public partial class Restore : Form
    {
        private OleDbConnection con;
        private OleDbDataAdapter adapter;
        private DataTable dt;
        public Restore()
        {
            InitializeComponent();
            LoadDeletedProducts();
        }
        private void RestoreProduct(string productName, string productCategory, int productQuantity, decimal productPrice, DateTime currentDateTime)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                con.Open();

                // Start a transaction
                using (var transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Insert the product into producttbl with the current date and time
                        string insertQuery = "INSERT INTO producttbl (ProdName, ProdCat, ProdQty, ProdPrice, RestorationDate) VALUES (@ProdName, @ProdCat, @ProdQty, @ProdPrice, @AddedDate)";
                        using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, con, transaction))
                        {
                            insertCmd.Parameters.Add("@ProdName", OleDbType.VarChar).Value = productName;
                            insertCmd.Parameters.Add("@ProdCat", OleDbType.VarChar).Value = productCategory;
                            insertCmd.Parameters.Add("@ProdQty", OleDbType.Integer).Value = productQuantity;
                            insertCmd.Parameters.Add("@ProdPrice", OleDbType.Currency).Value = productPrice;
                            insertCmd.Parameters.Add("@AddedDate", OleDbType.Date).Value = currentDateTime; // Add current date and time
                            insertCmd.ExecuteNonQuery();
                        }

                        // Step 2: Delete the product from the deletedtbl
                        string deleteQuery = "DELETE FROM deletedtbl WHERE ProdName = @ProdName AND ProdCat = @ProdCat AND AddedDate = @AddedDate";
                        using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, con, transaction))
                        {
                            deleteCmd.Parameters.Add("@ProdName", OleDbType.VarChar).Value = productName;
                            deleteCmd.Parameters.Add("@ProdCat", OleDbType.VarChar).Value = productCategory;
                            deleteCmd.Parameters.Add("@AddedDate", OleDbType.Date).Value = currentDateTime; // Add current date and time
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of error
                        transaction.Rollback();
                        MessageBox.Show("Error restoring product: " + ex.Message);
                    }
                }
            }
        }
        public DataTable GetDeletedProducts()
        {
            DataTable deletedProducts = new DataTable();
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
                {
                    string query = "SELECT * FROM deletedtbl";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        con.Open();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            adapter.Fill(deletedProducts);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving deleted products: " + ex.Message);
                // Optionally log the error or handle it as needed
            }
            return deletedProducts;
        }
        private void LoadDeletedProducts()
        {
            DataTable deletedProducts = GetDeletedProducts();
            DGVprod.DataSource = deletedProducts;
        }

        
        private void LoadCategories()
        {
            string query = "SELECT DISTINCT ProdCat FROM deletedtbl";
            OleDbCommand command = new OleDbCommand(query, con);

            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                cbcategory.Items.Clear();

                while (reader.Read())
                {
                    cbcategory.Items.Add(reader["ProdCat"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }
        private void GetUsers()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM deletedtbl", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();
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
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = -1; // Clear the ComboBox selection
                    }
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void Restore_Load(object sender, EventArgs e)
        {
            string conString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
            con = new OleDbConnection(conString);
            con.Open();
            LoadCategories();
            
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

        private void DGVprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVprod.SelectedRows.Count > 0)
            {
                var selectedRow = DGVprod.SelectedRows[0];

                txtproduct.Text = selectedRow.Cells[0].Value.ToString(); // Product Name
                txtquantity.Text = selectedRow.Cells[1].Value.ToString(); // Quantity
                txtprice.Text = selectedRow.Cells[3].Value.ToString(); // Price

                // Populate the ComboBox
                string category = selectedRow.Cells[2].Value.ToString(); // Category

                // Check if the category exists in the ComboBox
                if (cbcategory.Items.Contains(category))
                {
                    cbcategory.SelectedItem = category; // Set the selected item if it exists
                }
                else
                {
                    cbcategory.SelectedIndex = -1; // Clear selection if the category is not found
                }
            }
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            ManageStock msForm = new ManageStock();
            msForm.Show();

            this.Hide();
        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {
            ManageProduct mpForm = new ManageProduct();
            mpForm.Show();
            this.Close();
        }

        private void btnaddacc_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            RegisterForm.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restore RsForm = new Restore();
            RsForm.Show();

            this.Hide();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (DGVprod.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVprod.SelectedRows)
                {
                    // Assuming you have a unique identifier for the product, e.g., ProductId
                    string productName = row.Cells["ProdName"].Value.ToString();
                    string productCategory = row.Cells["ProdCat"].Value.ToString();
                    int productQuantity = Convert.ToInt32(row.Cells["ProdQty"].Value);
                    decimal productPrice = Convert.ToDecimal(row.Cells["ProdPrice"].Value);

                    // Get the current date and time
                    DateTime currentDateTime = DateTime.Now;

                    // Call RestoreProduct with the current date and time
                    RestoreProduct(productName, productCategory, productQuantity, productPrice, currentDateTime);
                }

                // Reload the deleted products after restoration
                LoadDeletedProducts();
                MessageBox.Show("Selected products restored successfully.");
            }
            else
            {
                MessageBox.Show("Please select a product to restore.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin AdForm = new Admin();
            AdForm.Show();

            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
