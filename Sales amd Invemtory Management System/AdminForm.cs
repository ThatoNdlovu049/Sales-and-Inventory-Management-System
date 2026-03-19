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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
