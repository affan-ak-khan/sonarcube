namespace budget_manager
{
    partial class CategoryForm
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
            category_deleteBtn = new Button();
            category_clearBtn = new Button();
            category_updateBtn = new Button();
            category_addBtn = new Button();
            category_status = new ComboBox();
            label3 = new Label();
            category_type = new ComboBox();
            label2 = new Label();
            category_category = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(category_deleteBtn);
            panel1.Controls.Add(category_clearBtn);
            panel1.Controls.Add(category_updateBtn);
            panel1.Controls.Add(category_addBtn);
            panel1.Controls.Add(category_status);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(category_type);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(category_category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 697);
            panel1.TabIndex = 0;
            // 
            // category_deleteBtn
            // 
            category_deleteBtn.BackColor = Color.DarkTurquoise;
            category_deleteBtn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_deleteBtn.Location = new Point(176, 491);
            category_deleteBtn.Name = "category_deleteBtn";
            category_deleteBtn.Size = new Size(95, 65);
            category_deleteBtn.TabIndex = 5;
            category_deleteBtn.Text = "Delete";
            category_deleteBtn.UseVisualStyleBackColor = false;
            category_deleteBtn.Click += category_deleteBtn_Click;
            // 
            // category_clearBtn
            // 
            category_clearBtn.BackColor = Color.DarkTurquoise;
            category_clearBtn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_clearBtn.Location = new Point(20, 491);
            category_clearBtn.Name = "category_clearBtn";
            category_clearBtn.Size = new Size(95, 65);
            category_clearBtn.TabIndex = 4;
            category_clearBtn.Text = "Clear";
            category_clearBtn.UseVisualStyleBackColor = false;
            // 
            // category_updateBtn
            // 
            category_updateBtn.BackColor = Color.DarkTurquoise;
            category_updateBtn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_updateBtn.Location = new Point(176, 396);
            category_updateBtn.Name = "category_updateBtn";
            category_updateBtn.Size = new Size(95, 65);
            category_updateBtn.TabIndex = 3;
            category_updateBtn.Text = "Update";
            category_updateBtn.UseVisualStyleBackColor = false;
            category_updateBtn.Click += category_updateBtn_Click;
            // 
            // category_addBtn
            // 
            category_addBtn.BackColor = Color.DarkTurquoise;
            category_addBtn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_addBtn.Location = new Point(20, 396);
            category_addBtn.Name = "category_addBtn";
            category_addBtn.Size = new Size(95, 65);
            category_addBtn.TabIndex = 0;
            category_addBtn.Text = "Add";
            category_addBtn.UseVisualStyleBackColor = false;
            category_addBtn.Click += category_addBtn_Click;
            // 
            // category_status
            // 
            category_status.FormattingEnabled = true;
            category_status.Items.AddRange(new object[] { "Active", "Inactive" });
            category_status.Location = new Point(20, 304);
            category_status.Name = "category_status";
            category_status.Size = new Size(251, 28);
            category_status.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(20, 264);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // category_type
            // 
            category_type.FormattingEnabled = true;
            category_type.Items.AddRange(new object[] { "Income", "Expense" });
            category_type.Location = new Point(20, 192);
            category_type.Name = "category_type";
            category_type.Size = new Size(251, 28);
            category_type.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(20, 152);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Type";
            // 
            // category_category
            // 
            category_category.Location = new Point(20, 97);
            category_category.Name = "category_category";
            category_category.Size = new Size(251, 27);
            category_category.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(20, 49);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(366, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 697);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(693, 607);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 22);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 0;
            label4.Text = "Categories List";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(1148, 748);
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox category_category;
        private Label label1;
        private Panel panel2;
        private Button category_deleteBtn;
        private Button category_clearBtn;
        private Button category_updateBtn;
        private Button category_addBtn;
        private ComboBox category_status;
        private Label label3;
        private ComboBox category_type;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
    }
}
