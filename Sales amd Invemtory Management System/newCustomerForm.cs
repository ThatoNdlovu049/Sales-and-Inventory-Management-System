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
    public partial class newCustomerForm : Form
    {
        BindingSource src = new BindingSource();
        DataHandler handler = new DataHandler();
        public newCustomerForm()
        {
            InitializeComponent();
            src.DataSource = handler.DisplayCustomers();
            CustomersdataGridView1.DataSource = src;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void newCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            CustomersdataGridView1.DataSource = handler.DisplayCustomers();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(CustomerName.Text) || string.IsNullOrWhiteSpace(CustomerEmail.Text) || string.IsNullOrWhiteSpace(PhoneNumber.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            string name = CustomerName.Text;
            string email = CustomerEmail.Text;
            string phoneNumber = PhoneNumber.Text;

            Customer customer = new Customer(name,email,phoneNumber);
            handler.AddCustomer(customer.Name, customer.Email, customer.PhoneNumber);
        }

        private void CustomersdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersdataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CustomersdataGridView1.CurrentRow.Selected = true;

                id_txt.Text = CustomersdataGridView1.Rows[e.RowIndex].Cells["Customerid"].FormattedValue.ToString();
                CustomerName.Text = CustomersdataGridView1.Rows[e.RowIndex].Cells["CustomerName"].FormattedValue.ToString();
                CustomerEmail.Text = CustomersdataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                PhoneNumber.Text = CustomersdataGridView1.Rows[e.RowIndex].Cells["PhoneNumber"].FormattedValue.ToString();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerName.Text) || string.IsNullOrWhiteSpace(CustomerEmail.Text) || string.IsNullOrWhiteSpace(PhoneNumber.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int id = int.Parse(id_txt.Text);
            string name = CustomerName.Text;
            string email = CustomerEmail.Text;
            string phoneNumber = PhoneNumber.Text;

            handler.UpdateCustomer(id, name, email, phoneNumber);

            id_txt.Text = "";
            CustomerName.Text = "";
            CustomerEmail.Text = "";
            PhoneNumber.Text = "";
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_txt.Text);

            handler.DeleteCustomer(id);

            id_txt.Text = "";
            CustomerName.Text = "";
            CustomerEmail.Text = "";
            PhoneNumber.Text = "";
        }
    }
}
