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
    public partial class MyTxtAndPic : UserControl
    {
        public MyTxtAndPic()
        {
            InitializeComponent();
            pictureBox1.MouseDown += new MouseEventHandler(MyTxtAndPic_MouseClick);
            label1.MouseDown += new MouseEventHandler(Label1_MouseClick);
            label1.MouseUp += Label1_MouseUp;
            pictureBox1.MouseUp += new MouseEventHandler(MyTxtAndPic_MouseUp);
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            label1.MouseEnter += Label1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
            label1.MouseLeave += Label1_MouseLeave;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            label1.BackColor = Color.White;
            this.BackColor = Color.White;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            label1.BackColor = Color.White;
            this.BackColor = Color.White;
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ColorTranslator.FromHtml("#d5e1f2");
            label1.BackColor = ColorTranslator.FromHtml("#d5e1f2");
            this.BackColor = ColorTranslator.FromHtml("#d5e1f2");

        }
        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ColorTranslator.FromHtml("#d5e1f2");
            label1.BackColor = ColorTranslator.FromHtml("#d5e1f2");
            this.BackColor = ColorTranslator.FromHtml("#d5e1f2");
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
            this.BackColor = Color.White;
        }
        private void MyTxtAndPic_MouseUp(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
            this.BackColor = Color.White;
        }


        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ContextMenuStrip.Show(this, new Point(e.X, e.Y));
                pictureBox1.BackColor = ColorTranslator.FromHtml("#a3bde2");
                label1.BackColor = ColorTranslator.FromHtml("#a3bde2");
                ColorTranslator.FromHtml("#a3bde2");
            }
        }

        private void MyTxtAndPic_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ContextMenuStrip.Show(this, new Point(e.X, e.Y));
                pictureBox1.BackColor = ColorTranslator.FromHtml("#a3bde2");
                label1.BackColor = ColorTranslator.FromHtml("#a3bde2");
                this.BackColor = ColorTranslator.FromHtml("#a3bde2");

            }
        }

        public Image Uploadphoto
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string TextBoxPic
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        private void MyTxtAndPic_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
