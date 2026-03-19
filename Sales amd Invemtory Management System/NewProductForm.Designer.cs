namespace Sales_amd_Invemtory_Management_System
{
    partial class NewProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pPrice = new System.Windows.Forms.TextBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Display_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pQuantity = new System.Windows.Forms.TextBox();
            this.pCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Id";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(241, 72);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(130, 20);
            this.id_txt.TabIndex = 6;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(241, 109);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(130, 20);
            this.pName.TabIndex = 7;
            // 
            // pPrice
            // 
            this.pPrice.Location = new System.Drawing.Point(535, 72);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(130, 20);
            this.pPrice.TabIndex = 10;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(457, 216);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(102, 23);
            this.Delete_btn.TabIndex = 11;
            this.Delete_btn.Text = "Delete Product";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(349, 216);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(102, 23);
            this.Update_btn.TabIndex = 12;
            this.Update_btn.Text = "Update Product";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(241, 216);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(102, 23);
            this.Add_btn.TabIndex = 13;
            this.Add_btn.Text = "Add Product";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Display_btn
            // 
            this.Display_btn.Location = new System.Drawing.Point(133, 216);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(102, 23);
            this.Display_btn.TabIndex = 14;
            this.Display_btn.Text = "Display Products";
            this.Display_btn.UseVisualStyleBackColor = true;
            this.Display_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(565, 216);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 23);
            this.Exit_btn.TabIndex = 15;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pQuantity
            // 
            this.pQuantity.Location = new System.Drawing.Point(535, 109);
            this.pQuantity.Name = "pQuantity";
            this.pQuantity.Size = new System.Drawing.Size(130, 20);
            this.pQuantity.TabIndex = 17;
            // 
            // pCategory
            // 
            this.pCategory.FormattingEnabled = true;
            this.pCategory.Items.AddRange(new object[] {
            "ELECTRONICS",
            "ACCESSORIES"});
            this.pCategory.Location = new System.Drawing.Point(241, 147);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(130, 21);
            this.pCategory.TabIndex = 18;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pCategory);
            this.Controls.Add(this.pQuantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.pPrice);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.TextBox pPrice;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Display_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pQuantity;
        private System.Windows.Forms.ComboBox pCategory;
    }
}