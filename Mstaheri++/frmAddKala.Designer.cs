namespace Mstaheri__
{
    partial class frmAddKala
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(388, 23);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(212, 48);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد کالا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کالا";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(25, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(212, 48);
            this.txtProductName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "واحد";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(25, 110);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnit.Size = new System.Drawing.Size(212, 48);
            this.txtUnit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "قیمت خرید";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(388, 197);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(212, 48);
            this.txtPurchasePrice.TabIndex = 6;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "قیمت فروش";
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(25, 197);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(212, 48);
            this.txtSalesPrice.TabIndex = 8;
            this.txtSalesPrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            this.txtSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "بارکد";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(388, 110);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(212, 48);
            this.txtBarCode.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(0, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(739, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(573, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 80);
            this.button2.TabIndex = 11;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAddKala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(737, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductCode);
            this.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmAddKala";
            this.Text = "frmAddCommodity";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtProductCode;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtUnit;
        public System.Windows.Forms.TextBox txtPurchasePrice;
        public System.Windows.Forms.TextBox txtSalesPrice;
        public System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}