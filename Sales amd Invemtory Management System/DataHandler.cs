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
    }
}
