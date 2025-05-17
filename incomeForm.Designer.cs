namespace budget_manager
{
    partial class incomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            income_clearBtn = new Button();
            income_deleteBtn = new Button();
            income_updateBtn = new Button();
            income_addBtn = new Button();
            income_item = new TextBox();
            income_income = new TextBox();
            income_description = new TextBox();
            income_date = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            income_category = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 395);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(36, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1026, 324);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(36, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Income List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(income_clearBtn);
            panel2.Controls.Add(income_deleteBtn);
            panel2.Controls.Add(income_updateBtn);
            panel2.Controls.Add(income_addBtn);
            panel2.Controls.Add(income_item);
            panel2.Controls.Add(income_income);
            panel2.Controls.Add(income_description);
            panel2.Controls.Add(income_date);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(income_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(37, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 292);
            panel2.TabIndex = 1;
            // 
            // income_clearBtn
            // 
            income_clearBtn.BackColor = Color.DarkTurquoise;
            income_clearBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            income_clearBtn.Location = new Point(791, 204);
            income_clearBtn.Name = "income_clearBtn";
            income_clearBtn.Size = new Size(95, 65);
            income_clearBtn.TabIndex = 13;
            income_clearBtn.Text = "Clear";
            income_clearBtn.UseVisualStyleBackColor = false;
            income_clearBtn.Click += income_clearBtn_Click;
            // 
            // income_deleteBtn
            // 
            income_deleteBtn.BackColor = Color.DarkTurquoise;
            income_deleteBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            income_deleteBtn.Location = new Point(612, 204);
            income_deleteBtn.Name = "income_deleteBtn";
            income_deleteBtn.Size = new Size(95, 65);
            income_deleteBtn.TabIndex = 12;
            income_deleteBtn.Text = "Delete";
            income_deleteBtn.UseVisualStyleBackColor = false;
            income_deleteBtn.Click += income_deleteBtn_Click;
            // 
            // income_updateBtn
            // 
            income_updateBtn.BackColor = Color.DarkTurquoise;
            income_updateBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            income_updateBtn.Location = new Point(392, 204);
            income_updateBtn.Name = "income_updateBtn";
            income_updateBtn.Size = new Size(95, 65);
            income_updateBtn.TabIndex = 11;
            income_updateBtn.Text = "Update";
            income_updateBtn.UseVisualStyleBackColor = false;
            income_updateBtn.Click += income_updateBtn_Click;
            // 
            // income_addBtn
            // 
            income_addBtn.BackColor = Color.DarkTurquoise;
            income_addBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            income_addBtn.Location = new Point(187, 204);
            income_addBtn.Name = "income_addBtn";
            income_addBtn.Size = new Size(95, 65);
            income_addBtn.TabIndex = 10;
            income_addBtn.Text = "Add";
            income_addBtn.UseVisualStyleBackColor = false;
            income_addBtn.Click += income_addBtn_Click;
            // 
            // income_item
            // 
            income_item.Location = new Point(235, 104);
            income_item.Name = "income_item";
            income_item.Size = new Size(146, 27);
            income_item.TabIndex = 9;
            // 
            // income_income
            // 
            income_income.Location = new Point(235, 158);
            income_income.Name = "income_income";
            income_income.Size = new Size(146, 27);
            income_income.TabIndex = 8;
            // 
            // income_description
            // 
            income_description.Location = new Point(634, 40);
            income_description.Multiline = true;
            income_description.Name = "income_description";
            income_description.Size = new Size(308, 70);
            income_description.TabIndex = 7;
            // 
            // income_date
            // 
            income_date.Location = new Point(634, 129);
            income_date.Name = "income_date";
            income_date.Size = new Size(274, 27);
            income_date.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label6.Location = new Point(516, 129);
            label6.Name = "label6";
            label6.Size = new Size(54, 22);
            label6.TabIndex = 5;
            label6.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label5.Location = new Point(516, 54);
            label5.Name = "label5";
            label5.Size = new Size(109, 22);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label4.Location = new Point(143, 161);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 3;
            label4.Text = "Income:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label3.Location = new Point(143, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 2;
            label3.Text = "Item:";
            // 
            // income_category
            // 
            income_category.FormattingEnabled = true;
            income_category.Location = new Point(235, 48);
            income_category.Name = "income_category";
            income_category.Size = new Size(146, 28);
            income_category.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label2.Location = new Point(132, 51);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 0;
            label2.Text = "Category:";
            // 
            // incomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "incomeForm";
            Size = new Size(1148, 748);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox income_item;
        private TextBox income_income;
        private TextBox income_description;
        private DateTimePicker income_date;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox income_category;
        private Label label2;
        private Button income_addBtn;
        private Button income_deleteBtn;
        private Button income_updateBtn;
        private Button income_clearBtn;
    }
}
