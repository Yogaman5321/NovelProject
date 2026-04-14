using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string EncryptedPassword { get; set; }

        public DateTime AccountCreatedDate { get; set; }

    }
}
