using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVSL3
{
    public partial class Shedule : Form
    {
        public Shedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
           
           
                if (txtfirstname.Text == String.Empty || txtsurname.Text == String.Empty || txtlession.Text == String.Empty ||
                 txtdate.Text == String.Empty || txtaddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfirstname.Focus();
                    txtsurname.Focus();
                    txtlession.Focus();
                    txtdate.Focus();
                    txtaddress.Focus();
                    return;
                }
                else
                {
                    dataGridView1.Rows.Add(txtsurname.Text, txtfirstname.Text, txtaddress.Text, txtlession.Text, txtdate.Text);
                    MessageBox.Show(" Booked Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clrbtn();
            

                }

            }
       

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMain frm =new frmMain();
            frm.ShowDialog();
            this.Hide();
        }

        private void Shedule_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void clrbtn()
        {
            txtfirstname.Clear();
            txtsurname.Clear();
            txtdate.Select();
            txtaddress.Clear();     
        }
    }
}
