namespace Sales_amd_Invemtory_Management_System
{
    partial class OrdersForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.CustomerId_txt = new System.Windows.Forms.TextBox();
            this.ProductId_txt = new System.Windows.Forms.TextBox();
            this.OrderQuantity_txt = new System.Windows.Forms.TextBox();
            this.CustomersdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductsdataGridView2 = new System.Windows.Forms.DataGridView();
            this.Display_orders_btn = new System.Windows.Forms.Button();
            this.place_order_btn = new System.Windows.Forms.Button();
            this.Modify_order_btn = new System.Windows.Forms.Button();
            this.OrdersdataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteOrder_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsdataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(120, 69);
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Size = new System.Drawing.Size(100, 20);
            this.orderId.TabIndex = 4;
            // 
            // CustomerId_txt
            // 
            this.CustomerId_txt.Location = new System.Drawing.Point(120, 125);
            this.CustomerId_txt.Name = "CustomerId_txt";
            this.CustomerId_txt.ReadOnly = true;
            this.CustomerId_txt.Size = new System.Drawing.Size(100, 20);
            this.CustomerId_txt.TabIndex = 5;
            // 
            // ProductId_txt
            // 
            this.ProductId_txt.Location = new System.Drawing.Point(120, 179);
            this.ProductId_txt.Name = "ProductId_txt";
            this.ProductId_txt.ReadOnly = true;
            this.ProductId_txt.Size = new System.Drawing.Size(100, 20);
            this.ProductId_txt.TabIndex = 6;
            // 
            // OrderQuantity_txt
            // 
            this.OrderQuantity_txt.Location = new System.Drawing.Point(120, 230);
            this.OrderQuantity_txt.Name = "OrderQuantity_txt";
            this.OrderQuantity_txt.Size = new System.Drawing.Size(100, 20);
            this.OrderQuantity_txt.TabIndex = 7;
            // 
            // CustomersdataGridView1
            // 
            this.CustomersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersdataGridView1.Location = new System.Drawing.Point(247, 172);
            this.CustomersdataGridView1.Name = "CustomersdataGridView1";
            this.CustomersdataGridView1.Size = new System.Drawing.Size(452, 78);
            this.CustomersdataGridView1.TabIndex = 8;
            this.CustomersdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersdataGridView1_CellClick);
            // 
            // ProductsdataGridView2
            // 
            this.ProductsdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsdataGridView2.Location = new System.Drawing.Point(247, 69);
            this.ProductsdataGridView2.Name = "ProductsdataGridView2";
            this.ProductsdataGridView2.Size = new System.Drawing.Size(522, 78);
            this.ProductsdataGridView2.TabIndex = 9;
            this.ProductsdataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsdataGridView2_CellClick);
            // 
            // Display_orders_btn
            // 
            this.Display_orders_btn.Location = new System.Drawing.Point(48, 277);
            this.Display_orders_btn.Name = "Display_orders_btn";
            this.Display_orders_btn.Size = new System.Drawing.Size(91, 23);
            this.Display_orders_btn.TabIndex = 10;
            this.Display_orders_btn.Text = "Display Orders";
            this.Display_orders_btn.UseVisualStyleBackColor = true;
            this.Display_orders_btn.Click += new System.EventHandler(this.Display_orders_btn_Click);
            // 
            // place_order_btn
            // 
            this.place_order_btn.Location = new System.Drawing.Point(164, 277);
            this.place_order_btn.Name = "place_order_btn";
            this.place_order_btn.Size = new System.Drawing.Size(91, 23);
            this.place_order_btn.TabIndex = 11;
            this.place_order_btn.Text = "Place Order";
            this.place_order_btn.UseVisualStyleBackColor = true;
            this.place_order_btn.Click += new System.EventHandler(this.place_order_btn_Click);
            // 
            // Modify_order_btn
            // 
            this.Modify_order_btn.Location = new System.Drawing.Point(283, 277);
            this.Modify_order_btn.Name = "Modify_order_btn";
            this.Modify_order_btn.Size = new System.Drawing.Size(91, 23);
            this.Modify_order_btn.TabIndex = 12;
            this.Modify_order_btn.Text = "Modify Order";
            this.Modify_order_btn.UseVisualStyleBackColor = true;
            this.Modify_order_btn.Click += new System.EventHandler(this.Modify_order_btn_Click);
            // 
            // OrdersdataGridView1
            // 
            this.OrdersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersdataGridView1.Location = new System.Drawing.Point(48, 306);
            this.OrdersdataGridView1.Name = "OrdersdataGridView1";
            this.OrdersdataGridView1.Size = new System.Drawing.Size(442, 95);
            this.OrdersdataGridView1.TabIndex = 13;
            this.OrdersdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersdataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reload Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear Fields";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteOrder_btn
            // 
            this.deleteOrder_btn.Location = new System.Drawing.Point(507, 277);
            this.deleteOrder_btn.Name = "deleteOrder_btn";
            this.deleteOrder_btn.Size = new System.Drawing.Size(91, 23);
            this.deleteOrder_btn.TabIndex = 16;
            this.deleteOrder_btn.Text = "Delete Order";
            this.deleteOrder_btn.UseVisualStyleBackColor = true;
            this.deleteOrder_btn.Click += new System.EventHandler(this.deleteOrder_btn_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteOrder_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrdersdataGridView1);
            this.Controls.Add(this.Modify_order_btn);
            this.Controls.Add(this.place_order_btn);
            this.Controls.Add(this.Display_orders_btn);
            this.Controls.Add(this.ProductsdataGridView2);
            this.Controls.Add(this.CustomersdataGridView1);
            this.Controls.Add(this.OrderQuantity_txt);
            this.Controls.Add(this.ProductId_txt);
            this.Controls.Add(this.CustomerId_txt);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsdataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.TextBox CustomerId_txt;
        private System.Windows.Forms.TextBox ProductId_txt;
        private System.Windows.Forms.TextBox OrderQuantity_txt;
        private System.Windows.Forms.DataGridView CustomersdataGridView1;
        private System.Windows.Forms.DataGridView ProductsdataGridView2;
        private System.Windows.Forms.Button Display_orders_btn;
        private System.Windows.Forms.Button place_order_btn;
        private System.Windows.Forms.Button Modify_order_btn;
        private System.Windows.Forms.DataGridView OrdersdataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteOrder_btn;
    }
}