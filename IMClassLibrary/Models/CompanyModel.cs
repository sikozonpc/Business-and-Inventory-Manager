using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Models
{
    public class CompanyModel
    {
        // Each company data is linked to a user (admin) that can controll that set of data
        public int LinkedUserID { get; set; }

        public string CompanyName { get; set; }

        public string CurrentMonthBudget { get; set; } = "0";

        public string CurrentMonthSpent { get; set; } = "0";

        public double LastMonthSpending { get; set; } = 0;

        public double LastYearTotalSpending { get; set; } = 0;

        public double TotalSpending { get; set; } = 0;

        public string Currency { get; set; } = "€";

        public string BusinessType { get; set; }
    }
}
