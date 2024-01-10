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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void frmMain_Load_2(object sender, EventArgs e)
        {
            if (Form1.loginname != null)
            {
                toolStripStatusLabel2.Text = Form1.loginname;
            }
            if (Form1.logintype != null && Form1.logintype == "Student")
            {
                addUserToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.ForeColor = Color.Red;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser fad = new AddUser();
            fad.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void timetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shedule S = new Shedule();
            S.Show();
           
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportbox Reportbox = new Reportbox();
            Reportbox.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NST NST = new NST();
            NST.Show();
            this.Hide();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }
    }
}

