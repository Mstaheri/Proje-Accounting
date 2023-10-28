using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mstaheri__
{
    public partial class frmAddEditEmployee : Form
    {
        public frmAddEditEmployee()
        {
            InitializeComponent();
        }
        public bool Rate1 { get; set; }
        public bool Rate2 { get; set; }
        public bool Rate3 { get; set; }
        public bool Rate4 { get; set; }
        public bool Rate5 { get; set; }

        //Employee emp = new Employee(); 
        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = nameEmployee.Text;
            string LastName = lastEmployee.Text;
            string PhoneNumber = PhoneEmployee.Text;
            string UserName = userEmployee.Text;
            string Password = passwordEmployee.Text;
            string Jobs = jobsEmployee.Text;
            if (this.Text == "Save")
            {
                CarpetCompanyBLL.Employee emp = new CarpetCompanyBLL.Employee();
                var Check = emp.Insert(FirstName, LastName, PhoneNumber, UserName, Password, Jobs,Rate1,Rate2,Rate3,Rate4,Rate5);
                if (Check.Success == true)
                {
                    MessageBox.Show(Check.Message);
                }
                else
                {
                    MessageBox.Show(Check.Message);
                }
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;
                        txt.Text = "";
                    }
                }
            }
            if (this.Text == "Edit")
            {
                CarpetCompanyBLL.Employee emp = new CarpetCompanyBLL.Employee();
                var Check = emp.Updat(FirstName, LastName, PhoneNumber, UserName, Password, Jobs);
                if (Check.Success == true)
                {
                    MessageBox.Show(Check.Message);
                }
                else
                {
                    MessageBox.Show(Check.Message);
                }
            }

        }

        private void PhoneEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void PhoneEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jobsEmployee.Text == "حسابدار")
            {
                Access ac = new Access();
                ac.label1.Visible = false;
                ac.ShowDialog();
                Rate1 = ac.checkBox1.Checked;
                Rate2 = ac.checkBox2.Checked;
                Rate3 = ac.checkBox3.Checked;
                Rate4 = ac.checkBox4.Checked;
                Rate5 = ac.checkBox5.Checked;
            }
            else if (jobsEmployee.Text == "")
            {
                MessageBox.Show("اطلاعات شغل را کامل پر کنید");
            }
            else
            {
                MessageBox.Show("شغل مورد نظر وجود ندارد");
            }
        }
       

        private void FrmAddEditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void passwordEmployee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
