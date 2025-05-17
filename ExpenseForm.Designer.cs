namespace budget_manager
{
    partial class ExpenseForm
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
            expense_clearBtn = new Button();
            expense_deleteBtn = new Button();
            expense_updateBtn = new Button();
            expense_addBtn = new Button();
            expense_item = new TextBox();
            expense_cost = new TextBox();
            expense_description = new TextBox();
            expense_date = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            expense_category = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // expense_clearBtn
            // 
            expense_clearBtn.BackColor = Color.DarkTurquoise;
            expense_clearBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expense_clearBtn.Location = new Point(791, 204);
            expense_clearBtn.Name = "expense_clearBtn";
            expense_clearBtn.Size = new Size(95, 65);
            expense_clearBtn.TabIndex = 13;
            expense_clearBtn.Text = "Clear";
            expense_clearBtn.UseVisualStyleBackColor = false;
            expense_clearBtn.Click += expense_clearBtn_Click;
            // 
            // expense_deleteBtn
            // 
            expense_deleteBtn.BackColor = Color.DarkTurquoise;
            expense_deleteBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expense_deleteBtn.Location = new Point(612, 204);
            expense_deleteBtn.Name = "expense_deleteBtn";
            expense_deleteBtn.Size = new Size(95, 65);
            expense_deleteBtn.TabIndex = 12;
            expense_deleteBtn.Text = "Delete";
            expense_deleteBtn.UseVisualStyleBackColor = false;
            expense_deleteBtn.Click += expense_deleteBtn_Click;
            // 
            // expense_updateBtn
            // 
            expense_updateBtn.BackColor = Color.DarkTurquoise;
            expense_updateBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expense_updateBtn.Location = new Point(392, 204);
            expense_updateBtn.Name = "expense_updateBtn";
            expense_updateBtn.Size = new Size(95, 65);
            expense_updateBtn.TabIndex = 11;
            expense_updateBtn.Text = "Update";
            expense_updateBtn.UseVisualStyleBackColor = false;
            expense_updateBtn.Click += expense_updateBtn_Click;
            // 
            // expense_addBtn
            // 
            expense_addBtn.BackColor = Color.DarkTurquoise;
            expense_addBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expense_addBtn.Location = new Point(187, 204);
            expense_addBtn.Name = "expense_addBtn";
            expense_addBtn.Size = new Size(95, 65);
            expense_addBtn.TabIndex = 10;
            expense_addBtn.Text = "Add";
            expense_addBtn.UseVisualStyleBackColor = false;
            expense_addBtn.Click += expense_addBtn_Click;
            // 
            // expense_item
            // 
            expense_item.Location = new Point(235, 104);
            expense_item.Name = "expense_item";
            expense_item.Size = new Size(146, 27);
            expense_item.TabIndex = 9;
            // 
            // expense_cost
            // 
            expense_cost.Location = new Point(235, 158);
            expense_cost.Name = "expense_cost";
            expense_cost.Size = new Size(146, 27);
            expense_cost.TabIndex = 8;
            // 
            // expense_description
            // 
            expense_description.Location = new Point(634, 40);
            expense_description.Multiline = true;
            expense_description.Name = "expense_description";
            expense_description.Size = new Size(308, 70);
            expense_description.TabIndex = 7;
            // 
            // expense_date
            // 
            expense_date.Location = new Point(644, 129);
            expense_date.Name = "expense_date";
            expense_date.Size = new Size(274, 27);
            expense_date.TabIndex = 6;
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
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(516, 56);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label4.Location = new Point(143, 161);
            label4.Name = "label4";
            label4.Size = new Size(53, 22);
            label4.TabIndex = 3;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label3.Location = new Point(143, 104);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 2;
            label3.Text = "Item:";
            // 
            // expense_category
            // 
            expense_category.FormattingEnabled = true;
            expense_category.Location = new Point(235, 48);
            expense_category.Name = "expense_category";
            expense_category.Size = new Size(146, 28);
            expense_category.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label2.Location = new Point(138, 51);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 0;
            label2.Text = "Category:";
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
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(167, 27);
            label1.TabIndex = 0;
            label1.Text = "Expense List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(expense_clearBtn);
            panel2.Controls.Add(expense_deleteBtn);
            panel2.Controls.Add(expense_updateBtn);
            panel2.Controls.Add(expense_addBtn);
            panel2.Controls.Add(expense_item);
            panel2.Controls.Add(expense_cost);
            panel2.Controls.Add(expense_description);
            panel2.Controls.Add(expense_date);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(expense_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(41, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 292);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 395);
            panel1.TabIndex = 2;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ExpenseForm";
            Size = new Size(1148, 748);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button expense_clearBtn;
        private Button expense_deleteBtn;
        private Button expense_updateBtn;
        private Button expense_addBtn;
        private TextBox expense_item;
        private TextBox expense_cost;
        private TextBox expense_description;
        private DateTimePicker expense_date;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox expense_category;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}
