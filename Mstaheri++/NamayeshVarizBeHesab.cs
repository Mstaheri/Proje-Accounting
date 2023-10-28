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
    public partial class NamayeshVarizBeHesab : Form
    {
        CarpetCompanyDAL.SqlTableRefresh sqlrefresh;
        CarpetCompanyBLL.varizBeHesabb varizs;
        frmAddVarizBeHesab variz;
        CarpetCompanyBLL.Mali mal;
        public NamayeshVarizBeHesab()
        {
            InitializeComponent();
            sqlrefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlrefresh.varizRefresh += Sqlrefresh_varizRefresh;
            varizs =  new CarpetCompanyBLL.varizBeHesabb();
            variz = new frmAddVarizBeHesab();
            mal = new CarpetCompanyBLL.Mali();
        }
        public string search { get; set; }

        private void Sqlrefresh_varizRefresh(object sender, CarpetCompanyDAL.VarizBeHesab e)
        {
            SelectVarizs();
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView2.Columns[Deleteee.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string codeVariz = dataGridView2.CurrentRow.Cells["CodeVariz"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = varizs.Delete(codeVariz);
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
        private Task SelectVarizs(string search = "")
        {
            return Task.Run(() =>
            {
                var table = varizs.Select(search);
                if (table.Success == true)
                {
                    Action abc = () =>
                    {
                        dataGridView2.DataSource = table.Data;
                    };
                    if (dataGridView2.Created)
                    {
                        if (dataGridView2.InvokeRequired)
                        {
                            dataGridView2.Invoke(abc);
                        }
                        else
                        {
                            abc();
                        }
                    }

                }
                else
                {
                    MessageBox.Show(table.Message);
                }
            });
           
        }

        private async void NamayeshVarizBeHesab_Load(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = "";
            }
            await SelectVarizs(search);
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].Cells[tedadd.Name].Value = e.RowIndex + 1;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Format = "#,##0";
            dataGridView2.Columns["Price"].DefaultCellStyle = cellStyle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    variz.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            variz.Text = "Save";
            variz.ShowDialog();
        }
    }
}
