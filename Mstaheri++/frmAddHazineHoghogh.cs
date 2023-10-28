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
    public partial class frmAddHazineHoghogh : Form
    {
        CarpetCompanyBLL.HoghoghKarmandan HK;
        public frmAddHazineHoghogh()
        {
            InitializeComponent();
            HK = new CarpetCompanyBLL.HoghoghKarmandan();
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

        private async void button1_Click(object sender, EventArgs e)
        {
            string codeHoghogh = txtCodeHoghogh.Text;
            string shomareHesab = comShomareHesab.Text;
            string nam = txtNam.Text;
            string tarikh = txtTarikhPardakht.Text;
            string noaHoghogh = txtNoaHoghogh.Text;
            string price = txtPrice.Text;
            string tozihat = txtTozihat.Text;
            if (this.Text == "Save")
            {
                await Task.Run(() =>
                {
                    var check = HK.Insert(codeHoghogh, shomareHesab, nam, tarikh, noaHoghogh,price, tozihat);
                    if (check.Success == true)
                    {
                        MessageBox.Show(check.Message);
                    }
                    else
                    {
                        MessageBox.Show(check.Message);
                    }
                });
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
                await Task.Run(() =>
                {
                    var check = HK.update(codeHoghogh, shomareHesab, nam, tarikh, noaHoghogh, price, tozihat);
                    if (check.Success == true)
                    {
                        MessageBox.Show(check.Message);
                    }
                    else
                    {
                        MessageBox.Show(check.Message);
                    }
                });
                this.Close();
            }

        }

        private void txtCodeHoghogh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
