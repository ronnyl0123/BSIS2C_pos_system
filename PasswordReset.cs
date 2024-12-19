using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;


namespace pos_system
{
    public partial class PasswordReset : Form
    {

        string OTPCode;
        public static string to;

        OleDbConnection con;
        OleDbDataAdapter adapter;
        DataTable dt;

        public PasswordReset()
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
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();

            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please fill in the field");
                return;
            }

            using (con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Balagbag.accdb"))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM accuser WHERE Email = ?", con))
                {
                    cmd.Parameters.AddWithValue("?", txt_email.Text);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Email is not correct");
                            return;
                        }
                    }
                }
            }

            // Generate a 6-digit OTP
            OTPCode = new Random().Next(100000, 999999).ToString();

            // Prepare the email
            string from = "ronnyldapedran0117@gmail.com";
            string pass = "wxst hvzr elnn tuwu"; // Use App Password if 2FA is enabled

            MailMessage message = new MailMessage();
            message.To.Add(txt_email.Text);
            message.From = new MailAddress(from);
            message.Subject = "Galing sa System n'yo!";
            message.Body = "Here's your verification code: " + OTPCode + "\n" + "\n" +
               "You are verifying your email address.\n" +
               "KUPAL!";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from, pass)
            };

            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification code sent");

                // Now pass the OTP to the VerifyPass form
                VerifyPass VerifyForm = new VerifyPass(OTPCode);
                VerifyForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }

            ClearTextBoxes();
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {
            GetUsers();
        }
    }
}
