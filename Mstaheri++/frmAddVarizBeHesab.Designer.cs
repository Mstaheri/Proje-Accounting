namespace Mstaheri__
{
    partial class frmAddVarizBeHesab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamVarizKonande = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeVariz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTarikhVarizi = new Atf.UI.DateTimeSelector();
            this.comShomareHesab = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNamHesab = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(639, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 80);
            this.button1.TabIndex = 23;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(35, 264);
            this.txtTozihat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTozihat.Multiline = true;
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTozihat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTozihat.Size = new System.Drawing.Size(638, 79);
            this.txtTozihat.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(263, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "مبلغ واریزی";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(35, 195);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 42);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.TextChanged += new System.EventHandler(this.frmAddVarizBeHesab_Load);
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVariz_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(263, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 34);
            this.label4.TabIndex = 19;
            this.label4.Text = "نام واریز کننده";
            // 
            // txtNamVarizKonande
            // 
            this.txtNamVarizKonande.Location = new System.Drawing.Point(35, 115);
            this.txtNamVarizKonande.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamVarizKonande.Name = "txtNamVarizKonande";
            this.txtNamVarizKonande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamVarizKonande.Size = new System.Drawing.Size(222, 42);
            this.txtNamVarizKonande.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(679, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "نام حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(679, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "کد واریزی";
            // 
            // txtCodeVariz
            // 
            this.txtCodeVariz.Location = new System.Drawing.Point(451, 33);
            this.txtCodeVariz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodeVariz.Name = "txtCodeVariz";
            this.txtCodeVariz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeVariz.Size = new System.Drawing.Size(222, 42);
            this.txtCodeVariz.TabIndex = 14;
            this.txtCodeVariz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVariz_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(263, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "شماره حساب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(679, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "تاریخ واریز";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(679, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "توضیحات";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 365);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(813, 127);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txtTarikhVarizi
            // 
            this.txtTarikhVarizi.Location = new System.Drawing.Point(451, 195);
            this.txtTarikhVarizi.Name = "txtTarikhVarizi";
            this.txtTarikhVarizi.Size = new System.Drawing.Size(222, 43);
            this.txtTarikhVarizi.TabIndex = 45;
            this.txtTarikhVarizi.UsePersianFormat = true;
            // 
            // comShomareHesab
            // 
            this.comShomareHesab.FormattingEnabled = true;
            this.comShomareHesab.Location = new System.Drawing.Point(35, 33);
            this.comShomareHesab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comShomareHesab.Name = "comShomareHesab";
            this.comShomareHesab.Size = new System.Drawing.Size(222, 42);
            this.comShomareHesab.TabIndex = 44;
            this.comShomareHesab.SelectedIndexChanged += new System.EventHandler(this.comShomareHesab_SelectedIndexChanged);
            this.comShomareHesab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeVariz_KeyPress);
            // 
            // txtNamHesab
            // 
            this.txtNamHesab.FormattingEnabled = true;
            this.txtNamHesab.Items.AddRange(new object[] {
            "حساب جاری",
            "حساب پس‌انداز",
            "حساب قرض‌الحسنه",
            "حساب سرمایه‌گذاری",
            "حساب تسهیلات",
            "حساب جاری بدون بهره",
            "حساب سپرده‌گذاری"});
            this.txtNamHesab.Location = new System.Drawing.Point(451, 115);
            this.txtNamHesab.Name = "txtNamHesab";
            this.txtNamHesab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamHesab.Size = new System.Drawing.Size(222, 42);
            this.txtNamHesab.TabIndex = 46;
            // 
            // frmAddVarizBeHesab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 484);
            this.Controls.Add(this.txtNamHesab);
            this.Controls.Add(this.txtTarikhVarizi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodeVariz);
            this.Controls.Add(this.txtTozihat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comShomareHesab);
            this.Controls.Add(this.txtNamVarizKonande);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAddVarizBeHesab";
            this.Text = "frmAddVarizBeHesab";
            this.Load += new System.EventHandler(this.frmAddVarizBeHesab_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNamVarizKonande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodeVariz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comShomareHesab;
        private System.Windows.Forms.ToolTip toolTip1;
        public Atf.UI.DateTimeSelector txtTarikhVarizi;
        public System.Windows.Forms.ComboBox txtNamHesab;
    }
}