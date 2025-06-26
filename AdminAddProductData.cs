﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cmsystem
{
    internal class AdminAddProductData
    {
        public int ID { set; get; } // 0 
        public string ProductID { set; get; } // 1
        public string ProductName { set; get; } // 2
        public string Type { set; get; } // 3
        public string Stock {  set; get; } // 4
        public string Price { set; get; } // 5
        public string Status { set; get; } // 6
        public string Image {  set; get; } // 7
        public string DateInsert {  set; get; } // 8

        public string DateUpdate { set; get; } // 9

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User_1\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public List<AdminAddProductData> productsListData()
        {
            List<AdminAddProductData> listData = new List<AdminAddProductData>();

            if(connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products  WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AdminAddProductData apd = new AdminAddProductData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();
                            apd.Image = reader["prod_image"].ToString();
                            apd.DateInsert = reader["date_insert"].ToString();
                            apd.DateUpdate = reader["date_update"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch(Exception ex) 
                {
                    Console.WriteLine("Failed Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
        public List<AdminAddProductData> availableProductData()
        {
            List<AdminAddProductData> listData = new List<AdminAddProductData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELLECT * FROM products WHERE status = @stats";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Available");


                    
                    
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AdminAddProductData apd = new AdminAddProductData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                           

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);


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
