namespace Mstaheri__
{
    partial class frmAddHazineEdari
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTarikhPardakht = new Atf.UI.DateTimeSelector();
            this.comShomareHesab = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamHazine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeHazine = new System.Windows.Forms.TextBox();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(0, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(810, 124);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(632, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 80);
            this.button2.TabIndex = 23;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTarikhPardakht
            // 
            this.txtTarikhPardakht.Location = new System.Drawing.Point(30, 105);
            this.txtTarikhPardakht.Name = "txtTarikhPardakht";
            this.txtTarikhPardakht.Size = new System.Drawing.Size(222, 49);
            this.txtTarikhPardakht.TabIndex = 73;
            this.txtTarikhPardakht.UsePersianFormat = true;
            // 
            // comShomareHesab
            // 
            this.comShomareHesab.FormattingEnabled = true;
            this.comShomareHesab.Location = new System.Drawing.Point(30, 25);
            this.comShomareHesab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comShomareHesab.Name = "comShomareHesab";
            this.comShomareHesab.Size = new System.Drawing.Size(222, 48);
            this.comShomareHesab.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(258, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 41);
            this.label6.TabIndex = 70;
            this.label6.Text = "تاریخ پرداخت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(674, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 41);
            this.label3.TabIndex = 65;
            this.label3.Text = "نام هزینه";
            // 
            // txtNamHazine
            // 
            this.txtNamHazine.Location = new System.Drawing.Point(446, 105);
            this.txtNamHazine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamHazine.Name = "txtNamHazine";
            this.txtNamHazine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamHazine.Size = new System.Drawing.Size(222, 48);
            this.txtNamHazine.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(674, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 63;
            this.label2.Text = "کد هزینه";
            // 
            // txtCodeHazine
            // 
            this.txtCodeHazine.Location = new System.Drawing.Point(446, 25);
            this.txtCodeHazine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodeHazine.Name = "txtCodeHazine";
            this.txtCodeHazine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeHazine.Size = new System.Drawing.Size(222, 48);
            this.txtCodeHazine.TabIndex = 62;
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(30, 260);
            this.txtTozihat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTozihat.Multiline = true;
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTozihat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTozihat.Size = new System.Drawing.Size(638, 82);
            this.txtTozihat.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(674, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 41);
            this.label7.TabIndex = 71;
            this.label7.Text = "توضیحات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(674, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 41);
            this.label5.TabIndex = 68;
            this.label5.Text = "مبلغ پرداختی";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(446, 188);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 48);
            this.txtPrice.TabIndex = 67;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(258, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 41);
            this.label1.TabIndex = 61;
            this.label1.Text = "شماره حساب";
            // 
            // frmAddHazineEdari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 492);
            this.Controls.Add(this.txtTarikhPardakht);
            this.Controls.Add(this.comShomareHesab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamHazine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodeHazine);
            this.Controls.Add(this.txtTozihat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmAddHazineEdari";
            this.Text = "Save";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        public Atf.UI.DateTimeSelector txtTarikhPardakht;
        public System.Windows.Forms.ComboBox comShomareHesab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNamHazine;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodeHazine;
        public System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}