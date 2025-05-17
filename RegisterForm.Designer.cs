namespace budget_manager
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
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            register_loginBtn = new Button();
            label5 = new Label();
            register_showPass = new CheckBox();
            register_btn = new Button();
            register_password = new TextBox();
            label3 = new Label();
            register_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            close = new Label();
            register_cPass = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 648);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(60, 269);
            label4.Name = "label4";
            label4.Size = new Size(212, 20);
            label4.TabIndex = 9;
            label4.Text = "Budget Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // register_loginBtn
            // 
            register_loginBtn.Font = new Font("Segoe UI", 11F);
            register_loginBtn.ForeColor = Color.FromArgb(8, 131, 149);
            register_loginBtn.Location = new Point(66, 541);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(194, 49);
            register_loginBtn.TabIndex = 8;
            register_loginBtn.Text = "SIGN IN";
            register_loginBtn.UseVisualStyleBackColor = true;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(85, 502);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 7;
            label5.Text = "SIGN IN HERE";
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Times New Roman", 10.8F);
            register_showPass.ForeColor = Color.Navy;
            register_showPass.Location = new Point(665, 435);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(147, 24);
            register_showPass.TabIndex = 17;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.Font = new Font("Segoe UI", 11F);
            register_btn.ForeColor = Color.FromArgb(8, 131, 149);
            register_btn.Location = new Point(391, 490);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(194, 49);
            register_btn.TabIndex = 16;
            register_btn.Text = "SIGNUP";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.BackColor = Color.LightGray;
            register_password.Location = new Point(400, 280);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(237, 27);
            register_password.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(396, 248);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // register_username
            // 
            register_username.BackColor = Color.LightGray;
            register_username.Location = new Point(398, 197);
            register_username.Name = "register_username";
            register_username.Size = new Size(237, 27);
            register_username.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(393, 162);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(397, 106);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 11;
            label1.Text = "REGISTER";
            // 
            // close
            // 
            close.AutoSize = true;
            close.ForeColor = Color.Navy;
            close.Location = new Point(826, 8);
            close.Name = "close";
            close.Size = new Size(16, 20);
            close.TabIndex = 10;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // register_cPass
            // 
            register_cPass.BackColor = Color.LightGray;
            register_cPass.Location = new Point(400, 371);
            register_cPass.Name = "register_cPass";
            register_cPass.PasswordChar = '*';
            register_cPass.Size = new Size(237, 27);
            register_cPass.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(400, 332);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 18;
            label6.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 648);
            Controls.Add(register_cPass);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(register_showPass);
            Controls.Add(register_btn);
            Controls.Add(register_password);
            Controls.Add(label3);
            Controls.Add(register_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button register_loginBtn;
        private Label label5;
        private CheckBox register_showPass;
        private Button register_btn;
        private TextBox register_password;
        private Label label3;
        private TextBox register_username;
        private Label label2;
        private Label label1;
        private Label close;
        private TextBox register_cPass;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox1;
    }
}