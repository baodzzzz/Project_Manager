namespace Project_Manager
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPDOb = new System.Windows.Forms.DateTimePicker();
            this.male = new System.Windows.Forms.RadioButton();
            this.fmale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(251, 46);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(222, 23);
            this.tbFullName.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(251, 75);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(222, 23);
            this.tbUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(251, 104);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(222, 23);
            this.tbPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // tbRePassword
            // 
            this.tbRePassword.Location = new System.Drawing.Point(251, 133);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '*';
            this.tbRePassword.Size = new System.Drawing.Size(222, 23);
            this.tbRePassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(251, 162);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(222, 23);
            this.tbEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(251, 191);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(222, 23);
            this.tbMobile.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbCd
            // 
            this.tbCd.Location = new System.Drawing.Point(251, 220);
            this.tbCd.Name = "tbCd";
            this.tbCd.Size = new System.Drawing.Size(222, 23);
            this.tbCd.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Căn cước công dân";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(251, 249);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(222, 23);
            this.tbAdress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Giới tính";
            // 
            // dtPDOb
            // 
            this.dtPDOb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPDOb.Location = new System.Drawing.Point(251, 280);
            this.dtPDOb.Name = "dtPDOb";
            this.dtPDOb.Size = new System.Drawing.Size(221, 23);
            this.dtPDOb.TabIndex = 19;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(255, 322);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(51, 19);
            this.male.TabIndex = 20;
            this.male.TabStop = true;
            this.male.Text = "Nam";
            this.male.UseVisualStyleBackColor = true;
            // 
            // fmale
            // 
            this.fmale.AutoSize = true;
            this.fmale.Location = new System.Drawing.Point(359, 322);
            this.fmale.Name = "fmale";
            this.fmale.Size = new System.Drawing.Size(41, 19);
            this.fmale.TabIndex = 21;
            this.fmale.TabStop = true;
            this.fmale.Text = "Nữ";
            this.fmale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fmale);
            this.Controls.Add(this.male);
            this.Controls.Add(this.dtPDOb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbFullName;
        private TextBox tbUserName;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbRePassword;
        private Label label4;
        private TextBox tbEmail;
        private Label label5;
        private TextBox tbMobile;
        private Label label6;
        private TextBox tbCd;
        private Label label7;
        private TextBox tbAdress;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtPDOb;
        private RadioButton male;
        private RadioButton fmale;
        private Button button1;
        private Button button2;
    }
}