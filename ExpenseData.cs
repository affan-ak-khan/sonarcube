using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace budget_manager
{
    internal class ExpenseData
    {
        string stringConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\HAJI LAPTOP\Desktop\budget_manager 2\budget_manager\budget_manager\tracker.mdf"";Integrated Security=True;Connect Timeout=30;";


        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

        public List<ExpenseData> Expenselistdata()
        {
            List<ExpenseData> listData = new List<ExpenseData>();
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM expen";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpenseData eData = new ExpenseData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateIncome = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

                        listData.Add(eData);

                    }
                    
                }

            }
            return listData;

        }
    }
}

