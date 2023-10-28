using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mstaheri__
{
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (this.Text == "Edit")
            {
                CarpetCompanyBLL.UpdatAcceess emp = new CarpetCompanyBLL.UpdatAcceess();
                var Check = emp.UpdatAccess(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, label1.Text);
                if (Check.Success == true)
                {
                    MessageBox.Show(Check.Message);
                }
                else
                {
                    MessageBox.Show(Check.Message);
                }
            }
            this.Close();
        }
       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    if (cb.Checked)
                    {
                        button1.Enabled = true;
                        break;
                    }
                    else
                    {
                        button1.Enabled = false;
                    }
                }
            }
        }

        private void Access_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Access_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
