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
    public partial class frmAddPardakhtAzHesab : Form
    {
        CarpetCompanyBLL.pardakhtHesab pardakhti;
        CarpetCompanyDAL.Mali mal;
        public frmAddPardakhtAzHesab()
        {
            InitializeComponent();
            pardakhti = new CarpetCompanyBLL.pardakhtHesab();
            mal = new CarpetCompanyDAL.Mali();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string codePardakht = txtCodePardakht.Text;
            string shomareHesab = comShomareHesab.Text;
            string namHesab = txtNamHesab.Text;
            string namPardakhtKonande = txtNamPardakhtKonande.Text;
            string tarikhPardakht = txtTarikhPardakht.Text;
            string price = txtPrice.Text;
            string tozihat = txtTozihat.Text;
            await Task.Run(() =>
            {
                var check = pardakhti.Insert(codePardakht, shomareHesab, namHesab, namPardakhtKonande, tarikhPardakht, tozihat, price);
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

        
        private void txtCodePardakht_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void frmAddPardakhtAzHesab_Load(object sender, EventArgs e)
        {

        }

        private void comShomareHesab_SelectedIndexChanged(object sender, EventArgs e)
        {
            var check = mal.SelectNamHesab(comShomareHesab.Text);
            if (check.Success == true)
            {
                txtNamHesab.Text = check.Data;
            }
            else
            {
                MessageBox.Show(check.Message);
            }
        }
    }
}
