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
    public partial class NamayeshHazineHoghogh : Form
    {
        CarpetCompanyBLL.HoghoghKarmandan HK;
        CarpetCompanyBLL.Mali mal;
        public NamayeshHazineHoghogh()
        {
            InitializeComponent();
            HK = new CarpetCompanyBLL.HoghoghKarmandan();
            mal = new CarpetCompanyBLL.Mali();
            var refresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            refresh.hoghoghRefresh += Refresh_hoghoghRefresh;
        }
        public string search { get; set; }

        private async void Refresh_hoghoghRefresh(object sender, CarpetCompanyDAL.Hoghogh e)
        {
            if (search == null)
            {
                search = "";
            }
            await select(search);
        }

        private async void NamayeshHazineHoghogh_Load(object sender, EventArgs e)
        {
            await select();
        }

        private Task select(string search = "")
        {
            return Task.Run(() =>
            {
                HK = new CarpetCompanyBLL.HoghoghKarmandan();
                var table = HK.Select(search);
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
            frmAddHazineHoghogh Hoghogh = new frmAddHazineHoghogh();
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    Hoghogh.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            Hoghogh.Text = "Save";
            Hoghogh.ShowDialog();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Deletee.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string CodeHoghogh = dataGridView1.CurrentRow.Cells["CodeHoghogh"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = HK.Delete(CodeHoghogh);
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
                    string CodeHoghogh = dataGridView1.CurrentRow.Cells["CodeHoghogh"].Value.ToString();
                    string ShomareHesab = dataGridView1.CurrentRow.Cells["ShomareHesab"].Value.ToString();
                    string Nam = dataGridView1.CurrentRow.Cells["Nam"].Value.ToString();
                    string Tarikh = dataGridView1.CurrentRow.Cells["Tarikh"].Value.ToString();
                    string NoaHoghogh = dataGridView1.CurrentRow.Cells["NoaHoghogh"].Value.ToString();
                    string price = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                    string Tozihat = dataGridView1.CurrentRow.Cells["Tozihat"].Value.ToString();
                    frmAddHazineHoghogh frm = new frmAddHazineHoghogh();
                    frm.txtCodeHoghogh.Text = CodeHoghogh;
                    frm.comShomareHesab.Text = ShomareHesab;
                    frm.txtNam.Text = Nam;
                    frm.txtTarikhPardakht.Text = Tarikh;
                    frm.txtNoaHoghogh.Text = NoaHoghogh;
                    frm.txtPrice.Text = price;
                    frm.txtTozihat.Text = Tozihat;
                    frm.Text = "Edit";
                    frm.txtCodeHoghogh.Enabled = false;
                    frm.comShomareHesab.Enabled = false;
                    frm.txtPrice.Enabled = false; 
                    frm.ShowDialog();

                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[tedad.Name].Value = e.RowIndex + 1;
        }
    }
}
