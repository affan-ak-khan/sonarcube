using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budget_manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Form1.username;

            greetUser.Text = "Welcome, " + getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
        }


        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to close?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to logout?", "Configuration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;
            Dashboard dForm = dashboard1 as Dashboard;
            if (dForm != null)
            {
                dForm.refreshData();
            }


        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;
            CategoryForm cForm = categoryForm1 as CategoryForm;
            if (cForm != null)
            {
                cForm.refreshData();
            }

        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expenseForm1.Visible = false;
            incomeForm iForm = incomeForm1 as incomeForm;
           if (iForm != null)
            {
                iForm.refreshData();
            }

        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = true;
            ExpenseForm eForm = expenseForm1 as ExpenseForm;
            if (eForm != null)
            {
               eForm.refreshData();
            }

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
