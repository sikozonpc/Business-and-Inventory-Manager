using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Models
{
    public class PersonalFinanceModel : CompanyModel
    {
        // Each company data is linked to a user (admin) that can controll that set of data
        public new int LinkedUserID { get; set; }

        public string OwnerName { get; set; }

        public double TotalIncome { get; set; }

        public double Expenses { get; set; }

        public double HouseRents { get; set; }

        public double Debts { get; set; }

        public new string Currency { get; set; } = "€";

        public new string BusinessType { get; set; } = "PersonalFinance";
    }
}
