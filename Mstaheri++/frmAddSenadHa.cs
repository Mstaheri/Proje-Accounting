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
    public partial class frmAddSenadHa : Form
    {
        CarpetCompanyBLL.classSenads senads;
        public frmAddSenadHa()
        {
            InitializeComponent();
            senads = new CarpetCompanyBLL.classSenads();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddHesabHa hesab = new frmAddHesabHa();
            hesab.ShowDialog();
            txtKol.Text = hesab.CodeKolSelect;
            txtMoin.Text = hesab.CodeMoinSelect;
            txtTafsili.Text = hesab.CodeTafsiriSelect;
            lblNamHesab.Text = hesab.OnvanKolSelect +"-"+ hesab.OnvanMoinSelect + "-"+ hesab.OnvanTafsiriSelect;

        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            string harf = CarpetCompanyDAL.NumberToStringConverter.Convert(box.Text);
            if (box.Text != "")
            {
                string st = decimal.Parse(box.Text).ToString("N0");
                toolTip1.SetToolTip(box, st + "--" + harf);
            }
            else
            {
                toolTip1.SetToolTip(box, "" + "--" + "");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string shomareSenad = txtShomareSenad.Text;
            string codeKol = txtKol.Text;
            string codeMoein = txtMoin.Text;
            string codeTafsili = txtTafsili.Text;
            string namHesab = lblNamHesab.Text;
            string sharheSenad = txtSharheSenad.Text;
            string tarikhSenad = txtTarikh.Text;
            string bedehkar = txtPriceBedehkar.Text;
            string bestankar = txtPriceBestankar.Text;
            if (this.Text == "Save")
            {
                await Task.Run(() =>
                {
                    var Check = senads.Insert(shomareSenad, codeKol, codeMoein, codeTafsili, namHesab, sharheSenad,
                        tarikhSenad, bedehkar, bestankar);
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
                    if (item != txtPriceBedehkar && item != txtPriceBestankar)
                    {
                        if (item is TextBox)
                        {
                            TextBox txt = item as TextBox;
                            txt.Text = "";
                        }
                    }
                }
            }
            else if (this.Text == "Edit")
            {
                await Task.Run(() =>
                {
                    var Check = senads.Update(shomareSenad, codeKol, codeMoein, codeTafsili, namHesab, sharheSenad,
                        tarikhSenad, bedehkar, bestankar);
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

        private void frmAddSenadHa_Load(object sender, EventArgs e)
        {
            if (this.Text == "Save")
            {
                var check1 = senads.SumBedehkar();
                var check2 = senads.SumBestankar();
                if (check1.Success == true && check2.Success == true)
                {
                    decimal mande = check1.Data - check2.Data;
                    if (mande > 0)
                    {
                        txtPriceBestankar.Text = mande.ToString();
                    }
                    else if (mande < 0)
                    {
                        txtPriceBedehkar.Text = (mande * -1).ToString();
                    }
                }
            }
        }
        private void txtPrice_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text == "0")
            {
                if (e.Button == MouseButtons.Left)
                {
                    txtPriceBedehkar.Text = "0";
                    txtPriceBestankar.Text = "0";
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPriceBedehkar_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text != "")
            {
                if (e.KeyCode == Keys.Add)
                {
                    box.Text = box.Text + "000";
                }
            }
        }

        private void txtPriceBedehkar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
