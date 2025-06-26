using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cmsystem
{
    internal class AdminAddUsersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User_1\Documents\CM.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string Image { set; get; }
        public string DateRegistered { set; get; }

        public List<AdminAddUsersData> UsersListData()
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AdminAddUsersData usersData = new AdminAddUsersData();
                            usersData.ID = (int)reader["id"];
                            usersData.Username = reader["username"].ToString();
                            usersData.Password = reader["password"].ToString();
                            usersData.Role = reader["role"].ToString();
                            usersData.Status = reader["status"].ToString();
                            usersData.Image = reader["profile_image"].ToString();
                            usersData.DateRegistered = reader["date_reg"].ToString();

                            listData.Add(usersData);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Connection Failed:" +ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
