namespace Sales_amd_Invemtory_Management_System
{
    partial class AdminForm
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
            this.newProduct_btn = new System.Windows.Forms.Button();
            this.newCustomer_btn = new System.Windows.Forms.Button();
            this.newOrder_btn = new System.Windows.Forms.Button();
            this.unblockStaff_btn = new System.Windows.Forms.Button();
            this.AddNewStaffMember_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newProduct_btn
            // 
            this.newProduct_btn.Location = new System.Drawing.Point(78, 85);
            this.newProduct_btn.Name = "newProduct_btn";
            this.newProduct_btn.Size = new System.Drawing.Size(127, 34);
            this.newProduct_btn.TabIndex = 0;
            this.newProduct_btn.Text = "Add New Product";
            this.newProduct_btn.UseVisualStyleBackColor = true;
            this.newProduct_btn.Click += new System.EventHandler(this.newProduct_btn_Click);
            // 
            // newCustomer_btn
            // 
            this.newCustomer_btn.Location = new System.Drawing.Point(78, 137);
            this.newCustomer_btn.Name = "newCustomer_btn";
            this.newCustomer_btn.Size = new System.Drawing.Size(127, 34);
            this.newCustomer_btn.TabIndex = 1;
            this.newCustomer_btn.Text = "Add New Customer";
            this.newCustomer_btn.UseVisualStyleBackColor = true;
            this.newCustomer_btn.Click += new System.EventHandler(this.newCustomer_btn_Click);
            // 
            // newOrder_btn
            // 
            this.newOrder_btn.Location = new System.Drawing.Point(78, 192);
            this.newOrder_btn.Name = "newOrder_btn";
            this.newOrder_btn.Size = new System.Drawing.Size(127, 34);
            this.newOrder_btn.TabIndex = 2;
            this.newOrder_btn.Text = "Place New Order";
            this.newOrder_btn.UseVisualStyleBackColor = true;
            this.newOrder_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // unblockStaff_btn
            // 
            this.unblockStaff_btn.Location = new System.Drawing.Point(244, 85);
            this.unblockStaff_btn.Name = "unblockStaff_btn";
            this.unblockStaff_btn.Size = new System.Drawing.Size(127, 34);
            this.unblockStaff_btn.TabIndex = 3;
            this.unblockStaff_btn.Text = "Unblock Staff Member";
            this.unblockStaff_btn.UseVisualStyleBackColor = true;
            this.unblockStaff_btn.Click += new System.EventHandler(this.unblockStaff_btn_Click);
            // 
            // AddNewStaffMember_btn
            // 
            this.AddNewStaffMember_btn.Location = new System.Drawing.Point(244, 137);
            this.AddNewStaffMember_btn.Name = "AddNewStaffMember_btn";
            this.AddNewStaffMember_btn.Size = new System.Drawing.Size(127, 34);
            this.AddNewStaffMember_btn.TabIndex = 4;
            this.AddNewStaffMember_btn.Text = "Add New Staff Member";
            this.AddNewStaffMember_btn.UseVisualStyleBackColor = true;
            this.AddNewStaffMember_btn.Click += new System.EventHandler(this.AddNewStaffMember_btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewStaffMember_btn);
            this.Controls.Add(this.unblockStaff_btn);
            this.Controls.Add(this.newOrder_btn);
            this.Controls.Add(this.newCustomer_btn);
            this.Controls.Add(this.newProduct_btn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newProduct_btn;
        private System.Windows.Forms.Button newCustomer_btn;
        private System.Windows.Forms.Button newOrder_btn;
        private System.Windows.Forms.Button unblockStaff_btn;
        private System.Windows.Forms.Button AddNewStaffMember_btn;
    }
}