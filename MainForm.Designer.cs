namespace budget_manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            expense_btn = new Button();
            income_btn = new Button();
            addCategory_btn = new Button();
            dashboard_btn = new Button();
            greetUser = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            expenseForm1 = new ExpenseForm();
            incomeForm1 = new incomeForm();
            categoryForm1 = new CategoryForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1379, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 12;
            label1.Text = "Income and Expense Tracker";
            // 
            // close
            // 
            close.AutoSize = true;
            close.ForeColor = Color.DarkCyan;
            close.Location = new Point(1351, 9);
            close.Name = "close";
            close.Size = new Size(16, 20);
            close.TabIndex = 11;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkTurquoise;
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(expense_btn);
            panel2.Controls.Add(income_btn);
            panel2.Controls.Add(addCategory_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(greetUser);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 735);
            panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            logout_btn.ForeColor = Color.Navy;
            logout_btn.Location = new Point(24, 641);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(194, 48);
            logout_btn.TabIndex = 4;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // expense_btn
            // 
            expense_btn.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            expense_btn.ForeColor = Color.Navy;
            expense_btn.Location = new Point(24, 447);
            expense_btn.Name = "expense_btn";
            expense_btn.Size = new Size(194, 48);
            expense_btn.TabIndex = 3;
            expense_btn.Text = "Expense";
            expense_btn.UseVisualStyleBackColor = true;
            expense_btn.Click += expense_btn_Click;
            // 
            // income_btn
            // 
            income_btn.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            income_btn.ForeColor = Color.Navy;
            income_btn.Location = new Point(24, 378);
            income_btn.Name = "income_btn";
            income_btn.Size = new Size(194, 48);
            income_btn.TabIndex = 2;
            income_btn.Text = "Income";
            income_btn.UseVisualStyleBackColor = true;
            income_btn.Click += income_btn_Click;
            // 
            // addCategory_btn
            // 
            addCategory_btn.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            addCategory_btn.ForeColor = Color.Navy;
            addCategory_btn.Location = new Point(24, 310);
            addCategory_btn.Name = "addCategory_btn";
            addCategory_btn.Size = new Size(194, 48);
            addCategory_btn.TabIndex = 1;
            addCategory_btn.Text = "Add Category";
            addCategory_btn.UseVisualStyleBackColor = true;
            addCategory_btn.Click += addCategory_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.Navy;
            dashboard_btn.Location = new Point(24, 238);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(194, 48);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // greetUser
            // 
            greetUser.AutoSize = true;
            greetUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            greetUser.ForeColor = Color.Navy;
            greetUser.Location = new Point(42, 187);
            greetUser.Name = "greetUser";
            greetUser.Size = new Size(92, 23);
            greetUser.TabIndex = 0;
            greetUser.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(expenseForm1);
            panel3.Controls.Add(incomeForm1);
            panel3.Controls.Add(categoryForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(260, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(1119, 735);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1431, 935);
            dashboard1.TabIndex = 3;
            // 
            // expenseForm1
            // 
            expenseForm1.Location = new Point(0, 0);
            expenseForm1.Name = "expenseForm1";
            expenseForm1.Size = new Size(1435, 935);
            expenseForm1.TabIndex = 2;
            // 
            // incomeForm1
            // 
            incomeForm1.Location = new Point(0, 0);
            incomeForm1.Name = "incomeForm1";
            incomeForm1.Size = new Size(1435, 935);
            incomeForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            categoryForm1.Location = new Point(0, 0);
            categoryForm1.Name = "categoryForm1";
            categoryForm1.Size = new Size(1435, 935);
            categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 775);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button dashboard_btn;
        private Label greetUser;
        private PictureBox pictureBox1;
        private Button logout_btn;
        private Button expense_btn;
        private Button income_btn;
        private Button addCategory_btn;
        private ExpenseForm expenseForm1;
        private incomeForm incomeForm1;
        private CategoryForm categoryForm1;
        private Dashboard dashboard1;
    }
}