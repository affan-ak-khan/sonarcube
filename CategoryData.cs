using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace budget_manager
{
    internal class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\HAJI LAPTOP\Desktop\budget_manager 2\budget_manager\budget_manager\tracker.mdf"";Integrated Security=True;Connect Timeout=30;";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Type { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }

                }
            }
            return listData;
        }
    }
}