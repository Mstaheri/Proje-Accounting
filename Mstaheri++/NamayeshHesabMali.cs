using Stimulsoft.Report.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Mstaheri__
{
    public partial class NamayeshHesabMali : Form
    {
        CarpetCompanyDAL.SqlTableRefresh sqlrefresh;
        CarpetCompanyBLL.Mali mal;
        frmAddMali frmMali;
        public NamayeshHesabMali()
        {
            InitializeComponent();
            sqlrefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlrefresh.malRefresh += Sqlrefresh_malRefresh;
            mal = new CarpetCompanyBLL.Mali();
            frmMali = new frmAddMali();
        }

        

        public string search { get; set; }
        private async void Sqlrefresh_malRefresh(object sender, CarpetCompanyDAL.HesabMali e)
        {
            await SelectMali();
        }
        public async void NamayeshHesabMali_Load(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = "";
            }
           await SelectMali(search);
        }
        public Task SelectMali(string search = "")
        {
            return Task.Run(() =>
            {
                mal = new CarpetCompanyBLL.Mali();
                var table = mal.Select(search);
                if (table.Success == true)
                {
                    Action act = () =>
                    {
                        dataGridView1.DataSource = table.Data;
                    };
                    if (dataGridView1.Created)
                    {
                        if (dataGridView1.InvokeRequired)
                        {
                            dataGridView1.Invoke(act);
                        }
                        else
                        {
                            act();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(table.Message);
                }
            });
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Deletee.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                       string ShoomareHesabCode = dataGridView1.CurrentRow.Cells["ShomareHesab"].Value.ToString();
                       await Task.Run( () =>
                       {
                           var Check = mal.Delete(ShoomareHesabCode);
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
                    string shomareHesab = dataGridView1.CurrentRow.Cells["ShomareHesab"].Value.ToString();
                    string sahebHesab = dataGridView1.CurrentRow.Cells["SahebHesab"].Value.ToString();
                    string namHesab = dataGridView1.CurrentRow.Cells["NamHesab"].Value.ToString();
                    string namBank = dataGridView1.CurrentRow.Cells["NamBank"].Value.ToString();
                    string tozihat = dataGridView1.CurrentRow.Cells["Tozihat"].Value.ToString();
                    string mojodi = dataGridView1.CurrentRow.Cells["Mojodi"].Value.ToString();
                    frmAddMali frm = new frmAddMali();
                    frm.txtShomareHesab.Text = shomareHesab;
                    frm.txtSahebHesab.Text = sahebHesab;
                    frm.txtNamHesab.Text = namHesab;
                    frm.txtNamBank.Text = namBank;
                    frm.txtTozihat.Text = tozihat;
                    frm.txtMojodi.Text = mojodi;
                    frm.Text = "Edit";
                    frm.txtShomareHesab.Enabled = false;
                    frm.ShowDialog();

                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[tedad.Name].Value = e.RowIndex + 1;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Format = "#,##0";
            dataGridView1.Columns["Mojodi"].DefaultCellStyle = cellStyle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMali.Text = "Save";
            frmMali.ShowDialog();
        }
    }
}
