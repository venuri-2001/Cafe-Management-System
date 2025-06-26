namespace cmsystem
{
    partial class CashierOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierOrderform_menuTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierOrderform_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierOrderform_productID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrderform_prodName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrderform_quantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrderform_price = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CashierOrderForm_Removebtn = new System.Windows.Forms.Button();
            this.CashierOrderForm_Clearbtn = new System.Windows.Forms.Button();
            this.CashierOrderForm_Addbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CashierOrderForm_Receiptbtn = new System.Windows.Forms.Button();
            this.CashierOrderForm_Paybtn = new System.Windows.Forms.Button();
            this.cashierOrderform_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrderform_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cashierOrderform_orderprice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrderform_orderTable = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderform_menuTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderform_quantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderform_orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierOrderform_menuTable);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 283);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // cashierOrderform_menuTable
            // 
            this.cashierOrderform_menuTable.AllowUserToAddRows = false;
            this.cashierOrderform_menuTable.AllowUserToDeleteRows = false;
            this.cashierOrderform_menuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrderform_menuTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cashierOrderform_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cashierOrderform_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderform_menuTable.EnableHeadersVisualStyles = false;
            this.cashierOrderform_menuTable.Location = new System.Drawing.Point(11, 48);
            this.cashierOrderform_menuTable.Name = "cashierOrderform_menuTable";
            this.cashierOrderform_menuTable.ReadOnly = true;
            this.cashierOrderform_menuTable.RowHeadersVisible = false;
            this.cashierOrderform_menuTable.Size = new System.Drawing.Size(612, 224);
            this.cashierOrderform_menuTable.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type:";
            // 
            // cashierOrderform_type
            // 
            this.cashierOrderform_type.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_type.FormattingEnabled = true;
            this.cashierOrderform_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cashierOrderform_type.Location = new System.Drawing.Point(112, 39);
            this.cashierOrderform_type.Name = "cashierOrderform_type";
            this.cashierOrderform_type.Size = new System.Drawing.Size(162, 28);
            this.cashierOrderform_type.TabIndex = 12;
            this.cashierOrderform_type.SelectedIndexChanged += new System.EventHandler(this.cashierOrderform_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product ID:";
            // 
            // cashierOrderform_productID
            // 
            this.cashierOrderform_productID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_productID.FormattingEnabled = true;
            this.cashierOrderform_productID.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.cashierOrderform_productID.Location = new System.Drawing.Point(413, 39);
            this.cashierOrderform_productID.Name = "cashierOrderform_productID";
            this.cashierOrderform_productID.Size = new System.Drawing.Size(162, 28);
            this.cashierOrderform_productID.TabIndex = 14;
            this.cashierOrderform_productID.SelectedIndexChanged += new System.EventHandler(this.cashierOrderform_productID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Name:";
            // 
            // cashierOrderform_prodName
            // 
            this.cashierOrderform_prodName.AutoSize = true;
            this.cashierOrderform_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_prodName.Location = new System.Drawing.Point(115, 88);
            this.cashierOrderform_prodName.Name = "cashierOrderform_prodName";
            this.cashierOrderform_prodName.Size = new System.Drawing.Size(82, 14);
            this.cashierOrderform_prodName.TabIndex = 16;
            this.cashierOrderform_prodName.Text = "Test Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantity:";
            // 
            // cashierOrderform_quantity
            // 
            this.cashierOrderform_quantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_quantity.Location = new System.Drawing.Point(413, 86);
            this.cashierOrderform_quantity.Name = "cashierOrderform_quantity";
            this.cashierOrderform_quantity.Size = new System.Drawing.Size(162, 26);
            this.cashierOrderform_quantity.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price ($):";
            // 
            // cashierOrderform_price
            // 
            this.cashierOrderform_price.AutoSize = true;
            this.cashierOrderform_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_price.Location = new System.Drawing.Point(115, 135);
            this.cashierOrderform_price.Name = "cashierOrderform_price";
            this.cashierOrderform_price.Size = new System.Drawing.Size(28, 14);
            this.cashierOrderform_price.TabIndex = 20;
            this.cashierOrderform_price.Text = "100";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CashierOrderForm_Removebtn);
            this.panel2.Controls.Add(this.CashierOrderForm_Clearbtn);
            this.panel2.Controls.Add(this.CashierOrderForm_Addbtn);
            this.panel2.Controls.Add(this.cashierOrderform_price);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cashierOrderform_quantity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cashierOrderform_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrderform_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cashierOrderform_type);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 283);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CashierOrderForm_Removebtn
            // 
            this.CashierOrderForm_Removebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashierOrderForm_Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrderForm_Removebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrderForm_Removebtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrderForm_Removebtn.Location = new System.Drawing.Point(236, 214);
            this.CashierOrderForm_Removebtn.Name = "CashierOrderForm_Removebtn";
            this.CashierOrderForm_Removebtn.Size = new System.Drawing.Size(147, 33);
            this.CashierOrderForm_Removebtn.TabIndex = 23;
            this.CashierOrderForm_Removebtn.Text = "REMOVE";
            this.CashierOrderForm_Removebtn.UseVisualStyleBackColor = false;
            // 
            // CashierOrderForm_Clearbtn
            // 
            this.CashierOrderForm_Clearbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashierOrderForm_Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrderForm_Clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrderForm_Clearbtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrderForm_Clearbtn.Location = new System.Drawing.Point(425, 214);
            this.CashierOrderForm_Clearbtn.Name = "CashierOrderForm_Clearbtn";
            this.CashierOrderForm_Clearbtn.Size = new System.Drawing.Size(147, 33);
            this.CashierOrderForm_Clearbtn.TabIndex = 22;
            this.CashierOrderForm_Clearbtn.Text = "CLEAR";
            this.CashierOrderForm_Clearbtn.UseVisualStyleBackColor = false;
            // 
            // CashierOrderForm_Addbtn
            // 
            this.CashierOrderForm_Addbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashierOrderForm_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrderForm_Addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrderForm_Addbtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrderForm_Addbtn.Location = new System.Drawing.Point(47, 214);
            this.CashierOrderForm_Addbtn.Name = "CashierOrderForm_Addbtn";
            this.CashierOrderForm_Addbtn.Size = new System.Drawing.Size(147, 33);
            this.CashierOrderForm_Addbtn.TabIndex = 21;
            this.CashierOrderForm_Addbtn.Text = "ADD";
            this.CashierOrderForm_Addbtn.UseVisualStyleBackColor = false;
            this.CashierOrderForm_Addbtn.Click += new System.EventHandler(this.CashierOrderForm_Addbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.CashierOrderForm_Receiptbtn);
            this.panel3.Controls.Add(this.CashierOrderForm_Paybtn);
            this.panel3.Controls.Add(this.cashierOrderform_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cashierOrderform_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrderform_orderprice);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cashierOrderform_orderTable);
            this.panel3.Location = new System.Drawing.Point(658, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 580);
            this.panel3.TabIndex = 2;
            // 
            // CashierOrderForm_Receiptbtn
            // 
            this.CashierOrderForm_Receiptbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashierOrderForm_Receiptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrderForm_Receiptbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrderForm_Receiptbtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrderForm_Receiptbtn.Location = new System.Drawing.Point(13, 533);
            this.CashierOrderForm_Receiptbtn.Name = "CashierOrderForm_Receiptbtn";
            this.CashierOrderForm_Receiptbtn.Size = new System.Drawing.Size(272, 33);
            this.CashierOrderForm_Receiptbtn.TabIndex = 28;
            this.CashierOrderForm_Receiptbtn.Text = "RECEIPT";
            this.CashierOrderForm_Receiptbtn.UseVisualStyleBackColor = false;
            this.CashierOrderForm_Receiptbtn.Click += new System.EventHandler(this.CashierOrderForm_Receiptbtn_Click);
            // 
            // CashierOrderForm_Paybtn
            // 
            this.CashierOrderForm_Paybtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashierOrderForm_Paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrderForm_Paybtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrderForm_Paybtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrderForm_Paybtn.Location = new System.Drawing.Point(13, 476);
            this.CashierOrderForm_Paybtn.Name = "CashierOrderForm_Paybtn";
            this.CashierOrderForm_Paybtn.Size = new System.Drawing.Size(272, 33);
            this.CashierOrderForm_Paybtn.TabIndex = 27;
            this.CashierOrderForm_Paybtn.Text = "PAY";
            this.CashierOrderForm_Paybtn.UseVisualStyleBackColor = false;
            this.CashierOrderForm_Paybtn.Click += new System.EventHandler(this.CashierOrderForm_Paybtn_Click);
            // 
            // cashierOrderform_change
            // 
            this.cashierOrderform_change.AutoSize = true;
            this.cashierOrderform_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_change.Location = new System.Drawing.Point(167, 432);
            this.cashierOrderform_change.Name = "cashierOrderform_change";
            this.cashierOrderform_change.Size = new System.Drawing.Size(14, 14);
            this.cashierOrderform_change.TabIndex = 26;
            this.cashierOrderform_change.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 432);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Change ($):";
            // 
            // cashierOrderform_amount
            // 
            this.cashierOrderform_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_amount.Location = new System.Drawing.Point(167, 378);
            this.cashierOrderform_amount.Name = "cashierOrderform_amount";
            this.cashierOrderform_amount.Size = new System.Drawing.Size(118, 24);
            this.cashierOrderform_amount.TabIndex = 24;
            this.cashierOrderform_amount.TextChanged += new System.EventHandler(this.cashierOrderform_amount_TextChanged);
            this.cashierOrderform_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrderform_amount_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Amount ($):";
            // 
            // cashierOrderform_orderprice
            // 
            this.cashierOrderform_orderprice.AutoSize = true;
            this.cashierOrderform_orderprice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderform_orderprice.Location = new System.Drawing.Point(162, 346);
            this.cashierOrderform_orderprice.Name = "cashierOrderform_orderprice";
            this.cashierOrderform_orderprice.Size = new System.Drawing.Size(28, 14);
            this.cashierOrderform_orderprice.TabIndex = 22;
            this.cashierOrderform_orderprice.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Price ($):";
            // 
            // cashierOrderform_orderTable
            // 
            this.cashierOrderform_orderTable.AllowUserToAddRows = false;
            this.cashierOrderform_orderTable.AllowUserToDeleteRows = false;
            this.cashierOrderform_orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrderform_orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cashierOrderform_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cashierOrderform_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderform_orderTable.EnableHeadersVisualStyles = false;
            this.cashierOrderform_orderTable.Location = new System.Drawing.Point(13, 48);
            this.cashierOrderform_orderTable.Name = "cashierOrderform_orderTable";
            this.cashierOrderform_orderTable.ReadOnly = true;
            this.cashierOrderform_orderTable.RowHeadersVisible = false;
            this.cashierOrderform_orderTable.Size = new System.Drawing.Size(272, 256);
            this.cashierOrderform_orderTable.TabIndex = 3;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrderForm";
            this.Size = new System.Drawing.Size(970, 610);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderform_menuTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderform_quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderform_orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView cashierOrderform_menuTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cashierOrderform_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cashierOrderform_productID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrderform_prodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cashierOrderform_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cashierOrderform_price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CashierOrderForm_Addbtn;
        private System.Windows.Forms.Button CashierOrderForm_Removebtn;
        private System.Windows.Forms.Button CashierOrderForm_Clearbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cashierOrderform_orderTable;
        private System.Windows.Forms.Label cashierOrderform_orderprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cashierOrderform_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CashierOrderForm_Paybtn;
        private System.Windows.Forms.Label cashierOrderform_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CashierOrderForm_Receiptbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
