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
using Microsoft.VisualBasic;

namespace pos_system
{
    public partial class DashBoard : Form
    {
        private DataTable productTable;
        private OleDbConnection myConnToAccess;
        public DashBoard()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.buttonAggregates.Click += new System.EventHandler(this.txtaggre_Click);
            this.buttonCement.Click += new System.EventHandler(this.txtcement_Click);
            this.buttonDeformedBar.Click += new System.EventHandler(this.txtdbar_Click);
            this.buttonElectrical.Click += new System.EventHandler(this.txtelectrical_Click);
            this.buttonPlumbing.Click += new System.EventHandler(this.txtplumbing_Click);
            this.buttonPaints.Click += new System.EventHandler(this.txtpaint_Click);
            this.buttonHardwareTools.Click += new System.EventHandler(this.txthtools_Click);
            LoadProductData();
            pictureBox5.MouseHover += cart_MouseHover;
            pictureBox5.MouseLeave += cart_MouseLeave;
            myConnToAccess = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb");
        }
        
        private void cart_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Text = "Mouse is hovering!";
            pictureBox5.BackColor = Color.PaleGoldenrod;
        }
        private void cart_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Text = "Hover over me";
            pictureBox5.BackColor = Color.Transparent;
        }
        private void InsertIntoBillTable(string billDate, int billAmount)
        {
            string query = "INSERT INTO billtbl ([BillDate], [BillAmount]) " +
                   "VALUES (@bd, @ba)";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bd", billDate);
                    cmd.Parameters.AddWithValue("@ba", billAmount);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void LoadProductData()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
            string query = "SELECT * FROM producttbl"; // Adjust the query as needed

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                productTable = new DataTable(); // Initialize the DataTable

                try
                {
                    connection.Open();
                    adapter.Fill(productTable);
                    dataGridViewProducts.DataSource = productTable; // Bind the DataTable to the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
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
        private void LoadData()
        {
            string myquery = "SELECT * FROM producttbl";
            try
            {
                var ds = op.populate(myquery);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dataGridViewProducts.DataSource = ds.Tables[0];
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
            dataGridViewProducts.AutoGenerateColumns = false; // Disable auto generation of columns

            // Define columns manually
            dataGridViewProducts.Columns.Clear(); // Clear existing columns if any

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdName",
                HeaderText = "Product Name",
                DataPropertyName = "ProdName", // Bind to the data source
                Width = 150
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdQty",
                HeaderText = "Quantity",
                DataPropertyName = "ProdQty",
                Width = 100
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdCat",
                HeaderText = "Category",
                DataPropertyName = "ProdCat",
                Width = 100
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdPrice",
                HeaderText = "Price",
                DataPropertyName = "ProdPrice",
                Width = 100
            });
        }
        private void FilterData(string category)
        {
            DataView view = new DataView(productTable);
            view.RowFilter = $"ProdCat = '{category}'";

            // Bind the filtered data to the DataGridView
            dataGridViewProducts.DataSource = view;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cashier CashForm = new Cashier();
            CashForm.Show();
            this.Hide();
        }
        private void ResetButtonColors()
        {
            buttonHardwareTools.BackColor = Color.Gray; // Reset the back color of all buttons
            buttonPaints.BackColor = Color.Gray;
            buttonPlumbing.BackColor = Color.Gray;
            buttonElectrical.BackColor = Color.Gray;
            buttonDeformedBar.BackColor = Color.Gray;
            buttonCement.BackColor = Color.Gray;
            buttonAggregates.BackColor = Color.Gray;
        }


        private void txthtools_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonHardwareTools.BackColor = Color.DimGray;
            FilterData("HARDWARE TOOLS");
        }
        

        private void txtpaint_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonPaints.BackColor = Color.DimGray;
            FilterData("PAINTS AND PAINTS RELATED");
        }


        private void txtplumbing_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonPlumbing.BackColor = Color.DimGray;
            FilterData("PLUMBING");
        }


        private void txtelectrical_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonElectrical.BackColor = Color.DimGray;
            FilterData("ELECTRICAL");
        }


        private void txtdbar_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonDeformedBar.BackColor = Color.DimGray;
            FilterData("DEFORMED BAR");
        }


        private void txtcement_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonCement.BackColor = Color.DimGray;
            FilterData("CEMENT");
        }


        private void txtaggre_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            buttonAggregates.BackColor = Color.DimGray;
            FilterData("AGGREGATES");
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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
            TotalSales tsForm = new TotalSales();
            tsForm.Show();
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGVprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            DashBoard DashForm = new DashBoard();
            DashForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            TotalSales tsForm = new TotalSales();
            tsForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            CheckStock csForm = new CheckStock();
            csForm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
        
        int GrdTotal = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string dashline = ("_________________________________________________________________________________________________________________________________");
            e.Graphics.DrawString("UNI ONE HARDWARE", new Font("Arial", 24, FontStyle.Bold), Brushes.Black, new Point(140, 5));
            e.Graphics.DrawString("Lot 33 Blk 6 Capitol View Park Subdivision", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(155, 55));
            e.Graphics.DrawString("Bulihan, Malolos City", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(225, 85));
            e.Graphics.DrawString("0925-6269579/0917-853400", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(210, 115));
            e.Graphics.DrawString("unionehardware@gmail.com", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(202, 145));

            if (comboBox1.SelectedItem != null)
            {
                string comboBox = comboBox1.SelectedItem.ToString();
                e.Graphics.DrawString(comboBox, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(15, 340));

                if (comboBox == "DELIVER")
                {
                    if (!string.IsNullOrWhiteSpace(deliveryAddress)) // Assuming 'deliveryAddress' is where you store the entered address
                    {
                        e.Graphics.DrawString("Delivery Address: " + deliveryAddress, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, 340));
                    }
                }
            }
            Random random = new Random();
            string transactionNumber = random.Next(10000000, 99999999).ToString();
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                con.Open();

                // Query to retrieve the FirstName of a user with UserType "User" from the accuser table
                string query = "SELECT FirstName FROM accuser WHERE UserType = 'User'";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    string userFirstName = cmd.ExecuteScalar()?.ToString();

                    // Display the FirstName of the user with UserType "User" as "Cashier"
                    e.Graphics.DrawString("Cashier: " + userFirstName, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(15, 280));
                }
            }
            e.Graphics.DrawString("Transaction Number: " + transactionNumber, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(15, 300));
            e.Graphics.DrawString("Date/Time"+DateTime.Now, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(15, 320));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 350));

            e.Graphics.DrawString("PRODUCT", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(15, 375));
            e.Graphics.DrawString("QUANTITY", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(300, 375));
            e.Graphics.DrawString("PRICE", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(400, 375));
            e.Graphics.DrawString("TOTAL", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(525, 375));

            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 385));
            int pos = 415;
            foreach (DataGridViewRow row in billDGV.Rows)
            {
                string prodname = "" + row.Cells["Column2"].Value;
                int prodqty = Convert.ToInt32(row.Cells["Column3"].Value);
                int prodprice = Convert.ToInt32(row.Cells["Column4"].Value);
                int total = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + prodname, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(15, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(400, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(300, pos));
                e.Graphics.DrawString("" + total, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(525, pos));

                pos += 25;
            }
            e.Graphics.DrawString("Total: P" + GrdTotal, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(490, pos + 25));
            e.Graphics.DrawString("Payment Amount: P" + Paymenttxt.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(415, pos + 50));
            e.Graphics.DrawString("Change: P" + (Convert.ToInt32(Paymenttxt.Text) - GrdTotal), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(475, pos + 75));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 950));
            e.Graphics.DrawString("THANK YOU, PLEASE COME AGAIN!", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(190, 975));
            string billDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int billAmount = GrdTotal;

            InsertIntoBillTable(billDateTime, billAmount);

            billDGV.Rows.Clear();
            billDGV.Refresh();
            GrdTotal = 0;
        }
        private string deliveryAddress;
        private void btnPayment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to print the receipt now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (billDGV.Rows.Count > 1)
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        if (comboBox1.SelectedItem.ToString() == "DELIVER")
                        {
                            deliveryAddress = Interaction.InputBox("Please enter the delivery address:", "Address Input");

                            if (string.IsNullOrWhiteSpace(deliveryAddress))
                            {
                                MessageBox.Show("Address is required for delivery. Please enter the address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }

                        printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 625, 1000);

                        if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        {
                            printDocument1.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an item from the ComboBox before printing.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data available for printing.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Amtlbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product before adding to cart.");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];
            string productName = selectedRow.Cells["ProdName"].Value.ToString();
            int price = Convert.ToInt32(selectedRow.Cells["ProdPrice"].Value);
            
            int quantity;
            if (!int.TryParse(Interaction.InputBox("Enter the quantity for " + productName + ":", "Enter Quantity", "1"), out quantity))
            {
                MessageBox.Show("Invalid quantity entered.");
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.");
                return;
            }

            int total = quantity * price;

            // Update quantity in producttbl
            string query = "UPDATE producttbl SET ProdQty = ProdQty - @quantity WHERE ProdName = @productName";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@productName", productName);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating quantity in database: " + ex.Message);
                    }
                }
            }

            // Add product to cart
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(billDGV);

            newRow.Cells[0].Value = productName;
            newRow.Cells[2].Value = quantity;
            newRow.Cells[1].Value = price;
            newRow.Cells[3].Value = total;

            billDGV.Rows.Add(newRow);
            GrdTotal += total;
            Amtlbl.Text = "P" + GrdTotal;
            RefreshDataGridView();

            Paymenttxt.TextChanged += (s, args) =>
            {
                int paymentAmount;
                if (!int.TryParse(Paymenttxt.Text, out paymentAmount))
                {
                    Changelbl.Text = "Invalid payment amount";
                    return;
                }

                int totalAmount = GrdTotal;

                if (paymentAmount < totalAmount)
                {
                    Changelbl.Text = "Insufficient payment amount";
                    return;
                }

                int change = paymentAmount - totalAmount;

                Changelbl.Text = "P" + change;
            };
            
        }

        private void Header_Enter(object sender, EventArgs e)
        {

        }

        private void billDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM producttbl", myConnToAccess))
                {
                    adapter.Fill(dt);
                }
                dataGridViewProducts.DataSource = dt; // Bind the updated data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void voidItemButton_Click(object sender, EventArgs e)
        {
            for (int i = billDGV.SelectedRows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow item = billDGV.SelectedRows[i];
                if (item.Index != -1 && item.Index < billDGV.Rows.Count)
                {
                    DataGridViewRow selectedRow = billDGV.Rows[item.Index];
                    try
                    {
                        string itemName = selectedRow.Cells["Column2"].Value.ToString();
                        int quantity = Convert.ToInt32(selectedRow.Cells["Column4"].Value);
                        int price = Convert.ToInt32(selectedRow.Cells["Column5"].Value);

                        // Calculate the new total
                        int GrdTotal;
                        if (int.TryParse(Amtlbl.Text.Replace("P", ""), out GrdTotal)) // Remove "P" for parsing
                        {
                            Amtlbl.Text = "P" + (GrdTotal - (quantity * price)).ToString();
                        }
                        
                        // Confirm removal
                        DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Update the database
                            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                connection.Open();
                                string query = "UPDATE producttbl SET ProdQty = ProdQty + @quantity WHERE ProdName = @itemName";
                                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@quantity", quantity);
                                    cmd.Parameters.AddWithValue("@itemName", itemName);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Remove the item from the DataGridView
                            billDGV.Rows.RemoveAt(item.Index);

                            // Refresh the DataGridView to show updated product quantities
                            RefreshDataGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
