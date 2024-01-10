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
    public partial class NST : Form
    {
        public NST()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbgender.SelectedIndex = 0;
        }
        private void New_Student_Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == String.Empty || txtmiddlename.Text == String.Empty || txtlastname.Text == String.Empty ||
              cmbgender.Text == String.Empty || txtphonno.Text == String.Empty || txtaddress.Text == String.Empty)
            {
                MessageBox.Show("Please Enter all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfirstname.Focus();
                txtmiddlename.Focus();
                txtlastname.Focus();
                cmbgender.Focus();
                txtphonno.Focus();
                txtaddress.Focus();
            
                return;
            }
            else
            {
                MessageBox.Show(" Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clrbtn();
                this.Hide();
                frmMain form1 = new frmMain();  
                form1.ShowDialog();

            }
        }

        private void clrbtn()
        {
            txtfirstname.Clear();
            txtmiddlename.Clear();
            txtlastname.Clear();
            cmbgender.Select();
            txtphonno.Clear();
            txtaddress.Clear();
           

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == String.Empty || txtmiddlename.Text == String.Empty || txtlastname.Text == String.Empty ||
              cmbgender.Text == String.Empty || txtphonno.Text == String.Empty || txtaddress.Text == String.Empty || txtdateofbirth.Text == String.Empty)
            {
                MessageBox.Show("Please Enter all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfirstname.Focus();
                txtmiddlename.Focus();
                txtlastname.Focus();
                cmbgender.Focus();
                txtphonno.Focus();
                txtaddress.Focus();
                txtdateofbirth.Focus();
              
                return;
            }
            else
            {
                MessageBox.Show(" Update Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clrbtn();

            }
        }

   

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain(); 
            frm.Show(); 
            
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
    }
