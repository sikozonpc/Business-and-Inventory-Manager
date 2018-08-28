using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string CompanyType { get; set; } = "Default";

        // Not encrypted because this is not a real world app
        public string Password { get; set; }

        // FirstTime = 0 -> Not the first time (False)
        // FirstTime = 1 -> First Time (True)
        public int FirstTime { get; set; } = 1;

    }

   
}
