using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sales_amd_Invemtory_Management_System
{
    internal class DataHandler
    {
        string conn = @"Server =(local); Initial Catalog =Inventory; Integrated Security =SSPI";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        public DataTable DisplayProducts()
        {
            string querry = @"SELECT * FROM Products";
            connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(querry, connection);
            adapter.Fill(table);
            return table;
        }
        public void AddNewProduct(string productName, string category, double price, int stockQuantity)
        {
            string querry = $@"INSERT INTO Products VALUES('{productName}','{category}','{price}','{stockQuantity}')";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(querry, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New product added successfully");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateProduct(int id, string name, string category, double price, int stockQuantity)
        {
            string querry = $@"UPDATE Products SET [ProductName] ='{name}', [Category] ='{category}', [Price] ='{price}', [StockQuantity] ='{stockQuantity}' WHERE [ProductId] = '{id}'";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(querry, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Update was successfull");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteProduct(int id)
        {
            string querry = $@"DELETE FROM Products WHERE [ProductId] ='{id}'";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(querry, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Product successfully deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable DisplayCustomers()
        {
            string querry = "SELECT * FROM Customers";
            connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(querry, connection);
            adapter.Fill(table);
            return table;
        }
        public void AddCustomer(string name, string email, string phoneNumber)
        {
            string querry = $@"INSERT INTO Customers VALUES('{name}','{email}','{phoneNumber}')";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(querry, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New customer added successfully");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateCustomer(int id, string name, string email, string phoneNumber)
        {
            string querry = $@"UPDATE Customers SET [CustomerName] ='{name}', [Email] ='{email}', [PhoneNumber] ='{phoneNumber}' WHERE [CustomerId] ='{id}'";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(querry, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteCustomer(int id)
        {
            string querry = $@"DELETE FROM Customers WHERE [CustomerId] ='{id}'";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(querry, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Customer successfully deleted");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable DisplayOrders()
        {
            string querry = "SELECT * FROM Orders";
            connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(querry, connection);
            adapter.Fill(table);
            return table;
        }
        public void PlaceOrder(int customerId, int ProductId, int Quantity)
        {
            string querry = "SELECT * FROM Products";
            connection = new SqlConnection(conn);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(querry, connection);
            adapter.Fill(table);
            List<Product> products = new List<Product>();

            foreach (DataRow row in table.Rows)
            {
                products.Add(new Product {Id = Convert.ToInt32(row["ProductId"]) ,Name = row["ProductName"].ToString(),Category = row["Category"].ToString(),Price = Convert.ToDouble(row["Price"]), StockQuantity = Convert.ToInt32(row["StockQuantity"])});
            }
            bool temp = false;
            foreach (var horse in products)
            {
                if(horse.Id == ProductId)
                {
                    if(Quantity <= horse.StockQuantity)
                    {
                        int stockRemaining = horse.StockQuantity - Quantity;
                        string updateProductQuery = $@"UPDATE Products SET [ProductName] = '{horse.Name}', [Category] = '{horse.Category}', [Price] = '{horse.Price}', [StockQuantity] = '{stockRemaining}' WHERE [ProductId] = '{horse.Id}'";
                        string addOrderQuery = $@"INSERT INTO Orders VALUES('{customerId}','{ProductId}','{Quantity}')";

                        //Adding new order querry
                        connection = new SqlConnection(conn);
                        connection.Open();
                        command = new SqlCommand(addOrderQuery, connection);
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Order successfully placed");

                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                        //Updating Product database
                        connection = new SqlConnection(conn);
                        connection.Open();
                        command = new SqlCommand(updateProductQuery, connection);

                        try
                        {
                            command.ExecuteNonQuery();

                        }catch( Exception ex )
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                        break;
                    }
                    temp = true;
                }
            }
            if (temp)
            {
                MessageBox.Show("The quantity entered is larger than what is available in the invetory");
            }
        }
        public void UpdateOrder(int orderNumber, int customeId, int ProductId, int Quantity)
        {
            string query = $@"UPDATE Orders SET [CustomerId] = '{customeId}', [ProductId] = '{ProductId}', [Quantity] = '{Quantity}' WHERE [OrderNumber] = '{orderNumber}'";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(query, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Order updated successfully");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteOrder(int orderNumber)
        {
            string query = $@"DELETE FROM Orders WHERE [orderNumber] = '{orderNumber}'";
            connection = new SqlConnection(conn);
            connection.Open();
            command = new SqlCommand(query, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Order deleted successfully");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
