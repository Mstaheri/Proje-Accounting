using CarpetCompanyDAL;
using CarpetCompanyDAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Mstaheri__
{
    public partial class frmAddKala : Form
    {
        public enum Change
        {
            inserted,
            updated
        }
        public event EventHandler<Change> AddCommodityChanged;
        public frmAddKala()
        {
            InitializeComponent();
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text;
            string productName = txtProductName.Text;
            string unit = txtUnit.Text;
            string purchasePrice = txtPurchasePrice.Text;
            string salesPrice = txtSalesPrice.Text;
            string barCode = txtBarCode.Text;
            
            if (this.Text == "Save")
            {
                CarpetCompanyBLL.ProductRegistrationEF rec = new CarpetCompanyBLL.ProductRegistrationEF();
                var check = rec.Insert(productCode, productName, unit, purchasePrice, salesPrice, barCode);
                if (AddCommodityChanged != null)
                {
                    AddCommodityChanged(this, Change.inserted);
                }
                if (check.Success == true)
                {
                    MessageBox.Show(check.Message);
                    
                }
                else
                {
                    MessageBox.Show(check.Message);
                }
            }
            if (this.Text == "Edit")
            {
                CarpetCompanyBLL.ProductRegistrationEF rec = new CarpetCompanyBLL.ProductRegistrationEF();
                var check = rec.Updat(productCode, productName, unit, purchasePrice, salesPrice, barCode);
                if (AddCommodityChanged != null)
                {
                    AddCommodityChanged(this, Change.updated);
                }
                if (check.Success == true)
                {
                    MessageBox.Show(check.Message);
                }
                else
                {
                    MessageBox.Show(check.Message);
                }
            }
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
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

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
