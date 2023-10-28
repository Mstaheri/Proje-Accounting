using CarpetCompanyDAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mstaheri__
{
    public partial class NamayeshSenad : Form
    {
        CarpetCompanyDAL.SqlTableRefresh sqlrefresh;
        CarpetCompanyBLL.classSenads Senads;
        public NamayeshSenad()
        {
            InitializeComponent();
            sqlrefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            sqlrefresh.senadRefresh += Query_senadRefresh;
            Senads = new CarpetCompanyBLL.classSenads();
        }

        private async void Query_senadRefresh(object sender, Senad e)
        {
           await Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void NamayeshSenad_Load(object sender, EventArgs e)
        {
           await Select();
        }
        private Task Select(string search = "")
        {
            return Task.Run(() =>
            {
                Senads = new CarpetCompanyBLL.classSenads();
                var check = Senads.Select(search);
                var check2 = Senads.SumBedehkar();
                var check3 = Senads.SumBestankar();
                if (check.Success == true && check2.Success == true && check3.Success == true)
                {
                    if (dataGridView1.Created)
                    {
                        Action abc = () =>
                        {
                            dataGridView1.DataSource = check.Data;

                            label7.Text = check2.Data.ToString();
                            decimal st = decimal.Parse(label7.Text);
                            label7.Text = st.ToString("N0");
                            //////////////////////////////////////
                            label8.Text = check3.Data.ToString();
                            decimal st1 = decimal.Parse(label8.Text);
                            label8.Text = st1.ToString("N0");
                            //////////////////////////////////////
                            decimal mande = check2.Data - check3.Data;
                            if (mande >= 0)
                            {
                                label6.Text = mande.ToString();
                            }
                            else if (mande <= 0)
                            {
                                label6.Text = (mande * -1).ToString();
                            }
                            decimal st2 = decimal.Parse(label6.Text);
                            label6.Text = st2.ToString("N0");
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[tedad.Name].Value = e.RowIndex + 1;
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Format = "#,##0";
            dataGridView1.Columns["Bedehkar"].DefaultCellStyle = cellStyle;
            dataGridView1.Columns["Bestankar"].DefaultCellStyle = cellStyle;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("213, 225, 242");
                int r = dataGridView1.CurrentCell.RowIndex;
                string shomareSenad = dataGridView1.Rows[r].Cells["ShomareSenad"].Value.ToString();
                string tarikh = dataGridView1.Rows[r].Cells["TarikhSenad"].Value.ToString();
                label4.Text = shomareSenad;
                label2.Text = tarikh;
            }
            

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                var tedad = dataGridView1.Rows[row].Cells["tedad"].Value;
                if (tedad != null)
                {
                    if ((int)tedad % 2 == 1)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("227, 240, 255");
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            
            
        }

        private async void NamayeshSenad_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void NamayeshSenad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟", "پاک کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string Code = dataGridView1.CurrentRow.Cells["ShomareSenad"].Value.ToString();
                        await Task.Run(() =>
                        {
                            var Check = Senads.Delete(Code);
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
                catch (Exception)
                {
                    MessageBox.Show("eror");
                }

            }
            else if (e.KeyCode == Keys.F6)
            {
                try
                {
                    string shomareSenad = dataGridView1.CurrentRow.Cells["ShomareSenad"].Value.ToString();
                    string codeKol = dataGridView1.CurrentRow.Cells["CodeKol"].Value.ToString();
                    string codeMoein = dataGridView1.CurrentRow.Cells["CodeMoein"].Value.ToString();
                    string codeTafsili = dataGridView1.CurrentRow.Cells["CodeTafsili"].Value.ToString();
                    string namHesab = dataGridView1.CurrentRow.Cells["NamHesabb"].Value.ToString();
                    string sharheSenad = dataGridView1.CurrentRow.Cells["SharheSenad"].Value.ToString();
                    string tarikhSenad = dataGridView1.CurrentRow.Cells["TarikhSenad"].Value.ToString();
                    string bedehkar = dataGridView1.CurrentRow.Cells["Bedehkar"].Value.ToString();
                    string bestankar = dataGridView1.CurrentRow.Cells["Bestankar"].Value.ToString();
                    frmAddSenadHa senad = new frmAddSenadHa();
                    senad.txtShomareSenad.Text = shomareSenad;
                    senad.txtKol.Text = codeKol;
                    senad.txtMoin.Text = codeMoein;
                    senad.txtTafsili.Text = codeTafsili;
                    senad.lblNamHesab.Text = namHesab;
                    senad.txtSharheSenad.Text = sharheSenad;
                    senad.txtTarikh.Text = tarikhSenad;
                    senad.txtPriceBestankar.Text = bestankar;
                    senad.txtPriceBedehkar.Text = bedehkar;
                    senad.txtSharheSenad.Enabled = true;
                    senad.Text = "Edit";
                    senad.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("eror");
                }
            }
        }

        private void dateTimeSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
