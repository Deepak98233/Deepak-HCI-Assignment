using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVSL3
{
    public partial class Form1 : Form
    {
       public static string loginname, logintype;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedIndex > 0)
                {
                    if (txtUsername.Text == String.Empty)
                    {
                        MessageBox.Show("Please Enter valid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                        return;
                    }
                    if (txtPass.Text == String.Empty)
                    {
                        MessageBox.Show("Please Enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Focus();
                        return;
                    }

                    if (cmbRole.SelectedIndex > 0 && txtUsername.Text != String.Empty && txtPass.Text != String.Empty)
                    {
                        //login code
                        if (cmbRole.Text == "Admin")
                        {
                            if ((txtUsername.Text.Equals("Admin")) && (txtPass.Text.Equals("12345")))
                            {
                                MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loginname = txtUsername.Text;
                                logintype = cmbRole.Text;
                                clrValue();
                                this.Hide();
                                frmMain fm = new frmMain();
                                fm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Please check userName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else if (cmbRole.Text == "Staff")
                        {

                            if ((txtUsername.Text.Equals("Staff")) && (txtPass.Text.Equals("12345")))
                            {
                                MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loginname = txtUsername.Text;
                                logintype = cmbRole.Text;
                                clrValue();
                                this.Hide();
                                frmMain fm = new frmMain();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Please check userName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clrValue();
                    }

                }
                else
                {
                    MessageBox.Show("Please select any role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clrValue();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void newAccountRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clrValue()
        {
            cmbRole.SelectedIndex = 0;
            txtUsername.Clear();
            txtPass.Clear();
        }
    }
}


   