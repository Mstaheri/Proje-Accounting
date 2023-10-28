namespace Mstaheri__
{
    partial class NamayeshHesabTafsili
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeTafsili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnvanTafsili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeMoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesabMoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletee = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(189)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(189)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tedad,
            this.CodeTafsili,
            this.OnvanTafsili,
            this.CodeMoin,
            this.HesabMoin,
            this.Deletee});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 583);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // tedad
            // 
            this.tedad.FillWeight = 36.15365F;
            this.tedad.HeaderText = "";
            this.tedad.MinimumWidth = 6;
            this.tedad.Name = "tedad";
            this.tedad.ReadOnly = true;
            this.tedad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CodeTafsili
            // 
            this.CodeTafsili.DataPropertyName = "CodeTafsili";
            this.CodeTafsili.FillWeight = 96.77999F;
            this.CodeTafsili.HeaderText = "کد";
            this.CodeTafsili.MinimumWidth = 6;
            this.CodeTafsili.Name = "CodeTafsili";
            this.CodeTafsili.ReadOnly = true;
            // 
            // OnvanTafsili
            // 
            this.OnvanTafsili.DataPropertyName = "OnvanTafsili";
            this.OnvanTafsili.FillWeight = 161.6325F;
            this.OnvanTafsili.HeaderText = "عنوان تفصیلی";
            this.OnvanTafsili.MinimumWidth = 6;
            this.OnvanTafsili.Name = "OnvanTafsili";
            this.OnvanTafsili.ReadOnly = true;
            // 
            // CodeMoin
            // 
            this.CodeMoin.DataPropertyName = "CodeMoin";
            this.CodeMoin.HeaderText = "کد معین";
            this.CodeMoin.MinimumWidth = 6;
            this.CodeMoin.Name = "CodeMoin";
            this.CodeMoin.ReadOnly = true;
            this.CodeMoin.Visible = false;
            // 
            // HesabMoin
            // 
            this.HesabMoin.DataPropertyName = "HesabMoin";
            this.HesabMoin.HeaderText = "حساب معین";
            this.HesabMoin.MinimumWidth = 6;
            this.HesabMoin.Name = "HesabMoin";
            this.HesabMoin.ReadOnly = true;
            this.HesabMoin.Visible = false;
            // 
            // Deletee
            // 
            this.Deletee.FillWeight = 56.28653F;
            this.Deletee.HeaderText = "حذف";
            this.Deletee.MinimumWidth = 6;
            this.Deletee.Name = "Deletee";
            this.Deletee.ReadOnly = true;
            // 
            // NamayeshHesabTafsili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 583);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NamayeshHesabTafsili";
            this.Text = "NamayeshHesabTafsili";
            this.Load += new System.EventHandler(this.NamayeshHesabTafsili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeTafsili;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnvanTafsili;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeMoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesabMoin;
        private System.Windows.Forms.DataGridViewButtonColumn Deletee;
    }
}