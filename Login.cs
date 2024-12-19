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
    public partial class Login : Form
    {
        public static string username;
        private OleDbConnection con = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\rezel\Documents\Visual Studio 2015\Projects\pos_system\pos_system\bin\Debug\Balagbag.accdb";
        }
        private void GetUsers()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb");
            con.Open();
            con.Close();

        }
        public static class UserSession
        {
            public static string FirstName { get; set; }
            public static string LoggedInCashierID { get; set; }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
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

        private void create_acc_Click(object sender, EventArgs e)
        {
            
        }

        private void forgot_pass_Click(object sender, EventArgs e)
        {
            PasswordReset ResetForm = new PasswordReset();
            ResetForm.Show();

            this.Hide();
        }
        
        private void btn_pass_Click(object sender, EventArgs e)
        {
            username = txt_user.Text;
            if (string.IsNullOrWhiteSpace(txt_user.Text) || string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT AccuserID, UserType FROM accuser WHERE UserName = @username AND Password = @password";
                cmd.Parameters.AddWithValue("@username", txt_user.Text);
                cmd.Parameters.AddWithValue("@password", txt_pass.Text);

                // Execute the command and retrieve the user type and cashier ID
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve the AccuserID and UserType
                    UserSession.LoggedInCashierID = reader["AccuserID"].ToString();
                    string userType = reader["UserType"].ToString(); // Ensure the column name is correct

                    if (userType == "Admin")
                    {
                        // Open Admin form
                        Admin adminForm = new Admin();
                        adminForm.Show();
                    }
                    else
                    {
                        // Open User form (Cashier)
                        Cashier userForm = new Cashier();
                        userForm.Show();
                    }
                    this.Hide(); // Hide the login form
                }
                else
                {
                    MessageBox.Show("Username and password are not correct.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
            btnHide.BringToFront();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
            btnToggle.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
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
    }
}
