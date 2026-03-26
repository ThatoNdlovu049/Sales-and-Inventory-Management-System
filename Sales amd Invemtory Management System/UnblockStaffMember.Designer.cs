namespace Sales_amd_Invemtory_Management_System
{
    partial class UnblockStaffMember
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
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.unblockMember_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter UserName Of StaffMember";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(319, 70);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(159, 20);
            this.userName_txt.TabIndex = 1;
            // 
            // unblockMember_btn
            // 
            this.unblockMember_btn.Location = new System.Drawing.Point(119, 132);
            this.unblockMember_btn.Name = "unblockMember_btn";
            this.unblockMember_btn.Size = new System.Drawing.Size(114, 35);
            this.unblockMember_btn.TabIndex = 2;
            this.unblockMember_btn.Text = "Unblock";
            this.unblockMember_btn.UseVisualStyleBackColor = true;
            this.unblockMember_btn.Click += new System.EventHandler(this.unblockMember_btn_Click);
            // 
            // UnblockStaffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unblockMember_btn);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.label1);
            this.Name = "UnblockStaffMember";
            this.Text = "UnblockStaffMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Button unblockMember_btn;
    }
}