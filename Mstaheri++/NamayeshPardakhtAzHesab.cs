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
    public partial class NamayeshPardakhtAzHesab : Form
    {
        CarpetCompanyDAL.SqlTableRefresh sqlrefresh;
        CarpetCompanyBLL.pardakhtHesab pardakhti;
        CarpetCompanyBLL.Mali mal;
        frmAddPardakhtAzHesab pardakht;
        public NamayeshPardakhtAzHesab()
        {
            InitializeComponent();
            sqlrefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlrefresh.pardakhtRefresh += Sqlrefresh_pardakhtRefresh;
            pardakhti = new CarpetCompanyBLL.pardakhtHesab();
            mal = new CarpetCompanyBLL.Mali();
            pardakht = new frmAddPardakhtAzHesab();

        }
        public string search { get; set; }

        private async void Sqlrefresh_pardakhtRefresh(object sender, CarpetCompanyDAL.PardakhtAzHesab e)
        {
           await SelectPardakhti();
        }

        private async void NamayeshPardakhtAzHesab_Load(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = "";
            }
            await SelectPardakhti(search);
        }
        private Task SelectPardakhti(string search = "")
        {
            return Task.Run(() =>
            {
                var table = pardakhti.Select(search);
                if (table.Success == true)
                {
                    Action ab = () =>
                    {
                        dataGridView3.DataSource = table.Data;
                    };
                    if (dataGridView3.Created)
                    {
                        if (dataGridView3.InvokeRequired)
                        {
                            dataGridView3.Invoke(ab);
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

        private async void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView3.Columns[Delete2.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string codePardakhti = dataGridView3.CurrentRow.Cells["CodePardakhti"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = pardakhti.Delete(codePardakhti);
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
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView3.Rows[e.RowIndex].Cells[tedaddd.Name].Value = e.RowIndex + 1;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Format = "#,##0";
            dataGridView3.Columns["Price2"].DefaultCellStyle = cellStyle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    pardakht.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            pardakht.Text = "Save";
            pardakht.ShowDialog();
        }
    }
}
