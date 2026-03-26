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
    public partial class UnblockStaffMember : Form
    {
        FileHandler handler = new FileHandler();
        public UnblockStaffMember()
        {
            InitializeComponent();
        }

        private void unblockMember_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName_txt.Text))
            {
                MessageBox.Show("Username cant be empty");
            }
            string username = userName_txt.Text;
            handler.UnblockMember(username, 0, false);
            userName_txt.Text = string.Empty;
        }
    }
}
