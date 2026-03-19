namespace Sales_amd_Invemtory_Management_System
{
    partial class StaffForm
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
            this.order_btn = new System.Windows.Forms.Button();
            this.newProduct_btn = new System.Windows.Forms.Button();
            this.newCustomer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(125, 230);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(120, 36);
            this.order_btn.TabIndex = 0;
            this.order_btn.Text = "Place New Order";
            this.order_btn.UseVisualStyleBackColor = true;
            // 
            // newProduct_btn
            // 
            this.newProduct_btn.Location = new System.Drawing.Point(125, 101);
            this.newProduct_btn.Name = "newProduct_btn";
            this.newProduct_btn.Size = new System.Drawing.Size(120, 36);
            this.newProduct_btn.TabIndex = 1;
            this.newProduct_btn.Text = "Add New Product";
            this.newProduct_btn.UseVisualStyleBackColor = true;
            this.newProduct_btn.Click += new System.EventHandler(this.newProduct_btn_Click);
            // 
            // newCustomer_btn
            // 
            this.newCustomer_btn.Location = new System.Drawing.Point(125, 163);
            this.newCustomer_btn.Name = "newCustomer_btn";
            this.newCustomer_btn.Size = new System.Drawing.Size(120, 36);
            this.newCustomer_btn.TabIndex = 2;
            this.newCustomer_btn.Text = "Add New Customer";
            this.newCustomer_btn.UseVisualStyleBackColor = true;
            this.newCustomer_btn.Click += new System.EventHandler(this.newCustomer_btn_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newCustomer_btn);
            this.Controls.Add(this.newProduct_btn);
            this.Controls.Add(this.order_btn);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button newProduct_btn;
        private System.Windows.Forms.Button newCustomer_btn;
    }
}