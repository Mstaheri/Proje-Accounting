
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mstaheri__
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarpetCompanyBLL.SearchUserAndPasswordAndJobs UPJ = new CarpetCompanyBLL.SearchUserAndPasswordAndJobs();
            string user = textBox1.Text;
            string passWord = textBox2.Text;
            string jobs = comboBox1.Text;
            var search = UPJ.UserSearch(user,passWord,jobs);
            if (search.Success == false)
            {
                MessageBox.Show(search.Message);
            }
            else
            {
                var sath1 = search.Data.Rows[0][6];
                var sath2 = search.Data.Rows[0][7];
                var sath3 = search.Data.Rows[0][8];
                var sath4 = search.Data.Rows[0][9];
                var sath5 = search.Data.Rows[0][10];
                SearchJobs(search.Jobs,(bool)sath1, (bool)sath2, (bool)sath3, (bool)sath4, (bool)sath5);
                
            }
            
        }
        public void SearchJobs(string jobs,bool sath1, bool sath2, bool sath3,
            bool sath4, bool sath5)
        {
            if (jobs == "مدیر عامل")
            {
                CEO frm = new CEO();
                MessageBox.Show("خوش امدید CEO");
                frm.ShowDialog();
            }
            if (jobs == "حسابدار")
            {
                Hesabdar frm = new Hesabdar();
                MessageBox.Show("خوش امدید Accountants");
                frm.groupBox1.Enabled = sath1;
                frm.groupBox2.Enabled = sath2;
                frm.groupBox3.Enabled = sath3;
                frm.groupBox6.Enabled = sath4;
                frm.groupBox5.Enabled = sath5;
                frm.ShowDialog();
            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = (char)0;
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
