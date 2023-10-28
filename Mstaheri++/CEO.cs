using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mstaheri__
{
    public partial class CEO : Form
    {
        CarpetCompanyDAL.CurrentSocket ccdSocket;
        public CEO()
        {
            InitializeComponent();
        }
        List<Socket> Clients;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            SelectEmployee();

            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipe = new IPEndPoint(ip, 1368);
                Socket sServer = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sServer.Bind(ipe);
                sServer.Listen(10);
                var callback = new AsyncCallback(AsyncCallbackAccept);
                sServer.BeginAccept(callback, sServer);
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در برقراری ارتباط با سرور");
            }
            
        }

        void AsyncCallbackAccept(IAsyncResult ar)
        {
           
        }

        void AsyncCallbackReceive(IAsyncResult ar)
        {
            
        }

        public void SelectEmployee()
        {
            CarpetCompanyBLL.Employee emp = new CarpetCompanyBLL.Employee();
            var Check = emp.Select();
            if (Check.Success == true)
            {
                dataGridView1.DataSource = Check.Data;
            }
            else
            {
                MessageBox.Show(Check.Message);
            }
        }
         

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee addEdit = new frmAddEditEmployee();
            addEdit.Text = "Save";
            addEdit.userEmployee.Enabled = true;
            addEdit.button2.Visible = true;
            addEdit.ShowDialog();
            Form2_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            CarpetCompanyBLL.Employee emp = new CarpetCompanyBLL.Employee();
            var Check = emp.Select(search);
            if (Check.Success == false)
            {
                MessageBox.Show(Check.Message);
            }
            else
            {
                dataGridView1.DataSource = Check.Data;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Cursor = Cursors.Hand;
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Delete.Name].Index)
                {
                    if (MessageBox.Show("ایا مطمئن هستید؟","پاک کردن",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string userName = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
                        CarpetCompanyBLL.Employee emp = new CarpetCompanyBLL.Employee();
                        var Check = emp.Delete(userName);
                        if (Check.Success == true)
                        {
                            MessageBox.Show(Check.Message);
                        }
                        else
                        {
                            MessageBox.Show(Check.Message);
                        }
                    }
                }
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns[Edit.Name].Index)
                {
                    string firstName = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                    string lastName = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                    string Phone = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                    string userName = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
                    string passWord = dataGridView1.CurrentRow.Cells["PassWord"].Value.ToString();
                    string jobs = dataGridView1.CurrentRow.Cells["Jobs"].Value.ToString();
                    var Rate1 = dataGridView1.CurrentRow.Cells["access1"].Value;
                    var Rate2 = dataGridView1.CurrentRow.Cells["access2"].Value;
                    var Rate3 = dataGridView1.CurrentRow.Cells["access3"].Value;
                    var Rate4 = dataGridView1.CurrentRow.Cells["access4"].Value;
                    var Rate5 = dataGridView1.CurrentRow.Cells["access5"].Value;
                    frmAddEditEmployee frm = new frmAddEditEmployee();
                    Access ac = new Access();
                    frm.nameEmployee.Text = firstName;
                    frm.lastEmployee.Text = lastName;
                    frm.PhoneEmployee.Text = Phone;
                    frm.userEmployee.Text = userName;
                    frm.passwordEmployee.Text = passWord;
                    frm.jobsEmployee.Text = jobs;
                    ac.checkBox1.Checked = (bool)Rate1;
                    ac.checkBox2.Checked = (bool)Rate2;
                    ac.checkBox3.Checked = (bool)Rate3;
                    ac.checkBox4.Checked = (bool)Rate4;
                    ac.checkBox5.Checked = (bool)Rate5;
                    ac.label1.Text = userName;
                    frm.button2.Visible = false;
                    frm.Text = "Edit";
                    ac.Text = "Edit";
                    frm.userEmployee.Enabled = false;
                    ac.ShowDialog();
                    frm.ShowDialog();
                    
                }
            }
            Form2_Load(sender, e);
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[radif.Name].Value = e.RowIndex + 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightCyan, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("B Nazanin", (float)23.0, FontStyle.Bold, GraphicsUnit.Pixel);
            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            if (tabControl1.RightToLeft == RightToLeft.Yes)
            {
                _stringFlags.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
