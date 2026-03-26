using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sales_amd_Invemtory_Management_System
{
    internal class FileHandler
    {
        string path = "staffDetails.txt";
        List<string> staffDetails = new List<string>();
        public List<staffMember> members = new List<staffMember>();

        public void Read()
        {
            try
            {
                if (File.Exists(path))
                {
                    staffDetails = File.ReadAllLines(path).ToList();

                    foreach(string horse in staffDetails)
                    {
                        string[] arr = horse.Split(',');
                        staffMember member = new staffMember(arr[0], arr[1], Convert.ToInt32(arr[2]), Convert.ToBoolean(arr[3]), arr[4]);
                        members.Add(member);
                    }
                }
                else
                {
                    Console.WriteLine("The file you are trying to read does not exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void AddStaffMember(staffMember member)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter writer = new StreamWriter(path, append: true))
                    {
                        writer.WriteLine(member);
                    }
                    MessageBox.Show("Member registered successfully");
                }
                else
                {
                    MessageBox.Show("File path does not exist");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }
        public void UpdateExistingMember(string name, int attempts, bool isLocked)
        {
            try
            {
                staffDetails = File.ReadAllLines(path).ToList();
                for (int i = 0; i < staffDetails.Count; i++)
                {
                    string[] arr = staffDetails[i].Split(',');
                    if (arr[0] == name)
                    {
                        arr[2] = attempts.ToString();
                        arr[3] = isLocked.ToString();
                        staffDetails[i] = string.Join(",", arr);
                        break;
                    }
                }
                using(StreamWriter write = new StreamWriter(path))
                {
                    foreach (string s in staffDetails)
                    {
                        write.WriteLine(s);
                    }
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void UnblockMember(string name, int attempts, bool isLocked)
        {
            try
            {
                staffDetails = File.ReadAllLines(path).ToList();
                bool userFound = false;
                for (int i = 0; i < staffDetails.Count; i++)
                {
                    string[] arr = staffDetails[i].Split(',');
                    if (arr[0].ToLower() == name.ToLower())
                    {
                        userFound = true;
                        if (arr[3] == true.ToString())
                        {
                            arr[2] = attempts.ToString();
                            arr[3] = isLocked.ToString();
                            staffDetails[i] = string.Join(",", arr);
                            MessageBox.Show($"{name} was successfully blocked");
                            break;
                        }
                        else
                        {
                            MessageBox.Show($"{name} is not blocked");
                            break;
                        }
                        
                    }
                }
                if (!userFound)
                {
                    MessageBox.Show("The member you are trying to unblock does not exist");
                }
                using (StreamWriter write = new StreamWriter(path))
                {
                    foreach (string s in staffDetails)
                    {
                        write.WriteLine(s);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
