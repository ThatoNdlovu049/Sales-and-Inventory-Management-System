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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void newCustomer_btn_Click(object sender, EventArgs e)
        {
            newCustomerForm form = new newCustomerForm();
            form.ShowDialog();
        }

        private void newProduct_btn_Click(object sender, EventArgs e)
        {
            NewProductForm form = new NewProductForm();
            form.ShowDialog();
        }

        private void addNewStaffMember_btn_Click(object sender, EventArgs e)
        {
            AddStaffMember form = new AddStaffMember();
            form.ShowDialog();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }
    }
}
