namespace budget_manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_signupBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            close = new Label();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label3 = new Label();
            login_btn = new Button();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 648);
            panel1.TabIndex = 0;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.White;
            login_signupBtn.BackgroundImageLayout = ImageLayout.Center;
            login_signupBtn.FlatStyle = FlatStyle.Popup;
            login_signupBtn.Font = new Font("Segoe UI", 11F);
            login_signupBtn.ForeColor = Color.FromArgb(8, 131, 149);
            login_signupBtn.Location = new Point(65, 544);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(194, 49);
            login_signupBtn.TabIndex = 8;
            login_signupBtn.Text = "SIGN UP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(79, 505);
            label5.Name = "label5";
            label5.Size = new Size(167, 23);
            label5.TabIndex = 7;
            label5.Text = "REGISTER HERE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 269);
            label4.Name = "label4";
            label4.Size = new Size(212, 20);
            label4.TabIndex = 7;
            label4.Text = "Budget Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Location = new Point(825, 9);
            close.Name = "close";
            close.Size = new Size(16, 20);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 13F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(387, 106);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 2;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(383, 162);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // login_username
            // 
            login_username.BackColor = Color.Gainsboro;
            login_username.Location = new Point(381, 204);
            login_username.Name = "login_username";
            login_username.Size = new Size(237, 27);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.BackColor = Color.Gainsboro;
            login_password.Location = new Point(385, 311);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(237, 27);
            login_password.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(387, 269);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.FlatStyle = FlatStyle.Popup;
            login_btn.Font = new Font("Segoe UI", 11F);
            login_btn.ForeColor = Color.FromArgb(8, 131, 149);
            login_btn.Location = new Point(387, 462);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(194, 49);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.ForeColor = Color.Navy;
            login_showPass.Location = new Point(664, 387);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(137, 23);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 648);
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label3);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label1;
        private Button login_signupBtn;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox login_username;
        private TextBox login_password;
        private Label label3;
        private Button login_btn;
        private CheckBox login_showPass;
    }
}
