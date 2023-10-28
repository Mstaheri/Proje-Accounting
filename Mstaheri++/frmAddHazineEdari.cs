using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.Func;

namespace Mstaheri__
{
    public partial class frmAddHazineEdari : Form
    {
        CarpetCompanyBLL.classHazineEdari hazine;
        public frmAddHazineEdari()
        {
            InitializeComponent();
            hazine = new CarpetCompanyBLL.classHazineEdari();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txtCodeHazine.Text;
            string shomareHesab = comShomareHesab.Text;
            string namHazine = txtNamHazine.Text;
            string tarikhPardakht = txtTarikhPardakht.Text;
            string price = txtPrice.Text;
            string description = txtTozihat.Text;
            if (this.Text == "Save")
            {
                var check = hazine.Insert(code, shomareHesab, namHazine, tarikhPardakht, price, description);
                if (check.Success == true)
                {
                    MessageBox.Show(check.Message);
                }
                else
                {
                    MessageBox.Show(check.Message, "Error");
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
            else if (this.Text == "Edit")
            {
                var check = hazine.Update(code, shomareHesab, namHazine, tarikhPardakht, price, description);
                if (check.Success == true)
                {
                    MessageBox.Show(check.Message);
                }
                else
                {
                    MessageBox.Show(check.Message, "Error");
                }
                this.Close();
            }
            

        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string harf = CarpetCompanyDAL.NumberToStringConverter.Convert(txtPrice.Text);
            if (txtPrice.Text != "")
            {
                string st = decimal.Parse(txtPrice.Text).ToString("N0");
                toolTip1.SetToolTip(txtPrice, st + "--" + harf);
            }
            else
            {
                toolTip1.SetToolTip(txtPrice, "" + "--" + "");
            }
        }
    }
}
