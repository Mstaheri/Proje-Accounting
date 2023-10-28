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

namespace Mstaheri__
{
    public partial class NamayeshHazineEdari : Form
    {
        CarpetCompanyBLL.Mali mal;
        CarpetCompanyBLL.classHazineEdari hazine;
        CarpetCompanyDAL.SqlTableRefresh sqlRefresh;
        public NamayeshHazineEdari()
        {
            InitializeComponent();
            sqlRefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlRefresh.HazineEdariRefresh += SqlRefresh_HazineEdariRefresh;
            hazine = new CarpetCompanyBLL.classHazineEdari();
            mal = new CarpetCompanyBLL.Mali();
        }

        public string search { get; set; }

        private void SqlRefresh_HazineEdariRefresh(object sender, HazineEdari e)
        {
            SelectHazineEdari();
        }

        private void Accountants_Load(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = "";
            }
            SelectHazineEdari(search);
        }

        private Task SelectHazineEdari(string search = "")
        {
            return Task.Run(() =>
            {
                hazine = new CarpetCompanyBLL.classHazineEdari();
                var table = hazine.Select(search);
                if (table.Success == true)
                {
                    Action ab = () =>
                    {
                        dataGridView1.DataSource = table.Data;
                    };
                    if (dataGridView1.Created)
                    {
                        if (dataGridView1.InvokeRequired)
                        {
                            dataGridView1.Invoke(ab);
                        }
                        else
                        {
                            ab();
                        }
                    }

                }
                else
                {
                    MessageBox.Show(table.Message);
                }
            });


        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmAddHazineEdari edari = new frmAddHazineEdari();
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    edari.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            edari.Text = "Save";
            edari.ShowDialog();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Delete.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string Code = dataGridView1.CurrentRow.Cells["CodeHazine"].Value.ToString();
                        var Check = hazine.Delete(Code);
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
                    string codeHazine = dataGridView1.CurrentRow.Cells["CodeHazine"].Value.ToString();
                    string shomareHesab = dataGridView1.CurrentRow.Cells["ShomareHesab"].Value.ToString();
                    string namHazine = dataGridView1.CurrentRow.Cells["NamHazine"].Value.ToString();
                    string tarikhPardakht = dataGridView1.CurrentRow.Cells["TarikhPardakht"].Value.ToString();
                    string price = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                    string tozihat = dataGridView1.CurrentRow.Cells["Tozihat"].Value.ToString();

                    frmAddHazineEdari frm = new frmAddHazineEdari();
                    frm.txtCodeHazine.Text = codeHazine;
                    frm.comShomareHesab.Text = shomareHesab;
                    frm.txtNamHazine.Text = namHazine;
                    frm.txtTarikhPardakht.Text = tarikhPardakht;
                    frm.txtPrice.Text = price;
                    frm.txtTozihat.Text = tozihat;
                    frm.Text = "Edit";
                    frm.txtCodeHazine.Enabled = false;
                    frm.comShomareHesab.Enabled = false;
                    frm.txtPrice.Enabled = false;
                    frm.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[radif.Name].Value = e.RowIndex + 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
