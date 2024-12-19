using System;
using System.Data;
using System.Data.OleDb; 
using System.Drawing;
using System.IO; 
using System.Windows.Forms;

namespace pos_system
{
    public partial class Register : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public Register()
        {
            InitializeComponent();
        }
        private void GetUsers()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM accuser", con);
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

        private void Register_Load(object sender, EventArgs e)
        {
            GetUsers();
        }


        private void login_lbl_Click(object sender, EventArgs e)
        {
            Admin AdForm = new Admin();
            AdForm.Show();

            this.Hide();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are null
            if (txtfname == null || txtlname == null || txtaddress == null ||
                txtemail == null || txtpnumber == null || txtuser == null ||
                txtpass == null || txtcpass == null || cb_usertype == null)
            {
                MessageBox.Show("One or more input fields are not initialized.");
                return;
            }

            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrWhiteSpace(txtlname.Text) ||
                string.IsNullOrWhiteSpace(txtaddress.Text) || string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtpnumber.Text) || string.IsNullOrWhiteSpace(txtuser.Text) ||
                string.IsNullOrWhiteSpace(txtpass.Text) || string.IsNullOrWhiteSpace(txtcpass.Text) || string.IsNullOrWhiteSpace(cb_usertype.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (txtpass.Text != txtcpass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string query = "INSERT INTO accuser ([FirstName], [LastName], [Address], [Email], [PhoneNumber], [UserName], [Password], [UserType]) " +
                           "VALUES (@fn, @ln, @a, @e, @pn, @u, @p, @ut)"; 
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fn", txtfname.Text);
                    cmd.Parameters.AddWithValue("@ln", txtlname.Text);
                    cmd.Parameters.AddWithValue("@a", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@e", txtemail.Text);
                    cmd.Parameters.AddWithValue("@pn", txtpnumber.Text);
                    cmd.Parameters.AddWithValue("@u", txtuser.Text);
                    cmd.Parameters.AddWithValue("@p", txtpass.Text);
                    cmd.Parameters.AddWithValue("@ut", cb_usertype.Text);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registered Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
            GetUsers();
            ClearTextBoxes();
        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }

        private void cb_usertype_SelectedIndexChanged(object sender, EventArgs e)
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
            DialogResult result = MessageBox.Show("Are you sure you want to close the program?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restore RsForm = new Restore();
            RsForm.Show();

            this.Hide();
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}

