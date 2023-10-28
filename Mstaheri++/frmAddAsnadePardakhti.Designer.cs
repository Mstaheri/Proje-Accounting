namespace Mstaheri__
{
    partial class frmAddAsnadePardakhti
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
            this.label10 = new System.Windows.Forms.Label();
            this.comVaziat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comShomareHesab = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDaryaft = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShomareSenad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeSenad = new System.Windows.Forms.TextBox();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTarikhSabt = new Atf.UI.DateTimeSelector();
            this.txtTarikhSarResid = new Atf.UI.DateTimeSelector();
            this.txtNamHesab = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(774, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 34);
            this.label10.TabIndex = 85;
            this.label10.Text = "وضعیت";
            // 
            // comVaziat
            // 
            this.comVaziat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comVaziat.FormattingEnabled = true;
            this.comVaziat.Items.AddRange(new object[] {
            "وصول شده",
            "در جریان وصول",
            "برگشت خورده"});
            this.comVaziat.Location = new System.Drawing.Point(508, 299);
            this.comVaziat.Margin = new System.Windows.Forms.Padding(4);
            this.comVaziat.Name = "comVaziat";
            this.comVaziat.Size = new System.Drawing.Size(258, 42);
            this.comVaziat.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(292, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 34);
            this.label9.TabIndex = 83;
            this.label9.Text = "تاریخ سر رسید";
            // 
            // comShomareHesab
            // 
            this.comShomareHesab.FormattingEnabled = true;
            this.comShomareHesab.Location = new System.Drawing.Point(26, 22);
            this.comShomareHesab.Margin = new System.Windows.Forms.Padding(4);
            this.comShomareHesab.Name = "comShomareHesab";
            this.comShomareHesab.Size = new System.Drawing.Size(258, 42);
            this.comShomareHesab.TabIndex = 79;
            this.comShomareHesab.SelectedIndexChanged += new System.EventHandler(this.comShomareHesab_SelectedIndexChanged);
            this.comShomareHesab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeSenad_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 476);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(907, 104);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(726, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 72);
            this.button1.TabIndex = 23;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(292, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 34);
            this.label5.TabIndex = 73;
            this.label5.Text = "مبلغ سند";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(26, 160);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(258, 42);
            this.txtPrice.TabIndex = 72;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeSenad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(292, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 71;
            this.label4.Text = "پرداخت به";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDaryaft
            // 
            this.txtDaryaft.Location = new System.Drawing.Point(26, 92);
            this.txtDaryaft.Margin = new System.Windows.Forms.Padding(4);
            this.txtDaryaft.Name = "txtDaryaft";
            this.txtDaryaft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDaryaft.Size = new System.Drawing.Size(258, 42);
            this.txtDaryaft.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(778, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 34);
            this.label8.TabIndex = 81;
            this.label8.Text = "شماره سند";
            // 
            // txtShomareSenad
            // 
            this.txtShomareSenad.Location = new System.Drawing.Point(508, 156);
            this.txtShomareSenad.Margin = new System.Windows.Forms.Padding(4);
            this.txtShomareSenad.Name = "txtShomareSenad";
            this.txtShomareSenad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShomareSenad.Size = new System.Drawing.Size(258, 42);
            this.txtShomareSenad.TabIndex = 80;
            this.txtShomareSenad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeSenad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(774, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 34);
            this.label6.TabIndex = 76;
            this.label6.Text = "تاریخ ثبت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(778, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 69;
            this.label3.Text = "نام حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(778, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 67;
            this.label2.Text = "کد سند";
            // 
            // txtCodeSenad
            // 
            this.txtCodeSenad.Location = new System.Drawing.Point(508, 19);
            this.txtCodeSenad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeSenad.Name = "txtCodeSenad";
            this.txtCodeSenad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeSenad.Size = new System.Drawing.Size(258, 42);
            this.txtCodeSenad.TabIndex = 66;
            this.txtCodeSenad.TextChanged += new System.EventHandler(this.txtCodeSenad_TextChanged);
            this.txtCodeSenad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeSenad_KeyPress);
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(26, 361);
            this.txtTozihat.Margin = new System.Windows.Forms.Padding(4);
            this.txtTozihat.Multiline = true;
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTozihat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTozihat.Size = new System.Drawing.Size(740, 97);
            this.txtTozihat.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(774, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 77;
            this.label7.Text = "توضیحات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(292, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 65;
            this.label1.Text = "شماره حساب";
            // 
            // txtTarikhSabt
            // 
            this.txtTarikhSabt.Location = new System.Drawing.Point(508, 229);
            this.txtTarikhSabt.Name = "txtTarikhSabt";
            this.txtTarikhSabt.Size = new System.Drawing.Size(258, 43);
            this.txtTarikhSabt.TabIndex = 86;
            this.txtTarikhSabt.UsePersianFormat = true;
            // 
            // txtTarikhSarResid
            // 
            this.txtTarikhSarResid.Location = new System.Drawing.Point(26, 229);
            this.txtTarikhSarResid.Name = "txtTarikhSarResid";
            this.txtTarikhSarResid.Size = new System.Drawing.Size(258, 43);
            this.txtTarikhSarResid.TabIndex = 87;
            this.txtTarikhSarResid.UsePersianFormat = true;
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
            this.txtNamHesab.Location = new System.Drawing.Point(508, 92);
            this.txtNamHesab.Name = "txtNamHesab";
            this.txtNamHesab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamHesab.Size = new System.Drawing.Size(258, 42);
            this.txtNamHesab.TabIndex = 88;
            // 
            // frmAddAsnadePardakhti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(905, 581);
            this.Controls.Add(this.txtNamHesab);
            this.Controls.Add(this.txtTarikhSarResid);
            this.Controls.Add(this.txtTarikhSabt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comVaziat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comShomareHesab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDaryaft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShomareSenad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodeSenad);
            this.Controls.Add(this.txtTozihat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAddAsnadePardakhti";
            this.Text = "frmAddAsnadePardakhti";
            this.Load += new System.EventHandler(this.frmAddAsnadePardakhti_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comVaziat;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comShomareHesab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDaryaft;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtShomareSenad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodeSenad;
        public System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        public Atf.UI.DateTimeSelector txtTarikhSabt;
        public Atf.UI.DateTimeSelector txtTarikhSarResid;
        public System.Windows.Forms.ComboBox txtNamHesab;
    }
}