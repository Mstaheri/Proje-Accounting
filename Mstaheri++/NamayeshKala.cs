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
using static Mstaheri__.frmAddKala;

namespace Mstaheri__
{
    public partial class NamayeshKala : Form
    {
        CarpetCompanyBLL.ProductRegistrationEF res;
        public NamayeshKala()
        {
            InitializeComponent();
            res = new CarpetCompanyBLL.ProductRegistrationEF();
        }
        private void WarehouseKeeper_Load(object sender, EventArgs e)
        {
            select();
        }
        private void Frm_AddCommodityChanged(object sender, Change e)
        {
            select();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[radif.Name].Value = e.RowIndex + 1;
        }

        private void select()
        {
            string search = "";
            MyDbContext Db = new MyDbContext();
            dataGridView1.DataSource = Db.ProductRegistrations.Where(x => x.ProductName.Contains(search)).ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Delete.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string productCode = dataGridView1.CurrentRow.Cells["ProductCode"].Value.ToString();
                        var Check = res.Delete(productCode);
                        select();
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
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Edit.Name].Index)
                {
                    string productCode = dataGridView1.CurrentRow.Cells["ProductCode"].Value.ToString();
                    string productName = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
                    string unit = dataGridView1.CurrentRow.Cells["Unit"].Value.ToString();
                    string purchasePrice = dataGridView1.CurrentRow.Cells["PurchasePrice"].Value.ToString();
                    string salesPrice = dataGridView1.CurrentRow.Cells["SalesPrice"].Value.ToString();
                    string barCode = dataGridView1.CurrentRow.Cells["BarCode"].Value.ToString();
                    frmAddKala frm = new frmAddKala();
                    frm.Text = "Edit";
                    frm.txtProductCode.Text = productCode;
                    frm.txtProductName.Text = productName;
                    frm.txtUnit.Text = unit;
                    frm.txtPurchasePrice.Text = purchasePrice;
                    frm.txtSalesPrice.Text = salesPrice;
                    frm.txtBarCode.Text = barCode;
                    frm.txtProductCode.Enabled = false;
                    frm.AddCommodityChanged += Frm_AddCommodityChanged;
                    frm.ShowDialog();
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddKala frm = new frmAddKala();
            frm.AddCommodityChanged += Frm_AddCommodityChanged;
            frm.Text = "Save";
            frm.txtProductCode.Enabled = true;
            frm.ShowDialog();
        }
    }
}
