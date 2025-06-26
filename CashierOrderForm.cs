using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;



namespace cmsystem
{
    public partial class CashierOrderForm : UserControl
    {
        public static int getCustID;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User_1\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public CashierOrderForm()
        {

            InitializeComponent();

            displayAvailableProds();

            displayAllOrders();

            displayTotalPrice();
        }

        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.availableProductData();

            cashierOrderform_menuTable.DataSource = listData;
        }

        public void displayAllOrders()
        {
            CashierOrdersData allOrders = new CashierOrdersData();

            List<CashierOrdersData> listData = allOrders.ordersListData();

            cashierOrderform_orderTable.DataSource = listData;
        }

        private float totalPrice;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@custID", idGen);

                        object result = cmd.ExecuteScalar();

                        float totalPrice;
                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashierOrderform_orderprice.Text = totalPrice.ToString();
                        }
                        else
                        {
                            totalPrice = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                
                
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashierOrderForm_Addbtn_Click(object sender, EventArgs e)
        {
            IDGenerator();  

            if(cashierOrderform_type.SelectedIndex == -1 || cashierOrderform_productID.SelectedIndex == -1
               || cashierOrderform_prodName.Text == "" || cashierOrderform_quantity.Value == 0
               || cashierOrderform_price.Text == "" )
            {
                MessageBox.Show("Please select the producct first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using(SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", cashierOrderform_productID.Text.Trim());

                            using(SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["prod_price"];
                                    if(rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToInt32(rawValue);
                                    }
                                    
                                }
                            }
                        }

                        string insertOrder = "INSERT INTO orders (customer_id, prod_id, prod_name, qty, prod_price, order_date) " +
                            "VALUES(@customerID, @prodID, @prodName, @prodType, @qty, @prodPrice, @orderDate)";

                        DateTime today = DateTime.Today;

                        using(SqlCommand cmd =  new SqlCommand(insertOrder, connect))
                        {
                            cmd.Parameters.AddWithValue("@customerID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", cashierOrderform_productID.Text.Trim());
                            cmd.Parameters.AddWithValue("@prodName", cashierOrderform_prodName.Text);
                            cmd.Parameters.AddWithValue("@prodType", cashierOrderform_type.Text.Trim());

                            float totalPrice = (getPrice * (int)cashierOrderform_quantity.Value);

                            cmd.Parameters.AddWithValue("@qty", cashierOrderform_quantity.Value);
                            cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@@orderDate", today);

                            cmd.ExecuteNonQuery();

                            displayTotalPrice();
                            displayAllOrders();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }
        private int idGen = 0;
        public void IDGenerator()
        {
            using(SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User_1\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                connect.Open();

                string selectID = "SELECT  MAX(customer_id) FROM customers";

                using(SqlCommand cmd =  new SqlCommand(selectID, connect))
                {
                    object result = cmd.ExecuteScalar();
                    
                    if(result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen += 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                    getCustID = idGen;
                }
            }

            
        }

        private void cashierOrderform_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrderform_productID.SelectedIndex = -1;
            cashierOrderform_productID.Items.Clear();
            cashierOrderform_prodName.Text = "";
            cashierOrderform_price.Text = "";
            
            

            string selectedValue = cashierOrderform_type.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User_1\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                    {

                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_type = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();

                                    cashierOrderform_productID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierOrderform_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrderform_type.SelectedItem as string;

            if(selectedValue != null)
            {
                try
                {
                     using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User_1\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                   {

                    connect.Open();
                    string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prodName = reader["prod_name"].ToString();
                                string prodprice = reader["prod_price"].ToString();

                                cashierOrderform_prodName.Text = prodName;
                                cashierOrderform_price.Text = prodprice;

                            }
                        }
                    }
                   }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }



            }
        }

        private void cashierOrderform_amount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cashierOrderform_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                try
                {
                    float getAmount = Convert.ToSingle(cashierOrderform_amount.Text);

                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        cashierOrderform_amount.Text = "";
                        cashierOrderform_change.Text = "";
                    }
                    else
                    {
                        cashierOrderform_change.Text = getChange.ToString();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid" , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrderform_amount.Text = "";
                    cashierOrderform_change.Text = "";
                }
            }
        }

        private void CashierOrderForm_Paybtn_Click(object sender, EventArgs e)
        {
            if(cashierOrderform_amount.Text == "" || cashierOrderform_orderTable.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                if(MessageBox.Show("Are you sure for paying?", "Confirmation Message"
                ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            IDGenerator();
                            displayTotalPrice();

                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                "VALUES(@custID, @totalprice, @amount, @change, @date)";

                            DateTime today = DateTime.Today;

                            using(SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", cashierOrderform_amount.Text);
                                cmd.Parameters.AddWithValue("@change", cashierOrderform_change.Text);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Paid Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                
            }
            displayTotalPrice();
        }

        private int rowIndex = 0;

        
        private void CashierOrderForm_Receiptbtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colwidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Cafe Master";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (cashierOrderform_orderTable.Columns.Count / 2) * colwidth, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "CID", "ProdID", "ProdName", "ProdType", "Qty", "Price" };

            for(int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colwidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while(rowIndex < cashierOrderform_orderTable.Rows.Count)
            {
                DataGridViewRow row = cashierOrderform_orderTable.Rows[rowIndex];

                for(int i = 0; i < cashierOrderform_orderTable.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colwidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if(y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 90);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("----------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price: \t$" + totalPrice + "\nAmount: \t$"
                + cashierOrderform_amount.Text + "\n\t\t---------------\nChange: \t$" + cashierOrderform_change.Text, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont
                , Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("----------------------", labelFont).Width, y);

        }
    }
}
