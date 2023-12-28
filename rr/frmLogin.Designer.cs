
namespace rr
{
    partial class frmLogin
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
            this.CreateAccountLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.UserPassordLbl = new System.Windows.Forms.Label();
            this.TxtBoxUserName = new System.Windows.Forms.TextBox();
            this.userLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChekBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.ChekBoxAdmin = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAccountLbl
            // 
            this.CreateAccountLbl.AutoSize = true;
            this.CreateAccountLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.CreateAccountLbl.Location = new System.Drawing.Point(132, 398);
            this.CreateAccountLbl.Name = "CreateAccountLbl";
            this.CreateAccountLbl.Size = new System.Drawing.Size(101, 17);
            this.CreateAccountLbl.TabIndex = 28;
            this.CreateAccountLbl.Text = "Create Account";
            this.CreateAccountLbl.Click += new System.EventHandler(this.CreateAccountLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Dont have An account";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(75, 309);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(216, 35);
            this.LoginBtn.TabIndex = 27;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.TxtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPassword.Location = new System.Drawing.Point(47, 239);
            this.TxtBoxPassword.Multiline = true;
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '●';
            this.TxtBoxPassword.Size = new System.Drawing.Size(288, 37);
            this.TxtBoxPassword.TabIndex = 24;
            // 
            // UserPassordLbl
            // 
            this.UserPassordLbl.AutoSize = true;
            this.UserPassordLbl.Location = new System.Drawing.Point(49, 219);
            this.UserPassordLbl.Name = "UserPassordLbl";
            this.UserPassordLbl.Size = new System.Drawing.Size(66, 17);
            this.UserPassordLbl.TabIndex = 23;
            this.UserPassordLbl.Text = "Password";
            // 
            // TxtBoxUserName
            // 
            this.TxtBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.TxtBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxUserName.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxUserName.Location = new System.Drawing.Point(47, 169);
            this.TxtBoxUserName.Multiline = true;
            this.TxtBoxUserName.Name = "TxtBoxUserName";
            this.TxtBoxUserName.Size = new System.Drawing.Size(288, 37);
            this.TxtBoxUserName.TabIndex = 22;
            this.TxtBoxUserName.TextChanged += new System.EventHandler(this.TxtBoxUserName_TextChanged);
            // 
            // userLable
            // 
            this.userLable.AutoSize = true;
            this.userLable.Location = new System.Drawing.Point(44, 139);
            this.userLable.Name = "userLable";
            this.userLable.Size = new System.Drawing.Size(71, 17);
            this.userLable.TabIndex = 21;
            this.userLable.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(70, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Get started";
            // 
            // ChekBoxShowPassword
            // 
            this.ChekBoxShowPassword.AutoSize = true;
            this.ChekBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChekBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChekBoxShowPassword.Location = new System.Drawing.Point(216, 282);
            this.ChekBoxShowPassword.Name = "ChekBoxShowPassword";
            this.ChekBoxShowPassword.Size = new System.Drawing.Size(119, 21);
            this.ChekBoxShowPassword.TabIndex = 41;
            this.ChekBoxShowPassword.Text = "Show Password";
            this.ChekBoxShowPassword.UseVisualStyleBackColor = true;
            this.ChekBoxShowPassword.CheckedChanged += new System.EventHandler(this.ChekBoxShowPassword_CheckedChanged);
            // 
            // ChekBoxAdmin
            // 
            this.ChekBoxAdmin.AutoSize = true;
            this.ChekBoxAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChekBoxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChekBoxAdmin.Location = new System.Drawing.Point(47, 282);
            this.ChekBoxAdmin.Name = "ChekBoxAdmin";
            this.ChekBoxAdmin.Size = new System.Drawing.Size(119, 21);
            this.ChekBoxAdmin.TabIndex = 41;
            this.ChekBoxAdmin.Text = "Login as admin";
            this.ChekBoxAdmin.UseVisualStyleBackColor = true;
            this.ChekBoxAdmin.CheckedChanged += new System.EventHandler(this.ChekBoxAdmin_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::rr.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(315, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChekBoxAdmin);
            this.Controls.Add(this.ChekBoxShowPassword);
            this.Controls.Add(this.CreateAccountLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.UserPassordLbl);
            this.Controls.Add(this.TxtBoxUserName);
            this.Controls.Add(this.userLable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateAccountLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Label UserPassordLbl;
        private System.Windows.Forms.TextBox TxtBoxUserName;
        private System.Windows.Forms.Label userLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChekBoxShowPassword;
        private System.Windows.Forms.CheckBox ChekBoxAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}