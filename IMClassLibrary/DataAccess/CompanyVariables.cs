using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.DataAccess
{
    public static class CompanyVariables
    {
        public static int CurrentLoggedInUserID { get; set; }


        public static string CompanyName { get; set; } = "Company";

        public static string CurrentMonthBudget { get; set; } = "0";

        public static string CurrentMonthSpent { get; set; } = "0";

        public static double LastMonthSpending { get; set; } = 0;

        public static double LastYearTotalSpending { get; set; } = 0;

        public static double TotalSpending { get; set; } = 0;

        public static string Currency { get; set; } = "€";

    }
}
