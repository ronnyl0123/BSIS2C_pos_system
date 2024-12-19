using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pos_system
{
    public partial class ResetPass : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;

        public ResetPass()
        {
            InitializeComponent();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // Validate that the new password and confirmation password match
            if (string.IsNullOrWhiteSpace(txt_npass.Text) || string.IsNullOrWhiteSpace(txt_cpass.Text))
            {
                MessageBox.Show("Please fill in both password fields.");
                return;
            }

            if (txt_npass.Text != txt_cpass.Text)
            {
                MessageBox.Show("New password and confirmation password do not match.");
                return;
            }

            // Connect to the database
            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                try
                {
                    con.Open();
                    string userEmail = "ronnyldapedran0117@gmail.com"; // Replace with the actual user's email

                    // Check if the user exists
                    string checkQuery = "SELECT COUNT(*) FROM [accuser] WHERE [Email] = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("?", userEmail);
                        int userCount = (int)checkCmd.ExecuteScalar();
                        if (userCount == 0)
                        {
                            MessageBox.Show("User  not found.");
                            return;
                        }
                    }

                    // Prepare the SQL command to update the password
                    string query = "UPDATE [accuser] SET [Password] = ? WHERE [Email] = ?";
                    using (cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("?", txt_npass.Text);
                        cmd.Parameters.AddWithValue("?", userEmail); // Use the actual user's email

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            LoginKanaUlit lku = new LoginKanaUlit();
                            lku.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: User not found or password not updated.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {

        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            txt_npass.UseSystemPasswordChar = false;
            txt_cpass.UseSystemPasswordChar = false;
            btnHide.BringToFront();
        }

        private void btnToggle1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txt_npass.UseSystemPasswordChar = true;
            txt_cpass.UseSystemPasswordChar = true;
            btnToggle.BringToFront();

        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
