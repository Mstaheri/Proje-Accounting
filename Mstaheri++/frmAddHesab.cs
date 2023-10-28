using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Mstaheri__
{
    public partial class frmAddHesab : Form
    {
        CarpetCompanyBLL.classHesabKol kol;
        CarpetCompanyBLL.classHesabMion mion;
        public frmAddHesab()
        {
            InitializeComponent();
            kol = new CarpetCompanyBLL.classHesabKol();
            mion = new CarpetCompanyBLL.classHesabMion();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string CodeKol = txtCodeKol.Text;
                string OnvanKol = txtOnvanKol.Text;
                await Task.Run(() =>
                {
                    var check = kol.Insert(CodeKol, OnvanKol);
                    if (check.Success == true)
                    {
                        MessageBox.Show(check.Message);
                    }
                    else
                    {
                        MessageBox.Show(check.Message);
                    }
                });
                foreach (var item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;
                        txt.Text = "";
                    }
                }
                SelectCodes();
            }
            else if (radioButton2.Checked == true)
            {
                string CodeMoin = txtCodeMoin.Text;
                string OnvanMoin = txtOnvanMoin.Text;
                string CodeKol = conCodeKol.Text;
                await Task.Run(() =>
                {
                    CarpetCompanyBLL.classHesabMion Moin = new CarpetCompanyBLL.classHesabMion();
                    var check = Moin.Insert(CodeMoin, OnvanMoin, CodeKol);
                    if (check.Success == true)
                    {
                        MessageBox.Show(check.Message);
                    }
                    else
                    {
                        MessageBox.Show(check.Message);
                    }
                });
                foreach (var item in panel2.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;
                        txt.Text = "";
                    }
                }
                SelectCodes();
            }
            else if (radioButton3.Checked == true)
            {
                string CodeTafsili = txtCodeTafsili.Text;
                string OnvanTafsili = txtOnvanTafsili.Text;
                string CodeMoin = comCodeMoin.Text;
                await Task.Run(() =>
                {
                    CarpetCompanyBLL.classHesabTafsili Tafsili = new CarpetCompanyBLL.classHesabTafsili();
                    var check = Tafsili.Insert(CodeTafsili, OnvanTafsili, CodeMoin);
                    if (check.Success == true)
                    {
                        MessageBox.Show(check.Message);
                    }
                    else
                    {
                        MessageBox.Show(check.Message);
                    }
                });
                foreach (var item in panel3.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;
                        txt.Text = "";
                    }
                }
                SelectCodes();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void frmAddHesab_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            SelectCodes();
        }
        private void SelectCodes()
        {
            comCodeMoin.Items.Clear();
            conCodeKol.Items.Clear();
            var Check1 = kol.SelectAllCodeKol();
            var Check2 = mion.SelectAllCodeMoin();
            if (Check1.Success == true && Check2.Success == true)
            {
                for (int i = 0; i < Check1.Data.Count; i++)
                {
                    conCodeKol.Items.Add(Check1.Data[i]);
                }
                for (int i = 0; i < Check2.Data.Count; i++)
                {
                    comCodeMoin.Items.Add(Check2.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check1.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }
    }
}
