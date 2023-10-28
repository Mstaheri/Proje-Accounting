namespace Mstaheri__
{
    partial class NamayeshVarizBeHesab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tedadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeVariz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShomareHesabb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamVarizKonande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarikhVarizi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleteee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HesabMali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tedadd,
            this.CodeVariz,
            this.ShomareHesabb,
            this.dataGridViewTextBoxColumn4,
            this.NamVarizKonande,
            this.TarikhVarizi,
            this.price,
            this.dataGridViewTextBoxColumn6,
            this.Deleteee,
            this.HesabMali});
            this.dataGridView2.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1292, 459);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // tedadd
            // 
            this.tedadd.FillWeight = 31.77252F;
            this.tedadd.HeaderText = "";
            this.tedadd.MinimumWidth = 6;
            this.tedadd.Name = "tedadd";
            this.tedadd.ReadOnly = true;
            // 
            // CodeVariz
            // 
            this.CodeVariz.DataPropertyName = "CodeVariz";
            this.CodeVariz.FillWeight = 77.53612F;
            this.CodeVariz.HeaderText = "کد واریز";
            this.CodeVariz.MinimumWidth = 6;
            this.CodeVariz.Name = "CodeVariz";
            this.CodeVariz.ReadOnly = true;
            // 
            // ShomareHesabb
            // 
            this.ShomareHesabb.DataPropertyName = "ShomareHesab";
            this.ShomareHesabb.FillWeight = 135.6803F;
            this.ShomareHesabb.HeaderText = "شماره حساب";
            this.ShomareHesabb.MinimumWidth = 6;
            this.ShomareHesabb.Name = "ShomareHesabb";
            this.ShomareHesabb.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NamHesab";
            this.dataGridViewTextBoxColumn4.FillWeight = 94.87587F;
            this.dataGridViewTextBoxColumn4.HeaderText = "نام حساب";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // NamVarizKonande
            // 
            this.NamVarizKonande.DataPropertyName = "NamVarizKonande";
            this.NamVarizKonande.FillWeight = 142.1993F;
            this.NamVarizKonande.HeaderText = "نام واریز کننده";
            this.NamVarizKonande.MinimumWidth = 6;
            this.NamVarizKonande.Name = "NamVarizKonande";
            this.NamVarizKonande.ReadOnly = true;
            // 
            // TarikhVarizi
            // 
            this.TarikhVarizi.DataPropertyName = "TarikhVarizi";
            this.TarikhVarizi.FillWeight = 97.7598F;
            this.TarikhVarizi.HeaderText = "تاریخ";
            this.TarikhVarizi.MinimumWidth = 6;
            this.TarikhVarizi.Name = "TarikhVarizi";
            this.TarikhVarizi.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 137.1483F;
            this.price.HeaderText = "مبلغ واریزی";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tozihat";
            this.dataGridViewTextBoxColumn6.FillWeight = 108.7211F;
            this.dataGridViewTextBoxColumn6.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Deleteee
            // 
            this.Deleteee.FillWeight = 80.45708F;
            this.Deleteee.HeaderText = "حذف";
            this.Deleteee.MinimumWidth = 6;
            this.Deleteee.Name = "Deleteee";
            this.Deleteee.ReadOnly = true;
            // 
            // HesabMali
            // 
            this.HesabMali.DataPropertyName = "HesabMali";
            this.HesabMali.HeaderText = "Column1";
            this.HesabMali.MinimumWidth = 6;
            this.HesabMali.Name = "HesabMali";
            this.HesabMali.ReadOnly = true;
            this.HesabMali.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.button1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1021, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = "واریز به حساب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NamayeshVarizBeHesab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1290, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NamayeshVarizBeHesab";
            this.Text = "NamayeshVarizBeHesab";
            this.Load += new System.EventHandler(this.NamayeshVarizBeHesab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeVariz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShomareHesabb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamVarizKonande;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarikhVarizi;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Deleteee;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesabMali;
        private System.Windows.Forms.Button button1;
    }
}