using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_amd_Invemtory_Management_System
{
    internal class staffMember
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Attempts { get; set; }
        public bool isLocked { get; set; }
        public string Role { get; set; }

        public staffMember(string userName, string password, int attempts, bool isLocked, string role)
        {
            UserName = userName;
            Password = password;
            Attempts = attempts;
            this.isLocked = isLocked;
            Role = role;
        }

        public override string ToString()
        {
            return $"{UserName},{Password},{Attempts},{isLocked},{Role}";
        }
    }
}
