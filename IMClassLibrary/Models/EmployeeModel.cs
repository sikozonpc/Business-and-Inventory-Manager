using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }

        public string JobRole { get; set; }

        public float Salary { get; set; }

        public int ContactNumber { get; set; }

        public string Adress { get; set; }
    }
}
