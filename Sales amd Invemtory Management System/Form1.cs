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
    public partial class Form1 : Form
    {
        FileHandler handler = new FileHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            handler.members.Clear();
            handler.Read();

            try
            {
                string userName = username.Text;
                string userPassword = password.Text;

                if(!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(userPassword))
                {
                    bool userFound = false;
                    bool passwordCorrect = false;
                    foreach(staffMember horse in handler.members)
                    {
                        if(horse.UserName == userName)
                        {
                            userFound = true;
                            if(horse.Password == userPassword)
                            {
                                passwordCorrect = true;
                                if(horse.Role.ToLower() == "staff")
                                {
                                    StaffForm form = new StaffForm();
                                    form.ShowDialog();
                                    username.Text = string.Empty;
                                    password.Text = string.Empty;
                                }
                                else
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.ShowDialog();
                                    username.Text = string.Empty;
                                    password.Text = string.Empty;
                                }
                                
                            }
                        }
                    }
                    if (!userFound || !passwordCorrect)
                    {
                        MessageBox.Show("Incorrect username or password");
                        username.Text = string.Empty;
                        password.Text = string.Empty;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Username/Password cant be empty");
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
