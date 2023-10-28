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
    public partial class frmAddMali : Form
    {
        CarpetCompanyBLL.Mali mal;
        public frmAddMali()
        {
            InitializeComponent();
            mal = new CarpetCompanyBLL.Mali();
        }

       
        private void frmAddMali_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.Text == "Save")
            {
                string shomareHesab = txtShomareHesab.Text;
                string sahebHesab = txtSahebHesab.Text;
                string namHesab = txtNamHesab.Text;
                string namBank = txtNamBank.Text;
                string mojodi = txtMojodi.Text;
                string tozihat = txtTozihat.Text;
                await Task.Run(() =>
                {
                    var Check = mal.Insert(shomareHesab, sahebHesab, namHesab, namBank, tozihat, mojodi);
                    if (Check.Success == true)
                    {
                        MessageBox.Show(Check.Message);
                    }
                    else
                    {
                        MessageBox.Show(Check.Message);
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
                string shomareHesab = txtShomareHesab.Text;
                string sahebHesab = txtSahebHesab.Text;
                string namHesab = txtNamHesab.Text;
                string namBank = txtNamBank.Text;
                string mojodi = txtMojodi.Text;
                string tozihat = txtTozihat.Text;
                await Task.Run(() =>
                {
                    CarpetCompanyBLL.Mali mal = new CarpetCompanyBLL.Mali();
                    var Check = mal.Update(shomareHesab, sahebHesab, namHesab, namBank, tozihat, mojodi);
                    if (Check.Success == true)
                    {
                        MessageBox.Show(Check.Message);
                    }
                    else
                    {
                        MessageBox.Show(Check.Message);
                    }
                });
                this.Close();
                
            }
            


        }

        private void txtMojodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMojodi_TextChanged(object sender, EventArgs e)
        {
            string harf = CarpetCompanyDAL.NumberToStringConverter.Convert(txtMojodi.Text);
            if (txtMojodi.Text != "")
            {
                string st = decimal.Parse(txtMojodi.Text).ToString("N0");
                toolTip1.SetToolTip(txtMojodi, st + "--" + harf);
            }
            else
            {
                toolTip1.SetToolTip(txtMojodi, "" + "--" + "");
            }
        }

        private void txtMojodi_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
