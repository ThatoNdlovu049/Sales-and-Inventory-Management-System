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
    public partial class NewProductForm : Form
    {
        DataHandler handler = new DataHandler();
        BindingSource src = new BindingSource();
        public NewProductForm()
        {
            InitializeComponent();
            src.DataSource = handler.DisplayProducts();
            dataGridView1.DataSource = src;

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(pName.Text) || string.IsNullOrWhiteSpace(pCategory.Text) || string.IsNullOrWhiteSpace(pPrice.Text) || string.IsNullOrWhiteSpace(pQuantity.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            if(!double.TryParse(pPrice.Text, out double price))
            {
                MessageBox.Show("Only numbers required in price");
                return;
            }
            if(!int.TryParse(pQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a number");
                return;
            }

            string productName = pName.Text;
            string productCategory = pCategory.Text;
            double productPrice = Convert.ToDouble(pPrice.Text);
            int stockQuantity = Convert.ToInt32(pQuantity.Text);

            Product product = new Product {Name = productName, Category = productCategory, Price = productPrice, StockQuantity = stockQuantity };
            handler.AddNewProduct(product.Name, product.Category, product.Price, product.StockQuantity);
           
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(pName.Text) || string.IsNullOrWhiteSpace(pCategory.Text) || string.IsNullOrWhiteSpace(pPrice.Text) || string.IsNullOrWhiteSpace(pQuantity.Text))
             {
                MessageBox.Show("All fields are required");
                return;
             }
            if (!double.TryParse(pPrice.Text, out double price))
            {
                MessageBox.Show("Only numbers required in price");
                return;
            }
            if (!int.TryParse(pQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a number");
                return;
            }
            int productId = int.Parse(id_txt.Text);
            handler.DeleteProduct(productId);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pName.Text) || string.IsNullOrWhiteSpace(pCategory.Text) || string.IsNullOrWhiteSpace(pPrice.Text) || string.IsNullOrWhiteSpace(pQuantity.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            if (!double.TryParse(pPrice.Text, out double price))
            {
                MessageBox.Show("Only numbers required in price");
                return;
            }
            if (!int.TryParse(pQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a number");
                return;
            }

            int productid = int.Parse(id_txt.Text);
            string productName = pName.Text;
            string productCategory = pCategory.Text;
            double productPrice = Convert.ToDouble(pPrice.Text);
            int stockQuantity = Convert.ToInt32(pQuantity.Text);
            handler.UpdateProduct(productid, productName, productCategory, productPrice, stockQuantity);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                id_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString();
                pName.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                pCategory.Text = dataGridView1.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                pPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                pQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells["StockQuantity"].FormattedValue.ToString();

            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
