using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    }
}
