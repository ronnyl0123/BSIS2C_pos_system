using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_system
{

    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            RegisterForm.Show();

            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManageProduct mpForm = new ManageProduct();
            mpForm.Show();
            this.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageStock msForm = new ManageStock();
            msForm.Show();

            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void adminSales1_Load(object sender, EventArgs e)
        {

        }

        private Form currentForm = null;
        private Register rgForm = null;
        private ManageProduct mgForm = null;
        private ManageStock msForm = null;
        private Restore rForm = null;

        private void btnaddacc_Click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            rgForm = new Register();
            rgForm.FormClosed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            };
            rgForm.Show();

            currentForm = rgForm;
        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            mgForm = new ManageProduct();
            mgForm.FormClosed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            };
            mgForm.Show();

            currentForm = mgForm;
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            msForm = new ManageStock();
            msForm.FormClosed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            };
            msForm.Show();

            currentForm = msForm;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            rForm = new Restore();
            rForm.FormClosed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            };
            rForm.Show();

            currentForm = rForm;
        }
        private TotalSales tsForm = null;
        private void tsalespb_Click(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            tsForm = new TotalSales();
            tsForm.FormClosed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            };
            tsForm.Show();

            currentForm = tsForm;
        }
        private CheckStock csForm = null;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            csForm = new CheckStock();
            csForm.FormClosed += (s, args) => {
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            };
            csForm.Show();

            currentForm = csForm;
        }
    }
}
