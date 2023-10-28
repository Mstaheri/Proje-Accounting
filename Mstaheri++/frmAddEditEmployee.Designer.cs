namespace Mstaheri__
{
    partial class frmAddEditEmployee
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
            this.nameEmployee = new System.Windows.Forms.TextBox();
            this.lastEmployee = new System.Windows.Forms.TextBox();
            this.PhoneEmployee = new System.Windows.Forms.TextBox();
            this.userEmployee = new System.Windows.Forms.TextBox();
            this.passwordEmployee = new System.Windows.Forms.TextBox();
            this.jobsEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameEmployee
            // 
            this.nameEmployee.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameEmployee.Location = new System.Drawing.Point(490, 15);
            this.nameEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameEmployee.Name = "nameEmployee";
            this.nameEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameEmployee.Size = new System.Drawing.Size(287, 42);
            this.nameEmployee.TabIndex = 0;
            // 
            // lastEmployee
            // 
            this.lastEmployee.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lastEmployee.Location = new System.Drawing.Point(40, 22);
            this.lastEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastEmployee.Name = "lastEmployee";
            this.lastEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastEmployee.Size = new System.Drawing.Size(287, 42);
            this.lastEmployee.TabIndex = 1;
            // 
            // PhoneEmployee
            // 
            this.PhoneEmployee.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneEmployee.Location = new System.Drawing.Point(490, 110);
            this.PhoneEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneEmployee.Name = "PhoneEmployee";
            this.PhoneEmployee.Size = new System.Drawing.Size(287, 42);
            this.PhoneEmployee.TabIndex = 2;
            this.PhoneEmployee.TextChanged += new System.EventHandler(this.PhoneEmployee_TextChanged);
            this.PhoneEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneEmployee_KeyPress);
            // 
            // userEmployee
            // 
            this.userEmployee.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userEmployee.Location = new System.Drawing.Point(40, 110);
            this.userEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userEmployee.Name = "userEmployee";
            this.userEmployee.Size = new System.Drawing.Size(287, 42);
            this.userEmployee.TabIndex = 3;
            // 
            // passwordEmployee
            // 
            this.passwordEmployee.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passwordEmployee.Location = new System.Drawing.Point(490, 203);
            this.passwordEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordEmployee.Name = "passwordEmployee";
            this.passwordEmployee.Size = new System.Drawing.Size(287, 42);
            this.passwordEmployee.TabIndex = 4;
            this.passwordEmployee.TextChanged += new System.EventHandler(this.passwordEmployee_TextChanged);
            // 
            // jobsEmployee
            // 
            this.jobsEmployee.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.jobsEmployee.FormattingEnabled = true;
            this.jobsEmployee.Items.AddRange(new object[] {
            "انبار دار",
            "حسابدار"});
            this.jobsEmployee.Location = new System.Drawing.Point(40, 203);
            this.jobsEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jobsEmployee.Name = "jobsEmployee";
            this.jobsEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jobsEmployee.Size = new System.Drawing.Size(287, 42);
            this.jobsEmployee.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(783, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(333, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(783, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "شماره تلفن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(332, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "نام کاربری";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(783, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "رمز عبور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(333, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 41);
            this.label6.TabIndex = 11;
            this.label6.Text = "شغل";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(21, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(714, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "میزان دسترسی";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.jobsEmployee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.passwordEmployee);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.userEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PhoneEmployee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lastEmployee);
            this.groupBox1.Controls.Add(this.nameEmployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 268);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(1, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 102);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // FrmAddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save";
            this.Load += new System.EventHandler(this.FrmAddEditEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox nameEmployee;
        public System.Windows.Forms.TextBox lastEmployee;
        public System.Windows.Forms.TextBox PhoneEmployee;
        public System.Windows.Forms.TextBox userEmployee;
        public System.Windows.Forms.TextBox passwordEmployee;
        public System.Windows.Forms.ComboBox jobsEmployee;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}