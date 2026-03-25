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
    public partial class OrdersForm : Form
    {
        DataHandler handler = new DataHandler();
        BindingSource src = new BindingSource();
        BindingSource dst = new BindingSource();
        BindingSource tsd = new BindingSource();
        public OrdersForm()
        {
            InitializeComponent();
            src.DataSource = handler.DisplayProducts();
            dst.DataSource = handler.DisplayCustomers();
            tsd.DataSource = handler.DisplayOrders();
            CustomersdataGridView1.DataSource = dst;
            ProductsdataGridView2.DataSource = src;
            OrdersdataGridView1.DataSource = tsd;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductsdataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsdataGridView2.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                ProductsdataGridView2.CurrentRow.Selected = true;

                ProductId_txt.Text = ProductsdataGridView2.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString();
            }
        }

        private void CustomersdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersdataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CustomersdataGridView1.CurrentCell.Selected = true;

                CustomerId_txt.Text = CustomersdataGridView1.Rows[e.RowIndex].Cells["Customerid"].FormattedValue.ToString();

            }
        }

        private void place_order_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerId_txt.Text) || string.IsNullOrWhiteSpace(ProductId_txt.Text) || string.IsNullOrWhiteSpace(OrderQuantity_txt.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            if(!int.TryParse(OrderQuantity_txt.Text, out int quantity))
            {
                MessageBox.Show("Stock quantity is supposed to be an integer");
                return;
            }
            int customerId = int.Parse(CustomerId_txt.Text);
            int productId = int.Parse(ProductId_txt.Text);
            int stockQuantity = quantity;

            handler.PlaceOrder(customerId, productId, stockQuantity);
            orderId.Text = string.Empty;
            CustomerId_txt.Text = string.Empty;
            ProductId_txt.Text = string.Empty;
            OrderQuantity_txt.Text = string.Empty;
        }

        private void Display_orders_btn_Click(object sender, EventArgs e)
        {
            OrdersdataGridView1.DataSource = handler.DisplayOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsdataGridView2.DataSource = handler.DisplayProducts();
        }

        private void OrdersdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdersdataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                OrdersdataGridView1.CurrentRow.Selected = true;

                orderId.Text = OrdersdataGridView1.Rows[e.RowIndex].Cells["OrderNumber"].FormattedValue.ToString();
                CustomerId_txt.Text = OrdersdataGridView1.Rows[e.RowIndex].Cells["CustomerId"].FormattedValue.ToString();
                ProductId_txt.Text = OrdersdataGridView1.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString();
                OrderQuantity_txt.Text = OrdersdataGridView1.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
            }
        }

        private void Modify_order_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(orderId.Text) || string.IsNullOrWhiteSpace(CustomerId_txt.Text) || string.IsNullOrWhiteSpace(ProductId_txt.Text) || string.IsNullOrWhiteSpace(OrderQuantity_txt.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            if (!int.TryParse(OrderQuantity_txt.Text, out int quantity))
            {
                MessageBox.Show("Quantity needs to be an integer");
                return;
            }
            int orderNumber = Convert.ToInt32(orderId.Text);
            int customerId = Convert.ToInt32(CustomerId_txt.Text);
            int ProductId = Convert.ToInt32(ProductId_txt.Text);
            int ProductQuantity = quantity;
            handler.UpdateOrder(orderNumber, customerId, ProductId, ProductQuantity);
            orderId.Text = string.Empty;
            CustomerId_txt.Text = string.Empty;
            ProductId_txt.Text = string.Empty;
            OrderQuantity_txt.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderId.Text = string.Empty;
            CustomerId_txt.Text = string.Empty;
            ProductId_txt.Text = string.Empty;
            OrderQuantity_txt.Text = string.Empty;
        }
    }
}
