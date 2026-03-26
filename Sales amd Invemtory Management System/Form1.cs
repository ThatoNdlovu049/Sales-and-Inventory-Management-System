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
            handler.Read();

            try
            {
                string userName = username.Text;
                string userPassword = password.Text;

                if(!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(userPassword))
                {
                    bool userFound = false;
                    
                    foreach(staffMember horse in handler.members)
                    {
                        if(horse.UserName == userName)
                        {
                            userFound = true;
                            if (horse.isLocked)
                            {
                                MessageBox.Show("Your account has been blocked contact administrator");
                                username.Text = string.Empty;
                                password.Text = string.Empty;
                            }
                            else if (horse.Password == userPassword)
                            {

                                if (horse.Role.ToLower() == "staff")
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
                            else
                            {
                                horse.Attempts++;
                                if (horse.Attempts >= 3)
                                {
                                    horse.isLocked = true;
                                    MessageBox.Show("Your account has been blocked contact administrator");
                                    handler.UpdateExistingMember(horse.UserName, horse.Attempts, horse.isLocked);
                                    username.Text = string.Empty;
                                    password.Text = string.Empty;
                                }
                                else
                                {
                                    MessageBox.Show($"Incorrect username or password!{horse.Attempts}");
                                }
                            }
                            return;
                        }
                    }
                    if (!userFound)
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
