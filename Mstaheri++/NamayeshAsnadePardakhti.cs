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
    public partial class NamayeshAsnadePardakhti : Form
    {
        CarpetCompanyDAL.SqlTableRefresh sqlRefresh;
        CarpetCompanyBLL.classAsnadePardakhti Pardakhti;
        CarpetCompanyBLL.Mali mal;
        public NamayeshAsnadePardakhti()
        {
            InitializeComponent();
            sqlRefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlRefresh.asnadePardakhtiRefresh += SqlRefresh_asnadePardakhtiRefresh;
            Pardakhti = new CarpetCompanyBLL.classAsnadePardakhti();
            mal = new CarpetCompanyBLL.Mali();
        }
        public string search { get; set; }

        private async void SqlRefresh_asnadePardakhtiRefresh(object sender, AsnadePardakhti e)
        {
            await SelectAsnadePardakhti();
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView2.Columns[Delete.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string CodeSenad = dataGridView2.CurrentRow.Cells["CodeSenad2"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = Pardakhti.Delete(CodeSenad);
                            if (Check.Success == true)
                            {
                                MessageBox.Show(Check.Message);
                            }
                            else
                            {
                                MessageBox.Show(Check.Message);
                            }
                        });
                        
                    }
                }
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView2.Columns[Edit.Name].Index)
                {
                    string cdeSenad = dataGridView2.CurrentRow.Cells["CodeSenad2"].Value.ToString();
                    string shomareHesab = dataGridView2.CurrentRow.Cells["ShomareHesab2"].Value.ToString();
                    string namHesab = dataGridView2.CurrentRow.Cells["NamHesab2"].Value.ToString();
                    string pardakhteBe = dataGridView2.CurrentRow.Cells["PardakhteBe"].Value.ToString();
                    string shomareSenad = dataGridView2.CurrentRow.Cells["ShomareSenad2"].Value.ToString();
                    string tarikhSabt = dataGridView2.CurrentRow.Cells["TarikhSabt2"].Value.ToString();
                    string tarikhSarResid = dataGridView2.CurrentRow.Cells["TarikhSarResid2"].Value.ToString();
                    string price = dataGridView2.CurrentRow.Cells["Price2"].Value.ToString();
                    string tozihat = dataGridView2.CurrentRow.Cells["Tozihat2"].Value.ToString();
                    string vaziat = dataGridView2.CurrentRow.Cells["Vaziat2"].Value.ToString();
                    frmAddAsnadePardakhti frm = new frmAddAsnadePardakhti();
                    frm.txtCodeSenad.Text = cdeSenad;
                    frm.comShomareHesab.Text = shomareHesab;
                    frm.txtNamHesab.Text = namHesab;
                    frm.txtDaryaft.Text = pardakhteBe;
                    frm.txtShomareSenad.Text = shomareSenad;
                    frm.txtTarikhSabt.Text = tarikhSabt;
                    frm.txtTarikhSarResid.Text = tarikhSarResid;
                    frm.txtPrice.Text = price;
                    frm.txtTozihat.Text = tozihat;
                    frm.comVaziat.Text = vaziat;
                    if (vaziat == "وصول شده")
                    {
                        frm.comShomareHesab.Enabled = false;
                        frm.txtPrice.Enabled = false;
                        frm.comVaziat.Enabled = false;
                        frm.Text = "Edit2";
                    }
                    else
                    {
                        frm.Text = "Edit";
                    }
                    var Check = mal.SelectShomareHesab();
                    if (Check.Success == true)
                    {
                        for (int i = 0; i < Check.Data.Count; i++)
                        {
                            frm.comShomareHesab.Items.Add(Check.Data[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Check.Message);
                    }
                    frm.txtCodeSenad.Enabled = false;
                    frm.ShowDialog();
                }
            }

        }
        private Task SelectAsnadePardakhti(string search = "")
        {
            return Task.Run(() =>
            {
                Pardakhti = new CarpetCompanyBLL.classAsnadePardakhti();
                var table = Pardakhti.Select(search);
                if (table.Success == true)
                {
                    Action ab = () =>
                    {
                        dataGridView2.DataSource = table.Data;
                    };
                    if (dataGridView2.Created)
                    {
                        if (dataGridView2.InvokeRequired)
                        {
                            dataGridView2.Invoke(ab);
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

        private async void NamayeshAsnadePardakhti_Load(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = "";
            }
            await SelectAsnadePardakhti(search);
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].Cells[tedad2.Name].Value = e.RowIndex + 1;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Format = "#,##0";
            dataGridView2.Columns["Price2"].DefaultCellStyle = cellStyle;
            var row = dataGridView2.Rows[e.RowIndex];
            if (row.Cells[Vaziat2.Name].Value.ToString() == "وصول شده")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2ecc71");
            }
            else if (row.Cells[Vaziat2.Name].Value.ToString() == "در جریان وصول")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F5DEB3");
            }
            else if (row.Cells[Vaziat2.Name].Value.ToString() == "برگشت خورده")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e74c3c");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddAsnadePardakhti asnadePardakht = new frmAddAsnadePardakhti();
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    asnadePardakht.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            asnadePardakht.Text = "Save";
            asnadePardakht.ShowDialog();
        }
    }
}
