using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_amd_Invemtory_Management_System
{
    public partial class AddStaffMember : Form
    {
        FileHandler handler = new FileHandler();
        public AddStaffMember()
        {
            InitializeComponent();
        }

        private void addStaff_txt_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(username_txt.Text) || string.IsNullOrWhiteSpace(role_txt.Text) || string.IsNullOrWhiteSpace(password_txt.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            string username = username_txt.Text;
            string role = role_txt.Text;
            string password = password_txt.Text;

            staffMember member = new staffMember(username, password, 0, false, role);
            handler.AddStaffMember(member);
        }
    }
}
