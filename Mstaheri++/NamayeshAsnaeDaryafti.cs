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
    public partial class NamayeshAsnaeDaryafti : Form
    {
        CarpetCompanyDAL.SqlTableRefresh sqlRefresh;
        CarpetCompanyBLL.classAsnadeDaryafti Daryafti;
        CarpetCompanyBLL.Mali mal;
        public NamayeshAsnaeDaryafti()
        {
            InitializeComponent();
            sqlRefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlRefresh.asnadeDaryaftiRefresh += SqlRefresh_asnadeDaryaftiRefresh;
            Daryafti = new CarpetCompanyBLL.classAsnadeDaryafti();
            mal = new CarpetCompanyBLL.Mali();
        }

        public string search { get; set; }
        private async void SqlRefresh_asnadeDaryaftiRefresh(object sender, CarpetCompanyDAL.AsnadeDaryafti e)
        {
           await SelectAsnadeDaryafti();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Deletee.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string CodeSenad = dataGridView1.CurrentRow.Cells["CodeSenad"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = Daryafti.Delete(CodeSenad);
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
                if (e.ColumnIndex == dataGridView1.Columns[Editt.Name].Index)
                {
                    string cdeSenad = dataGridView1.CurrentRow.Cells["CodeSenad"].Value.ToString();
                    string shomareHesab = dataGridView1.CurrentRow.Cells["ShomareHesab"].Value.ToString();
                    string namHesab = dataGridView1.CurrentRow.Cells["NamHesab"].Value.ToString();
                    string daryaftAz = dataGridView1.CurrentRow.Cells["DaryaftAz"].Value.ToString();
                    string shomareSenad = dataGridView1.CurrentRow.Cells["ShomareSenad"].Value.ToString();
                    string tarikhSabt = dataGridView1.CurrentRow.Cells["TarikhSabt"].Value.ToString();
                    string tarikhSarResid = dataGridView1.CurrentRow.Cells["TarikhSarResid"].Value.ToString();
                    string price = dataGridView1.CurrentRow.Cells["Pricee"].Value.ToString();
                    string tozihat = dataGridView1.CurrentRow.Cells["Tozihat"].Value.ToString();
                    string vaziat = dataGridView1.CurrentRow.Cells["Vaziat"].Value.ToString();
                    frmAddAsnadeDaryafti frm = new frmAddAsnadeDaryafti();
                    frm.txtCodeSenad.Text = cdeSenad;
                    frm.comShomareHesab.Text = shomareHesab;
                    frm.txtNamHesab.Text = namHesab;
                    frm.txtDaryaft.Text = daryaftAz;
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

        private async void NamayeshAsnaeDaryafti_Load(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = "";
            }
            await SelectAsnadeDaryafti(search);
        }
        private Task SelectAsnadeDaryafti(string search = "")
        {
            return Task.Run(() =>
            {
                Daryafti = new CarpetCompanyBLL.classAsnadeDaryafti();
                var table = Daryafti.Select(search);
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[tedad.Name].Value = e.RowIndex + 1;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Format = "#,##0";
            dataGridView1.Columns["Pricee"].DefaultCellStyle = cellStyle;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells[Vaziat.Name].Value.ToString() == "وصول شده")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2ecc71");
            }
            else if (row.Cells[Vaziat.Name].Value.ToString() == "در جریان وصول")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F5DEB3");
            }
            else if (row.Cells[Vaziat.Name].Value.ToString() == "برگشت خورده")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e74c3c");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddAsnadeDaryafti asnadeDaryafti = new frmAddAsnadeDaryafti();
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    asnadeDaryafti.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            asnadeDaryafti.Text = "Save";
            asnadeDaryafti.ShowDialog();
        }
    }
}
