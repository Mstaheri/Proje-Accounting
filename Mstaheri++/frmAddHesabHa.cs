using CarpetCompanyDAL;
using Stimulsoft.Base;
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
    public partial class frmAddHesabHa : Form
    {
        CarpetCompanyBLL.classHesabKol kol;
        CarpetCompanyDAL.classHesabMoin moin;
        CarpetCompanyDAL.classHesabTafsili Tafsili;
        public frmAddHesabHa()
        {
            InitializeComponent();
            kol = new CarpetCompanyBLL.classHesabKol();
            moin = new CarpetCompanyDAL.classHesabMoin();
            Tafsili = new CarpetCompanyDAL.classHesabTafsili();
        }
        public string CodeKolSelect { get; set; }
        public string CodeMoinSelect { get; set; }
        public string CodeTafsiriSelect { get; set; }
        public string OnvanKolSelect { get; set; }
        public string OnvanMoinSelect { get; set; }
        public string OnvanTafsiriSelect { get; set; }
        private async void frmAddHesabHa_Load(object sender, EventArgs e)
        {
           await Select();
        }
        private Task Select(string search = "")
        {
            return Task.Run(() =>
            {
                var check = kol.Select(search);
                if (check.Success == true)
                {
                    if (dataGridView1.Created)
                    {
                        Action abc = () =>
                        {
                            dataGridView1.DataSource = check.Data;
                        };
                        if (dataGridView1.InvokeRequired)
                        {
                            dataGridView1.Invoke(abc);
                        }
                        else
                        {
                            abc();
                        }
                    }
                    else
                    {
                        MessageBox.Show(check.Message);
                    }
                }

            });
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void frmAddHesabHa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("213, 225, 242");
                string CodeKol = dataGridView1.CurrentRow.Cells["CodeKol"].Value.ToString();
                await Task.Run(() =>
                {
                    var check = moin.SelectCodeKol(CodeKol);
                    if (check.Success == true)
                    {
                        Action abc = () =>
                        {
                            dataGridView2.DataSource = check.Data;
                        };
                        dataGridView2.Invoke(abc);
                    }

                });
                CodeKolSelect = dataGridView1.CurrentRow.Cells["CodeKol"].Value.ToString();
                OnvanKolSelect = dataGridView1.CurrentRow.Cells["OnvanKol"].Value.ToString();
                dataGridView3.DataSource = new List<HesabTafsili>();

            }
        }

        private async void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("213, 225, 242");
                string CodeMoin = dataGridView2.CurrentRow.Cells["CodeMoin"].Value.ToString();
                await Task.Run(() =>
                {
                    var check = Tafsili.SelectCodeMion(CodeMoin);
                    if (check.Success == true)
                    {
                        Action abc = () =>
                        {
                            dataGridView3.DataSource = check.Data;
                        };
                        dataGridView3.Invoke(abc);
                    }

                });
                CodeMoinSelect = dataGridView2.CurrentRow.Cells["CodeMoin"].Value.ToString();
                OnvanMoinSelect = dataGridView2.CurrentRow.Cells["OnvanMoin"].Value.ToString();

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("213, 225, 242");
            CodeTafsiriSelect = dataGridView3.CurrentRow.Cells["CodeTafsili"].Value.ToString();
            OnvanTafsiriSelect = dataGridView3.CurrentRow.Cells["OnvanTafsili"].Value.ToString();
            this.Close();
        }
        private void dataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
