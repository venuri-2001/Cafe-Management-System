namespace cmsystem
{
    partial class AdminAddProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminAddProducts_clearbtn = new System.Windows.Forms.Button();
            this.adminAddProducts_deletebtn = new System.Windows.Forms.Button();
            this.adminAddProducts_updatebtn = new System.Windows.Forms.Button();
            this.adminAddProducts_addbtn = new System.Windows.Forms.Button();
            this.adminAddProducts_importbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddProducts_imageview = new System.Windows.Forms.PictureBox();
            this.adminAddProducts_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminAddProducts_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminAddProducts_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adminAddProducts_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddProducts_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddProducts_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 317);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data of Products";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(13, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(919, 261);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.adminAddProducts_clearbtn);
            this.panel2.Controls.Add(this.adminAddProducts_deletebtn);
            this.panel2.Controls.Add(this.adminAddProducts_updatebtn);
            this.panel2.Controls.Add(this.adminAddProducts_addbtn);
            this.panel2.Controls.Add(this.adminAddProducts_importbtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.adminAddProducts_status);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.adminAddProducts_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.adminAddProducts_stock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.adminAddProducts_type);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.adminAddProducts_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.adminAddProducts_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 245);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // adminAddProducts_clearbtn
            // 
            this.adminAddProducts_clearbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminAddProducts_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_clearbtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_clearbtn.Location = new System.Drawing.Point(599, 171);
            this.adminAddProducts_clearbtn.Name = "adminAddProducts_clearbtn";
            this.adminAddProducts_clearbtn.Size = new System.Drawing.Size(93, 33);
            this.adminAddProducts_clearbtn.TabIndex = 22;
            this.adminAddProducts_clearbtn.Text = "CLEAR";
            this.adminAddProducts_clearbtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_clearbtn.Click += new System.EventHandler(this.adminAddUsers_clearbtn_Click);
            // 
            // adminAddProducts_deletebtn
            // 
            this.adminAddProducts_deletebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminAddProducts_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_deletebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_deletebtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_deletebtn.Location = new System.Drawing.Point(466, 171);
            this.adminAddProducts_deletebtn.Name = "adminAddProducts_deletebtn";
            this.adminAddProducts_deletebtn.Size = new System.Drawing.Size(93, 33);
            this.adminAddProducts_deletebtn.TabIndex = 21;
            this.adminAddProducts_deletebtn.Text = "DELETE";
            this.adminAddProducts_deletebtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_deletebtn.Click += new System.EventHandler(this.adminAddUsers_deletebtn_Click);
            // 
            // adminAddProducts_updatebtn
            // 
            this.adminAddProducts_updatebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminAddProducts_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_updatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_updatebtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_updatebtn.Location = new System.Drawing.Point(330, 171);
            this.adminAddProducts_updatebtn.Name = "adminAddProducts_updatebtn";
            this.adminAddProducts_updatebtn.Size = new System.Drawing.Size(93, 33);
            this.adminAddProducts_updatebtn.TabIndex = 20;
            this.adminAddProducts_updatebtn.Text = "UPDATE";
            this.adminAddProducts_updatebtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_updatebtn.Click += new System.EventHandler(this.adminAddProducts_updatebtn_Click);
            // 
            // adminAddProducts_addbtn
            // 
            this.adminAddProducts_addbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminAddProducts_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_addbtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_addbtn.Location = new System.Drawing.Point(197, 171);
            this.adminAddProducts_addbtn.Name = "adminAddProducts_addbtn";
            this.adminAddProducts_addbtn.Size = new System.Drawing.Size(93, 33);
            this.adminAddProducts_addbtn.TabIndex = 19;
            this.adminAddProducts_addbtn.Text = "ADD";
            this.adminAddProducts_addbtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_addbtn.Click += new System.EventHandler(this.adminAddProducts_addbtn_Click);
            // 
            // adminAddProducts_importbtn
            // 
            this.adminAddProducts_importbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminAddProducts_importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddProducts_importbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_importbtn.ForeColor = System.Drawing.Color.White;
            this.adminAddProducts_importbtn.Location = new System.Drawing.Point(822, 142);
            this.adminAddProducts_importbtn.Name = "adminAddProducts_importbtn";
            this.adminAddProducts_importbtn.Size = new System.Drawing.Size(82, 25);
            this.adminAddProducts_importbtn.TabIndex = 18;
            this.adminAddProducts_importbtn.Text = "Import";
            this.adminAddProducts_importbtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_importbtn.Click += new System.EventHandler(this.adminAddUsers_importbtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminAddProducts_imageview);
            this.panel3.Location = new System.Drawing.Point(821, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 100);
            this.panel3.TabIndex = 18;
            // 
            // adminAddProducts_imageview
            // 
            this.adminAddProducts_imageview.BackColor = System.Drawing.Color.Silver;
            this.adminAddProducts_imageview.Location = new System.Drawing.Point(0, 1);
            this.adminAddProducts_imageview.Name = "adminAddProducts_imageview";
            this.adminAddProducts_imageview.Size = new System.Drawing.Size(81, 99);
            this.adminAddProducts_imageview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddProducts_imageview.TabIndex = 17;
            this.adminAddProducts_imageview.TabStop = false;
            this.adminAddProducts_imageview.Click += new System.EventHandler(this.adminAddUsers_imageview_Click);
            // 
            // adminAddProducts_status
            // 
            this.adminAddProducts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_status.FormattingEnabled = true;
            this.adminAddProducts_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.adminAddProducts_status.Location = new System.Drawing.Point(478, 96);
            this.adminAddProducts_status.Name = "adminAddProducts_status";
            this.adminAddProducts_status.Size = new System.Drawing.Size(162, 24);
            this.adminAddProducts_status.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status:";
            // 
            // adminAddProducts_price
            // 
            this.adminAddProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_price.Location = new System.Drawing.Point(477, 60);
            this.adminAddProducts_price.Name = "adminAddProducts_price";
            this.adminAddProducts_price.Size = new System.Drawing.Size(163, 24);
            this.adminAddProducts_price.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price ($):";
            // 
            // adminAddProducts_stock
            // 
            this.adminAddProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_stock.Location = new System.Drawing.Point(477, 22);
            this.adminAddProducts_stock.Name = "adminAddProducts_stock";
            this.adminAddProducts_stock.Size = new System.Drawing.Size(163, 24);
            this.adminAddProducts_stock.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stock:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // adminAddProducts_type
            // 
            this.adminAddProducts_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_type.FormattingEnabled = true;
            this.adminAddProducts_type.Items.AddRange(new object[] {
            "Meal",
            "Drink"});
            this.adminAddProducts_type.Location = new System.Drawing.Point(116, 97);
            this.adminAddProducts_type.Name = "adminAddProducts_type";
            this.adminAddProducts_type.Size = new System.Drawing.Size(162, 24);
            this.adminAddProducts_type.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type:";
            // 
            // adminAddProducts_name
            // 
            this.adminAddProducts_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_name.Location = new System.Drawing.Point(115, 61);
            this.adminAddProducts_name.Name = "adminAddProducts_name";
            this.adminAddProducts_name.Size = new System.Drawing.Size(163, 24);
            this.adminAddProducts_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name:";
            // 
            // adminAddProducts_id
            // 
            this.adminAddProducts_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_id.Location = new System.Drawing.Point(115, 23);
            this.adminAddProducts_id.Name = "adminAddProducts_id";
            this.adminAddProducts_id.Size = new System.Drawing.Size(163, 24);
            this.adminAddProducts_id.TabIndex = 4;
            this.adminAddProducts_id.TextChanged += new System.EventHandler(this.adminAddProducts_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(970, 610);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminAddProducts_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminAddProducts_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox adminAddProducts_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox adminAddProducts_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminAddProducts_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminAddProducts_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adminAddProducts_importbtn;
        private System.Windows.Forms.PictureBox adminAddProducts_imageview;
        private System.Windows.Forms.Button adminAddProducts_clearbtn;
        private System.Windows.Forms.Button adminAddProducts_deletebtn;
        private System.Windows.Forms.Button adminAddProducts_updatebtn;
        private System.Windows.Forms.Button adminAddProducts_addbtn;
    }
}
