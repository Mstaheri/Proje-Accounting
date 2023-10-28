using CarpetCompanyDAL;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.Func;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Mstaheri__
{
    public partial class Hesabdar : Form
    {
        CarpetCompanyBLL.Mali mal;
        CarpetCompanyBLL.varizBeHesabb variz;
        CarpetCompanyBLL.classAsnadeDaryafti daryafti;
        public Hesabdar()
        {
            InitializeComponent();
            mal = new CarpetCompanyBLL.Mali();
            variz = new CarpetCompanyBLL.varizBeHesabb();
            daryafti = new CarpetCompanyBLL.classAsnadeDaryafti();
        }
        private void Hesabdar_Load(object sender, EventArgs e)
        {
            CarpetCompanyDAL.SqlTableRefresh sqlrefresh;
            sqlrefresh = CarpetCompanyDAL.SqlTableRefresh.Instance;
            MyDbContext Db = new MyDbContext();
            Db.ProductRegistrations.Where(x => x.ProductName.Contains("")).ToList();
        }
        
        private void myTxtAndPic1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void myTxtAndPic1_Load(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void myTxtAndPic1_MouseClick(object sender, MouseEventArgs e)
        {
            myTxtAndPic1.ContextMenuStrip = conHesabMali;
            if (e.Button == MouseButtons.Left)
            {
                myTxtAndPic1.ContextMenuStrip.Show(myTxtAndPic1, new Point(e.X, e.Y));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myTxtAndPic1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void gdfgfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshHesabMali mal = new NamayeshHesabMali();
            mal.Dock = DockStyle.Fill;
            mal.FormBorderStyle = FormBorderStyle.None;
            mal.TopLevel = false;
            groupBox8.Controls.Add(mal);
            groupBox8.Text = "حساب های مالی";
            mal.Show();
        }
        


        private void dfgfdgdfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMali mal = new frmAddMali();
            mal.Text = "Save";
            mal.ShowDialog();
        }
        private void tolNamayeshVarizi(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshVarizBeHesab mal = new NamayeshVarizBeHesab();
            mal.Dock = DockStyle.Fill;
            mal.FormBorderStyle = FormBorderStyle.None;
            mal.TopLevel = false;
            groupBox8.Controls.Add(mal);
            groupBox8.Text = "واریز به حساب";
            mal.Show();
        }


        private void ToolNamayeshPardakhti_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshPardakhtAzHesab pardakht = new NamayeshPardakhtAzHesab();
            pardakht.Dock = DockStyle.Fill;
            pardakht.FormBorderStyle = FormBorderStyle.None;
            pardakht.TopLevel = false;
            groupBox8.Controls.Add(pardakht);
            groupBox8.Text = "پرداخت از حساب";
            pardakht.Show();
        }

        private void ToolPardakhtAzHesab_Click(object sender, EventArgs e)
        {
            frmAddPardakhtAzHesab pardakht = new frmAddPardakhtAzHesab();
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

        public void ToolNamayeshAsnadeDaryafti_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshAsnaeDaryafti asnadeDaryafti = new NamayeshAsnaeDaryafti();
            asnadeDaryafti.Dock = DockStyle.Fill;
            asnadeDaryafti.FormBorderStyle = FormBorderStyle.None;
            asnadeDaryafti.TopLevel = false;
            groupBox8.Controls.Add(asnadeDaryafti);
            groupBox8.Text = "اسناد دریافتی";
            asnadeDaryafti.Show();


        }

        private void ToolSabtSenadDaryafti_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolNamayeshAsnadePardakhti_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshAsnadePardakhti asnadePardakhti= new NamayeshAsnadePardakhti();
            asnadePardakhti.Dock = DockStyle.Fill;
            asnadePardakhti.FormBorderStyle = FormBorderStyle.None;
            asnadePardakhti.TopLevel = false;
            groupBox8.Controls.Add(asnadePardakhti);
            groupBox8.Text = "اسناد پرداختی";
            asnadePardakhti.Show();
        }

        private void ToolSabtSenadPardakhti_Click(object sender, EventArgs e)
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

        private void ToolNamayeshSenad_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshSenad senad = new NamayeshSenad();
            senad.Dock = DockStyle.Fill;
            senad.FormBorderStyle = FormBorderStyle.None;
            senad.TopLevel = false;
            groupBox8.Controls.Add(senad);
            groupBox8.Text = "سند ها";
            senad.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox8.Text == "حساب های مالی")
            {
                //groupBox8.Controls.Clear();
                //NamayeshHesabMali mal = new NamayeshHesabMali();
                //mal.search = textBox3.Text;
                //mal.Dock = DockStyle.Fill;
                //mal.FormBorderStyle = FormBorderStyle.None;
                //mal.TopLevel = false;
                //groupBox8.Controls.Add(mal);
                //mal.Show();
            }
            else if (groupBox8.Text == "واریز به حساب")
            {
                groupBox8.Controls.Clear();
                NamayeshVarizBeHesab variz = new NamayeshVarizBeHesab();
                variz.search = textBox3.Text;
                variz.Dock = DockStyle.Fill;
                variz.FormBorderStyle = FormBorderStyle.None;
                variz.TopLevel = false;
                groupBox8.Controls.Add(variz);
                variz.Show();
            }
            else if (groupBox8.Text == "پرداخت از حساب")
            {
                groupBox8.Controls.Clear();
                NamayeshPardakhtAzHesab pardakht = new NamayeshPardakhtAzHesab();
                pardakht.search = textBox3.Text;
                pardakht.Dock = DockStyle.Fill;
                pardakht.FormBorderStyle = FormBorderStyle.None;
                pardakht.TopLevel = false;
                groupBox8.Controls.Add(pardakht);
                pardakht.Show();
            }
            else if (groupBox8.Text == "اسناد دریافتی")
            {
                groupBox8.Controls.Clear();
                NamayeshAsnaeDaryafti asnadeDaryafti = new NamayeshAsnaeDaryafti();
                asnadeDaryafti.search = textBox3.Text;
                asnadeDaryafti.Dock = DockStyle.Fill;
                asnadeDaryafti.FormBorderStyle = FormBorderStyle.None;
                asnadeDaryafti.TopLevel = false;
                groupBox8.Controls.Add(asnadeDaryafti);
                asnadeDaryafti.Show();
            }
            else if (groupBox8.Text == "اسناد پرداختی")
            {
                groupBox8.Controls.Clear();
                NamayeshAsnadePardakhti asnadePardakhti = new NamayeshAsnadePardakhti();
                asnadePardakhti.search = textBox3.Text;
                asnadePardakhti.Dock = DockStyle.Fill;
                asnadePardakhti.FormBorderStyle = FormBorderStyle.None;
                asnadePardakhti.TopLevel = false;
                groupBox8.Controls.Add(asnadePardakhti);
                asnadePardakhti.Show();
            }
            else
            {
                MessageBox.Show("چیزی برای فیلتر کردن نیست");
            }

        }

        private void ماشینحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void پیامهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chat frm = new Chat();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void نمایشحسابهایکلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshHesabKol kol = new NamayeshHesabKol();
            kol.Dock = DockStyle.Fill;
            kol.FormBorderStyle = FormBorderStyle.None;
            kol.TopLevel = false;
            groupBox8.Controls.Add(kol);
            groupBox8.Text = "حساب کل";
            kol.Show();
        }

        private void ثبتحسابجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddHesab hesab = new frmAddHesab();
            hesab.Text = "Save";
            hesab.ShowDialog();
            نمایشحسابهایکلToolStripMenuItem_Click(sender, e);
        }

        private void ثبتسندجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSenadHa senad = new frmAddSenadHa();
            senad.Text = "Save";
            senad.ShowDialog();
        }

        private void نمایشحسابهایمعینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshHesabMoin Moin = new NamayeshHesabMoin();
            Moin.Dock = DockStyle.Fill;
            Moin.FormBorderStyle = FormBorderStyle.None;
            Moin.TopLevel = false;
            groupBox8.Controls.Add(Moin);
            groupBox8.Text = "حساب معین";
            Moin.Show();
        }

        private void نمایشحسابهایتفصیلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshHesabTafsili Tafsili = new NamayeshHesabTafsili();
            Tafsili.Dock = DockStyle.Fill;
            Tafsili.FormBorderStyle = FormBorderStyle.None;
            Tafsili.TopLevel = false;
            groupBox8.Controls.Add(Tafsili);
            groupBox8.Text = "حساب تفصیلی";
            Tafsili.Show();
        }

        private void ToolGozaresh_Click(object sender, EventArgs e)
        {
            var rpt = StiReportHelper.GetReport("BarErsali.mrt");
            var query = mal.Select();
            rpt.Show();
        }
        private void VarizBeHesab_Click(object sender, EventArgs e)
        {
            frmAddVarizBeHesab variz = new frmAddVarizBeHesab();
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

        private void نمایشکالاهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshKala kala = new NamayeshKala();
            kala.Dock = DockStyle.Fill;
            kala.FormBorderStyle = FormBorderStyle.None;
            kala.TopLevel = false;
            groupBox8.Controls.Add(kala);
            groupBox8.Text = "کالا ها";
            kala.Show();

        }

        private void ثبتکالایجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddKala frm = new frmAddKala();
            frm.AddCommodityChanged += Frm_AddCommodityChanged;
            frm.Text = "Save";
            frm.txtProductCode.Enabled = true;
            frm.ShowDialog();
        }

        private void Frm_AddCommodityChanged(object sender, frmAddKala.Change e)
        {
            select();
        }

        private void select()
        {
            string search = "";
            MyDbContext Db = new MyDbContext();
            NamayeshKala kala = new NamayeshKala();
            kala.dataGridView1.DataSource = Db.ProductRegistrations.Where(x => x.ProductName.Contains(search)).ToList();
        }

        private void نمایشحقوقپرداختیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshHazineEdari edari = new NamayeshHazineEdari();
            edari.Dock = DockStyle.Fill;
            edari.FormBorderStyle = FormBorderStyle.None;
            edari.TopLevel = false;
            groupBox8.Controls.Add(edari);
            groupBox8.Text = "هزینه های اداری";
            edari.Show();
        }

        private void ثبتحقوقجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddHazineEdari edari = new frmAddHazineEdari();
            var Check = mal.SelectShomareHesab();
            if (Check.Success == true)
            {
                for (int i = 0; i < Check.Data.Count; i++)
                {
                    edari.comShomareHesab.Items.Add(Check.Data[i]);
                }
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
            edari.Text = "Save";
            edari.ShowDialog();
        }

        private async void واریزبهحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpt = StiReportHelper.GetReport("ListVarizi.mrt");
            var query = variz.Select();
            if (query.Success == true)
            {
                await Task.Run(() =>
                {
                    rpt.RegData("VarizBeHesab", query.Data.ToList());
                });
                rpt.Show();
            }
            else
            {
                MessageBox.Show(query.Message);
            }
        }

        private void اسناددریافتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpt = StiReportHelper.GetReport("ListAsnadeDaryafti.mrt");
            var query = daryafti.Select();
            if (query.Success == true)
            {
                rpt.RegData("Mstah", query.Data.ToList());
                rpt.Show();
            }
            else
            {
                MessageBox.Show(query.Message);
            }
        }

        private void نمایشهزینههایاداریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            groupBox8.Controls.Clear();
            NamayeshHazineHoghogh hoghogh = new NamayeshHazineHoghogh();
            hoghogh.Dock = DockStyle.Fill;
            hoghogh.FormBorderStyle = FormBorderStyle.None;
            hoghogh.TopLevel = false;
            groupBox8.Controls.Add(hoghogh);
            groupBox8.Text = "حقوق ها";
            hoghogh.Show();
        }

        private void ثبتهزینهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
