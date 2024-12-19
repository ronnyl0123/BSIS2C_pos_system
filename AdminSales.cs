using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pos_system
{
    public partial class AdminSales : UserControl
    {
        private OleDbConnection con;
        public AdminSales()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            string query = "SELECT DISTINCT ProdCat FROM producttbl";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (DGVprod.SelectedRows.Count > 0)
            {
                var selectedRow = DGVprod.SelectedRows[0];

                // Get the original product name and category from the selected row
                string originalProductName = selectedRow.Cells[0].Value.ToString().Trim(); // Assuming ProdName is in the first column
                string originalCategory = selectedRow.Cells[2].Value.ToString().Trim(); // Assuming ProdCat is in the third column

                // Get the product details from the text boxes
                string productName = txtproduct.Text.Trim();
                int quantity;
                decimal price;

                // Validate quantity and price inputs
                if (!int.TryParse(txtquantity.Text, out quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                if (!decimal.TryParse(txtprice.Text, out price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                // Create the update query
                string updateQuery = "UPDATE producttbl SET ProdQty = @ProdQty, ProdPrice = @ProdPrice, ProdName = @NewProdName WHERE ProdName = @OldProdName AND ProdCat = @ProdCat";

                using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@ProdQty", quantity);
                    cmd.Parameters.AddWithValue("@ProdPrice", price);
                    cmd.Parameters.AddWithValue("@NewProdName", productName);
                    cmd.Parameters.AddWithValue("@OldProdName", originalProductName);
                    cmd.Parameters.AddWithValue("@ProdCat", originalCategory);

                    // Debugging: Log the command text and parameters
                    Console.WriteLine("Executing SQL: " + cmd.CommandText);
                    Console.WriteLine("Parameters:");
                    Console.WriteLine($"@ProdQty: {quantity}");
                    Console.WriteLine($"@ProdPrice: {price}");
                    Console.WriteLine($"@NewProdName: {productName}");
                    Console.WriteLine($"@OldProdName: {originalProductName}");
                    Console.WriteLine($"@ProdCat: {originalCategory}");

                    try
                    {
                        // Open the connection if it's not already open
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.");
                            LoadData(); // Refresh the DataGridView to show updated data
                        }
                        else
                        {
                            MessageBox.Show("No product was updated. Please check the details.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating product: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void AdminSales_Load(object sender, EventArgs e)
        {
            string conString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
            con = new OleDbConnection(conString);
            con.Open();
            LoadCategories();
            LoadData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DGVprod.SelectedRows.Count > 0)
            {
                var selectedRow = DGVprod.SelectedRows[0];

                // Get the product details from the selected row
                string productName = selectedRow.Cells[0].Value.ToString(); // Assuming ProdName is in the first column
                string productCategory = selectedRow.Cells[2].Value.ToString(); // Assuming ProdCat is in the third column
                int productQuantity = Convert.ToInt32(selectedRow.Cells[1].Value); // Assuming ProdQty is an integer
                decimal productPrice = Convert.ToDecimal(selectedRow.Cells[3].Value); // Assuming ProdPrice is a decimal

                // Confirm deletion
                var confirmResult = MessageBox.Show($"Are you sure you want to delete '{productName}'?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
                    {
                        // Start a transaction
                        con.Open();
                        using (var transaction = con.BeginTransaction())
                        {
                            try
                            {
                                // Step 1: Insert the product into deletedtbl with DeletionDate
                                string insertQuery = "INSERT INTO deletedtbl (ProdName, ProdCat, ProdQty, ProdPrice, DeletionDate) VALUES (@ProdName, @ProdCat, @ProdQty, @ProdPrice, @Ddate)";
                                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, con, transaction))
                                {
                                    insertCmd.Parameters.Add("@ProdName", OleDbType.VarChar).Value = productName;
                                    insertCmd.Parameters.Add("@ProdCat", OleDbType.VarChar).Value = productCategory;
                                    insertCmd.Parameters.Add("@ProdQty", OleDbType.Integer).Value = productQuantity; // Use Integer for ProdQty
                                    insertCmd.Parameters.Add("@ProdPrice", OleDbType.Currency).Value = productPrice; // Use Currency for ProdPrice
                                    insertCmd.Parameters.Add("@Ddate", OleDbType.Date).Value = DateTime.Now; // Add current date and time
                                    insertCmd.ExecuteNonQuery();
                                }

                                // Step 2: Delete the product from the original table
                                string deleteQuery = "DELETE FROM producttbl WHERE ProdName = @ProdName AND ProdCat = @ProdCat";
                                using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, con, transaction))
                                {
                                    deleteCmd.Parameters.Add("@ProdName", OleDbType.VarChar).Value = productName;
                                    deleteCmd.Parameters.Add("@ProdCat", OleDbType.VarChar).Value = productCategory;
                                    deleteCmd.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();
                                MessageBox.Show("Product deleted successfully.");
                                LoadData(); // Refresh the DataGridView to show updated data
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of error
                                transaction.Rollback();
                                MessageBox.Show("Error deleting product: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
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
    }
}
