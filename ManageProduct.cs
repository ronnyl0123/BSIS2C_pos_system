using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_system
{
    public partial class ManageProduct : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataAdapter adapter;
        private DataTable dt;

        public ManageProduct()
        {
            InitializeComponent();
        }

        private void GetUsers()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM producttbl", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtproduct.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            if (cbcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // Declare variables at the beginning
            int quantity;
            decimal price;

            // Validate quantity
            if (!int.TryParse(txtquantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Validate price
            if (!decimal.TryParse(txtprice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtsupplier.Text))
            {
                MessageBox.Show("Please enter a supplier.");
                return;
            }
            string query = "INSERT INTO producttbl ([ProdName], [ProdQty], [ProdCat], [ProdPrice], [Supplier]) " +
                           "VALUES (@pn, @pq, @pc, @pp, @ss)";

            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pn", txtproduct.Text);
                    cmd.Parameters.AddWithValue("@pq", quantity); // Use the validated quantity
                    cmd.Parameters.AddWithValue("@pc", cbcategory.Text);
                    cmd.Parameters.AddWithValue("@pp", price);
                    cmd.Parameters.AddWithValue("@ss", txtsupplier.Text);// Use the validated price

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
            ClearTextBoxes();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
        
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin AdForm = new Admin();
            AdForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnaddacc_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            RegisterForm.Show();

            this.Hide();
        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {
            ManageProduct mpForm = new ManageProduct();
            mpForm.Show();
            this.Close();
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            ManageStock msForm = new ManageStock();
            msForm.Show();

            this.Hide();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restore RsForm = new Restore();
            RsForm.Show();

            this.Hide();
        }
    }
}
