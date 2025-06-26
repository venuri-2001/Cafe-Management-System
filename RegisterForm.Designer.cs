namespace cmsystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.Register_loginbtn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Register_showpass = new System.Windows.Forms.CheckBox();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Register_Username = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Register_cPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.Register_loginbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 484);
            this.panel1.TabIndex = 1;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(91, 194);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(153, 29);
            this.lbl6.TabIndex = 12;
            this.lbl6.Text = "Cafe Master";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(69, 397);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(206, 18);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Already have  an Account?";
            // 
            // Register_loginbtn
            // 
            this.Register_loginbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Register_loginbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_loginbtn.ForeColor = System.Drawing.Color.White;
            this.Register_loginbtn.Location = new System.Drawing.Point(26, 422);
            this.Register_loginbtn.Name = "Register_loginbtn";
            this.Register_loginbtn.Size = new System.Drawing.Size(283, 38);
            this.Register_loginbtn.TabIndex = 9;
            this.Register_loginbtn.Text = "SIGN IN";
            this.Register_loginbtn.UseVisualStyleBackColor = false;
            this.Register_loginbtn.Click += new System.EventHandler(this.Register_loginbtn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.Teal;
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.ForeColor = System.Drawing.Color.White;
            this.Register_btn.Location = new System.Drawing.Point(384, 376);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(75, 35);
            this.Register_btn.TabIndex = 19;
            this.Register_btn.Text = "SIGNUP";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Register_showpass
            // 
            this.Register_showpass.AutoSize = true;
            this.Register_showpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_showpass.Location = new System.Drawing.Point(382, 323);
            this.Register_showpass.Name = "Register_showpass";
            this.Register_showpass.Size = new System.Drawing.Size(111, 16);
            this.Register_showpass.TabIndex = 18;
            this.Register_showpass.Text = "Show Password";
            this.Register_showpass.UseVisualStyleBackColor = true;
            this.Register_showpass.CheckedChanged += new System.EventHandler(this.Register_showpass_CheckedChanged);
            // 
            // Register_Password
            // 
            this.Register_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Password.Location = new System.Drawing.Point(381, 226);
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.PasswordChar = '*';
            this.Register_Password.Size = new System.Drawing.Size(252, 26);
            this.Register_Password.TabIndex = 17;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(379, 205);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(75, 15);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Password:";
            // 
            // Register_Username
            // 
            this.Register_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Username.Location = new System.Drawing.Point(380, 159);
            this.Register_Username.Name = "Register_Username";
            this.Register_Username.Size = new System.Drawing.Size(252, 26);
            this.Register_Username.TabIndex = 15;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(378, 138);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(81, 15);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "User name:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(376, 89);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 24);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "SIGN IN";
            // 
            // Register_cPassword
            // 
            this.Register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_cPassword.Location = new System.Drawing.Point(380, 291);
            this.Register_cPassword.Name = "Register_cPassword";
            this.Register_cPassword.PasswordChar = '*';
            this.Register_cPassword.Size = new System.Drawing.Size(252, 26);
            this.Register_cPassword.TabIndex = 21;
            this.Register_cPassword.TextChanged += new System.EventHandler(this.Register_cPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm Password:";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(665, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(14, 13);
            this.close.TabIndex = 22;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 484);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Register_cPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Register_showpass);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.Register_Password);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.Register_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button Register_loginbtn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.CheckBox Register_showpass;
        private System.Windows.Forms.TextBox Register_Password;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox Register_Username;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox Register_cPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
    }
}