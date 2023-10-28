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
    public partial class frmAddVarizBeHesab : Form
    {
        CarpetCompanyBLL.varizBeHesabb varizs;
        CarpetCompanyDAL.Mali mal;
        public frmAddVarizBeHesab()
        {
            InitializeComponent();
            varizs = new CarpetCompanyBLL.varizBeHesabb();
            mal = new CarpetCompanyDAL.Mali();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string codeVariz = txtCodeVariz.Text;
            string shomareHesab = comShomareHesab.Text;
            string namHesab = txtNamHesab.Text;
            string namVarizKonande = txtNamVarizKonande.Text;
            string tarikhVarizi = txtTarikhVarizi.Text;
            string tozihat = txtTozihat.Text;
            string Price = txtPrice.Text;
            await Task.Run(() =>
            {
                var check = varizs.Insert(codeVariz, shomareHesab, namHesab, namVarizKonande, tarikhVarizi, tozihat, Price);
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


        private void txtCodeVariz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void frmAddVarizBeHesab_Load(object sender, EventArgs e)
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

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPrice.Text != "")
            {
                if (e.KeyCode == Keys.Add)
                {
                    txtPrice.Text = txtPrice.Text + "000";
                }
            }
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
