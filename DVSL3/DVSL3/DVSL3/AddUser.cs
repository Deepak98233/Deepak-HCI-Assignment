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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        int indexRow;

        private void AddUser_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {                       
         if (txtfirstname.Text == String.Empty ||txtlastname.Text == String.Empty || cmbgender.Text == String.Empty || txtphonno.Text == String.Empty || txtaddress.Text == String.Empty || txtin.Text == String.Empty)
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
                dataGridView1.Rows.Add(txtfirstname.Text, txtmiddlename.Text, txtlastname.Text, cmbgender.Text, txtphonno.Text, txtaddress.Text, txtin.Text);
                MessageBox.Show("Admin Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clrbtn();
                }
            }
        
        private void clrbtn()
        {
            txtfirstname.Clear();
            txtmiddlename.Clear();
            txtlastname.Clear();
            txtphonno.Clear();
            txtaddress.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = txtfirstname.Text;
            newDataRow.Cells[1].Value = txtmiddlename.Text;
            newDataRow.Cells[2].Value = txtlastname.Text;
            newDataRow.Cells[3].Value = cmbgender.Text;
            newDataRow.Cells[4].Value = txtphonno.Text;
            newDataRow.Cells[5].Value = txtaddress.Text;
            newDataRow.Cells[6].Value = txtin.Text;
            {
                if (txtfirstname.Text == String.Empty || txtmiddlename.Text == String.Empty || txtlastname.Text == String.Empty ||
                  cmbgender.Text == String.Empty || txtphonno.Text == String.Empty || txtaddress.Text == String.Empty || txtin.Text == String.Empty)
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
                    MessageBox.Show(" Update Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clrbtn();

                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {   
            if(MessageBox.Show("Do You Want To Remove This Row?","Remove Row",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Row Not Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clrbtn();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbgender.SelectedIndex = 1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            txtfirstname.Text = row.Cells[0].Value.ToString();
            txtmiddlename.Text = row.Cells[1].Value.ToString();
            txtlastname.Text = row.Cells[2].Value.ToString();
            cmbgender.Text = row.Cells[3].Value.ToString();
            txtphonno.Text = row.Cells[4].Value.ToString();
            txtaddress.Text = row.Cells[5].Value.ToString();
            txtin.Text = row.Cells[6].Value.ToString();
        }
    }
    }
  