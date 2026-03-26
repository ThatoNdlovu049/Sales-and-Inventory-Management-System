namespace Sales_amd_Invemtory_Management_System
{
    partial class AddStaffMember
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
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.addStaff_txt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.role_txt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Staff Member UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Staff Member Password";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(317, 157);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(164, 20);
            this.password_txt.TabIndex = 2;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(317, 76);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(164, 20);
            this.username_txt.TabIndex = 3;
            // 
            // addStaff_txt
            // 
            this.addStaff_txt.Location = new System.Drawing.Point(126, 195);
            this.addStaff_txt.Name = "addStaff_txt";
            this.addStaff_txt.Size = new System.Drawing.Size(117, 36);
            this.addStaff_txt.TabIndex = 4;
            this.addStaff_txt.Text = "Add Staff Member";
            this.addStaff_txt.UseVisualStyleBackColor = true;
            this.addStaff_txt.Click += new System.EventHandler(this.addStaff_txt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Staff Member Role";
            // 
            // role_txt
            // 
            this.role_txt.FormattingEnabled = true;
            this.role_txt.Items.AddRange(new object[] {
            "staff",
            "admin"});
            this.role_txt.Location = new System.Drawing.Point(317, 117);
            this.role_txt.Name = "role_txt";
            this.role_txt.Size = new System.Drawing.Size(164, 21);
            this.role_txt.TabIndex = 6;
            // 
            // AddStaffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.role_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addStaff_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStaffMember";
            this.Text = "AddStaffMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Button addStaff_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox role_txt;
    }
}