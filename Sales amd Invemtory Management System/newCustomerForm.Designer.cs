namespace Sales_amd_Invemtory_Management_System
{
    partial class newCustomerForm
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
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.display_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.CustomersdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(568, 174);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(112, 20);
            this.PhoneNumber.TabIndex = 4;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(282, 170);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(112, 20);
            this.CustomerEmail.TabIndex = 5;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(568, 97);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(112, 20);
            this.CustomerName.TabIndex = 6;
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(178, 234);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(105, 23);
            this.display_btn.TabIndex = 8;
            this.display_btn.Text = "Display Customers";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(289, 234);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(105, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add Customer";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(400, 234);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(105, 23);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Update Customer";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(622, 234);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(58, 23);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(511, 234);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(105, 23);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete Customer";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(282, 97);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(112, 20);
            this.id_txt.TabIndex = 14;
            // 
            // CustomersdataGridView1
            // 
            this.CustomersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersdataGridView1.Location = new System.Drawing.Point(178, 288);
            this.CustomersdataGridView1.Name = "CustomersdataGridView1";
            this.CustomersdataGridView1.Size = new System.Drawing.Size(502, 150);
            this.CustomersdataGridView1.TabIndex = 15;
            this.CustomersdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersdataGridView1_CellClick);
            // 
            // newCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.CustomersdataGridView1);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newCustomerForm";
            this.Text = "newCustomerForm";
            this.Load += new System.EventHandler(this.newCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Button display_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.DataGridView CustomersdataGridView1;
    }
}