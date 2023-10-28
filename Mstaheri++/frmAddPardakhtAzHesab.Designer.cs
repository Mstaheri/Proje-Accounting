namespace Mstaheri__
{
    partial class frmAddPardakhtAzHesab
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodePardakht = new System.Windows.Forms.TextBox();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamPardakhtKonande = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comShomareHesab = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTarikhPardakht = new Atf.UI.DateTimeSelector();
            this.txtNamHesab = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(677, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 34);
            this.label6.TabIndex = 40;
            this.label6.Text = "تاریخ پرداخت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(677, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 33;
            this.label3.Text = "نام حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(677, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 31;
            this.label2.Text = "کد پرداختی";
            // 
            // txtCodePardakht
            // 
            this.txtCodePardakht.Location = new System.Drawing.Point(449, 30);
            this.txtCodePardakht.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodePardakht.Name = "txtCodePardakht";
            this.txtCodePardakht.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodePardakht.Size = new System.Drawing.Size(222, 42);
            this.txtCodePardakht.TabIndex = 30;
            this.txtCodePardakht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePardakht_KeyPress);
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(33, 257);
            this.txtTozihat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTozihat.Multiline = true;
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTozihat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTozihat.Size = new System.Drawing.Size(638, 82);
            this.txtTozihat.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(677, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 41;
            this.label7.Text = "توضیحات";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(675, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 80);
            this.button1.TabIndex = 23;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(-38, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(842, 124);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(261, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 34);
            this.label5.TabIndex = 37;
            this.label5.Text = "مبلغ پرداختی";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(33, 192);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 42);
            this.txtPrice.TabIndex = 36;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePardakht_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(261, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "نام پرداخت کننده";
            // 
            // txtNamPardakhtKonande
            // 
            this.txtNamPardakhtKonande.Location = new System.Drawing.Point(33, 110);
            this.txtNamPardakhtKonande.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamPardakhtKonande.Name = "txtNamPardakhtKonande";
            this.txtNamPardakhtKonande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamPardakhtKonande.Size = new System.Drawing.Size(222, 42);
            this.txtNamPardakhtKonande.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(261, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "شماره حساب";
            // 
            // comShomareHesab
            // 
            this.comShomareHesab.FormattingEnabled = true;
            this.comShomareHesab.Location = new System.Drawing.Point(33, 30);
            this.comShomareHesab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comShomareHesab.Name = "comShomareHesab";
            this.comShomareHesab.Size = new System.Drawing.Size(222, 42);
            this.comShomareHesab.TabIndex = 43;
            this.comShomareHesab.SelectedIndexChanged += new System.EventHandler(this.comShomareHesab_SelectedIndexChanged);
            this.comShomareHesab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePardakht_KeyPress);
            // 
            // txtTarikhPardakht
            // 
            this.txtTarikhPardakht.Location = new System.Drawing.Point(449, 192);
            this.txtTarikhPardakht.Name = "txtTarikhPardakht";
            this.txtTarikhPardakht.Size = new System.Drawing.Size(222, 43);
            this.txtTarikhPardakht.TabIndex = 44;
            this.txtTarikhPardakht.UsePersianFormat = true;
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
            this.txtNamHesab.Location = new System.Drawing.Point(449, 110);
            this.txtNamHesab.Name = "txtNamHesab";
            this.txtNamHesab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamHesab.Size = new System.Drawing.Size(222, 42);
            this.txtNamHesab.TabIndex = 45;
            // 
            // frmAddPardakhtAzHesab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 488);
            this.Controls.Add(this.txtNamHesab);
            this.Controls.Add(this.txtTarikhPardakht);
            this.Controls.Add(this.comShomareHesab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodePardakht);
            this.Controls.Add(this.txtTozihat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamPardakhtKonande);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAddPardakhtAzHesab";
            this.Text = "frmAddPardakhtAzHesab";
            this.Load += new System.EventHandler(this.frmAddPardakhtAzHesab_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodePardakht;
        public System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNamPardakhtKonande;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comShomareHesab;
        private System.Windows.Forms.ToolTip toolTip1;
        public Atf.UI.DateTimeSelector txtTarikhPardakht;
        public System.Windows.Forms.ComboBox txtNamHesab;
    }
}