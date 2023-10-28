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
    public partial class NamayeshHesabKol : Form
    {
        CarpetCompanyBLL.classHesabKol kol;
        public NamayeshHesabKol()
        {
            InitializeComponent();
            kol = new CarpetCompanyBLL.classHesabKol();
        }

        private async void NamayeshHesabKol_Load(object sender, EventArgs e)
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
                            dataGridView1.DataSource= check.Data;
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

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Deletee.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string CodeSenad = dataGridView1.CurrentRow.Cells["CodeKol"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = kol.Delete(CodeSenad);
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
                await Select();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[tedad.Name].Value = e.RowIndex + 1;
        }
    }
}
