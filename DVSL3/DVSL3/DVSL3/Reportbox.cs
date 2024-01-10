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
    public partial class Reportbox : Form
    {
        public Reportbox()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reportbox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == String.Empty || txtmiddlename.Text == String.Empty || txtlastname.Text == String.Empty ||
             cmbgender.Text == String.Empty || txtabout.Text == String.Empty)
            {
                MessageBox.Show("Please Enter all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfirstname.Focus();
                txtmiddlename.Focus();
                txtlastname.Focus();
                cmbgender.Focus();
                txtabout.Focus();
                return;
            }
            else
            {
                MessageBox.Show(" Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clrbtn();
                this.Close();
                frmMain frm = new frmMain();
                frm.ShowDialog();

            }
        }

        private void clrbtn()
        {
            txtfirstname.Clear();
            txtmiddlename.Clear();
            txtlastname.Clear();
            cmbgender.Select();
            txtabout.Clear();
           
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
            frmMain fm = new frmMain();
            fm.Show();

        }
    }
    }

